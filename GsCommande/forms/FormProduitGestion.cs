using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormProduitGestion : Form
    {
        private readonly FamilleService _familleService = new FamilleService();
        private readonly ProduitService _produitService = new ProduitService();

        private Produit _produit = null;
        private Famille _famille = null;

        private ModeAffichage _modeAffichage = forms.ModeAffichage.Browse;

        public delegate void CloseFormHandler();
        public event CloseFormHandler CloseGestionProduitForm;

        public void OnCloseForm()
        {
            if (CloseGestionProduitForm != null)
                CloseGestionProduitForm();
        }

        public FormProduitGestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charger la liste des familles et choisir la dernière famille sélectionné.
        /// </summary>
        public void LoadAll()
        {
            var i = lstfamille.SelectedIndex;
            if (lstfamille.Items.Count == 0)
            {
                lstfamille.DataSource = _familleService.ListAll();
            }
            if (lstfamille.Items.Count > 0)
            {
                if (_modeAffichage == forms.ModeAffichage.Update)
                {
                    if (lstfamille.SelectedIndex == cmbFamille.SelectedIndex)
                        lstfamille_SelectedIndexChanged(null, null);
                    else
                        lstfamille.SelectedIndex = cmbFamille.SelectedIndex;

                }
                else
                {
                    if (lstfamille.SelectedIndex == i)
                    {
                        lstfamille_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        lstfamille.SelectedIndex = i > 0 ? i : 0;
                    }

                }
            }
            else // pas de famille il faut en ajouter au moins une avant de continuer.
            {
                _famille = null;

                if (MessageBoxEx.Show(@"Il n'existe acune famille. Voulez-vous ajouter une nouvelle famille?",
                                   @"Gestion des familles",
                                   MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Question) == DialogResult.OK)
                {
                    OnCloseForm();
                    var formFamille = new FormFamilleGestion();
                    formFamille.LoadAll();
                    formFamille.ShowDialog();
                }
                else
                {
                    OnCloseForm();
                }
            }
        }

        private void ModeAffichage()
        {
            if (_modeAffichage == forms.ModeAffichage.Browse)
            {
                lstfamille.Enabled = true;
                grbAddProduct.Visible = false;
                grbListeDesProduits.Visible = true;
                btnAnnuler.Visible = false;
                btnSave.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = dgvProduits.SelectedRows.Count > 0;
                btnModifier.Visible = dgvProduits.SelectedRows.Count > 0;
            }
            else if (_modeAffichage == forms.ModeAffichage.Insert)
            {
                grbAddProduct.Text = @"Ajouter un produit";
                grbAddProduct.Visible = true;
                grbListeDesProduits.Visible = true;
                btnModifier.Visible = false;

                if (dgvProduits.Rows.Count > 0)
                {
                    grbAddProduct.Dock = DockStyle.Top;
                    grbAddProduct.Height = 110;
                    grbListeDesProduits.Dock = DockStyle.Fill;
                    btnAnnuler.Visible = true;
                    lstfamille.Enabled = false;
                }
                else
                {
                    grbListeDesProduits.Visible = false;
                    btnAnnuler.Visible = false;
                    lstfamille.Enabled = true;
                }

                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                lblCode.Text = _produitService.GetNextCodeValue(_famille).ToString();
                lblFamille.Text = _famille.Libelle;
                lblFamille.Visible = true;
                cmbFamille.Visible = false;

                txtLibelle.Focus();
            }
            else //update
            {
                btnModifier.Visible = false;
                lstfamille.Enabled = false;
                grbAddProduct.Text = @"Modifier le produit";
                grbAddProduct.Visible = true;
                grbListeDesProduits.Visible = false;
                grbAddProduct.Dock = DockStyle.Fill;

                btnAnnuler.Visible = dgvProduits.Rows.Count > 0;
                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                lblCode.Text = _produit.Code.ToString();
                lblFamille.Visible = false;
                cmbFamille.Visible = true;
                cmbFamille.DataSource = _familleService.ListAll();
                cmbFamille.SelectedIndex = lstfamille.SelectedIndex;
                txtLibelle.Text = _produit.Libelle;
                txtLibelle.Focus();
            }
        }

        private void SaveOrUpdate()
        {

            //test libelle

            if (string.IsNullOrEmpty(txtLibelle.Text.Trim()))
            {
                MessageBoxEx.Show(@"Vous devez entrer un libelle", @"Gestion des produits", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }


            try
            {
                if (_produit == null)
                {
                    _produit = _produitService.Create(new Produit
                     {
                         Code = Convert.ToInt32(lblCode.Text),
                         Libelle = txtLibelle.Text,
                         Famille = _famille
                     });

                }
                else //update
                {
                    if (_produit.Libelle.ToUpper().CompareTo(txtLibelle.Text.ToUpper()) == 0 &&
                        _produit.Famille.Libelle.CompareTo(cmbFamille.Text) == 0)
                    {
                        MessageBoxEx.Show(@"Vous devez faire au moins un changement", @"Gestion des produits", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                        return;
                    }

                    _produit.Code = Convert.ToInt32(lblCode.Text);
                    _produit.Libelle = txtLibelle.Text;
                    _produit.Famille = cmbFamille.SelectedItem as Famille;
                    _produitService.Update(_produit);
                }

                txtLibelle.Text = string.Empty;
                btnAnnuler.Visible = false;
                LoadAll();
            }
            catch (Exception)
            {

                MessageBoxEx.Show(@"Une erreur s'est produite lors de la sauvegarde des données", @"Gestion des produits", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }

        private void lstfamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on test sur la selcted value not null

            //_famille = selectedItem

            //On charge la liste des produits selon le mode d'affichage.

            //Si on a des produits => Browsable
            //Sinon on affiche le mode => Adding

            if (lstfamille.SelectedValue != null)
            {
                _famille = lstfamille.SelectedItem as Famille;

                //chargement des produits 
                dgvProduits.DataSource = _produitService.GetByFamille(lstfamille.SelectedItem as Famille);

                if (dgvProduits.RowCount == 0) // pas de donnée
                {
                    _produit = null;
                    _modeAffichage = forms.ModeAffichage.Insert;
                    ModeAffichage();
                }
                else // on charge les produit et on met le premier dans la liste
                {
                    dgvProduits.Rows[0].Selected = true;
                }

                //changement de famille en mode modification ou ajout.
                //if (_famille != null && btnAnnuler.Visible)
                //{
                //    lblCode.Text = _produitService.GetNextCodeValue(_famille).ToString();
                //    lblFamille.Text = _famille.Libelle;
                //    //chargement des produits 
                //    dgvProduits.DataSource = _produitService.
                //    GetByFamille(lstfamille.SelectedItem as Famille);
                //    return;
                //}
            }
        }

        private void dgvProduits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduits.Rows.Count > 0)
            {
                if (dgvProduits.SelectedRows.Count > 0)
                {
                    _produit = dgvProduits.SelectedRows[0].DataBoundItem as Produit;
                    _modeAffichage = forms.ModeAffichage.Browse;
                    ModeAffichage();
                }
                else
                {
                    _produit = null;
                    _modeAffichage = forms.ModeAffichage.Insert;
                    ModeAffichage();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrUpdate();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _produit = null;
            _modeAffichage = forms.ModeAffichage.Insert;
            ModeAffichage();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = string.Empty;
            btnAnnuler.Visible = false;
            _modeAffichage = forms.ModeAffichage.Browse;
            ModeAffichage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_produit != null)
                    _produitService.Delete(_produit);

                LoadAll();
            }
            catch (Exception)
            {

                MessageBoxEx.Show(@"Une erreur s'est produite lors de supression du produit", @"Gestion des produits", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            _modeAffichage = forms.ModeAffichage.Update;
            ModeAffichage();
        }

        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFamille.SelectedIndex == lstfamille.SelectedIndex)
            {
                lblCode.Text = _produit.Code.ToString();
            }
            else
            {
                lblCode.Text = _produitService.GetNextCodeValue(cmbFamille.SelectedItem as Famille).ToString();
            }
        }
    }

    enum ModeAffichage
    {
        Browse = 0,
        Insert,
        Update
    }
}
