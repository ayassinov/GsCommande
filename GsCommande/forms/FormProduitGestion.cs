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

        public void LoadAll()
        {
            var i = lstfamille.SelectedIndex;

            lstfamille.DataSource = _familleService.ListAll();
            if (lstfamille.Items.Count > 0)
            {
                lstfamille.SelectedIndex = i > 0 ? i : 0;
            }
            else
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

        private void SwitchAddEditMode(int mode)
        {
            if (mode == 0)//browsing
            {
                grbAddProduct.Visible = false;
                grbListeDesProduits.Visible = true;
                btnAnnuler.Visible = false;
                btnSave.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = dgvProduits.SelectedRows.Count > 0;
            }
            else if (mode == 1) //adding
            {
                grbAddProduct.Text = @"Ajouter un produit";
                grbAddProduct.Visible = true;
                grbListeDesProduits.Visible = true;

                if (dgvProduits.Rows.Count > 0)
                {
                    grbAddProduct.Dock = DockStyle.Top;
                    grbAddProduct.Height = 110;
                    grbListeDesProduits.Dock = DockStyle.Fill;
                }
                else
                {
                    grbListeDesProduits.Visible = false;
                }

                btnAnnuler.Visible = dgvProduits.Rows.Count > 0;
                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                lblCode.Text = _produitService.GetNextCodeValue(_famille).ToString();
                lblFamille.Text = _famille.Libelle;
            }
            else //editing
            {
                grbAddProduct.Text = @"Modifier le produit";
                grbAddProduct.Visible = true;
                grbListeDesProduits.Visible = false;
                grbAddProduct.Dock = DockStyle.Fill;

                btnAnnuler.Visible = dgvProduits.Rows.Count > 0;
                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                lblCode.Text = _produitService.GetNextCodeValue(_produit.Famille).ToString();
                lblFamille.Text = _produit.Famille.Libelle;
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
                    _produitService.Create(new Produit
                    {
                        Code = Convert.ToInt32(lblCode.Text),
                        Libelle = txtLibelle.Text,
                        Famille = _famille
                    });

                }
                else //update
                {
                    if (_produit.Libelle.ToUpper().CompareTo(txtLibelle.Text.ToUpper()) == 0)
                    {
                        LoadAll();
                        return;
                    }

                    _produit.Libelle = txtLibelle.Text;
                    _produit.Famille = lstfamille.SelectedItem as Famille;
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
            if (lstfamille.SelectedValue != null)
            {
                _famille = lstfamille.SelectedItem as Famille;


                //changement de famille en mode modification ou ajout.
                if (_famille != null && btnAnnuler.Visible)
                {
                    lblCode.Text = _produitService.GetNextCodeValue(_famille).ToString();
                    lblFamille.Text = _famille.Libelle;
                    //chargement des produits 
                    dgvProduits.DataSource = _produitService.
                    GetByFamille(lstfamille.SelectedItem as Famille);
                    return;
                }

                //chargement des produits 
                dgvProduits.DataSource = _produitService.
                GetByFamille(lstfamille.SelectedItem as Famille);


                if (dgvProduits.RowCount == 0) // pas de donnée
                {
                    _produit = null;
                    SwitchAddEditMode(1);
                }
                else
                {
                    // save produit
                    //  _produit = ;
                    if (dgvProduits.SelectedRows.Count > 0)
                    {
                        _produit = dgvProduits.SelectedRows[0].DataBoundItem as Produit;
                        SwitchAddEditMode(0);
                    }
                    else
                    {
                        dgvProduits.Rows[0].Selected = true;
                    }

                }

            }
        }

        private void dgvProduits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduits.Rows.Count > 0)
            {
                if (dgvProduits.SelectedRows.Count > 0)
                {
                    _produit = dgvProduits.SelectedRows[0].DataBoundItem as Produit;
                    if (!btnAnnuler.Visible)
                        SwitchAddEditMode(0);
                }
                else
                {
                    _produit = null;
                    if (!btnAnnuler.Visible)
                        SwitchAddEditMode(1);
                }
            }
            else
            {
                _produit = null;
                if (!btnAnnuler.Visible)
                    SwitchAddEditMode(1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrUpdate();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _produit = null;
            SwitchAddEditMode(1);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = string.Empty;
            btnAnnuler.Visible = false;
            LoadAll();
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
    }
}
