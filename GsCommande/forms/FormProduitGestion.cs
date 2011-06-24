using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormProduitGestion : Form
    {
        private FormFamilleGestion _formFamilleGestion;
        private readonly FamilleService _familleService = new FamilleService();
        private readonly ProduitService _produitService = new ProduitService();

        private Produit _produit = null;
        private Famille _famille = null;
        private bool _isAjoutMode = false;

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
            try
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

                    if (MessageBox.Show(@"Il n'existe acune famille. Voulez-vous ajouter une nouvelle famille?",
                                        @"Gestion des familles",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        _formFamilleGestion = new FormFamilleGestion();
                        _formFamilleGestion.CloseGestionFamilleForm += new FormFamilleGestion.CloseFormHandler(CloseGestionFamilleForm);
                        _formFamilleGestion.LoadAll();
                        _formFamilleGestion.ShowDialog();
                    }
                    else
                    {
                        OnCloseForm();
                    }
                }
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des produits");
            }
        }

        private void CloseGestionFamilleForm()
        {
            _formFamilleGestion.Close();
            _formFamilleGestion.Dispose();
            OnCloseForm();
        }

        private void ModeAffichage()
        {
            try
            {
                if (_modeAffichage == forms.ModeAffichage.Browse)
                {
                    lstfamille.Enabled = true;
                    grbListeDesProduits.Top = 0;
                    grbListeDesProduits.Height = 467;
                    grbListeDesProduits.Visible = true;

                    btnAnnuler.Visible = false;
                    btnSave.Visible = false;
                    btnAdd.Visible = true;
                    btnDelete.Visible = dgvProduits.SelectedRows.Count > 0;
                    btnModifier.Visible = dgvProduits.SelectedRows.Count > 0;
                    txtLibelle.Enabled = false;
                    if (dgvProduits.SelectedRows.Count > 0)
                        _produit = dgvProduits.SelectedRows[0].DataBoundItem as Produit;
                    _famille = lstfamille.SelectedItem as Famille;
                    dgvProduits.Focus();
                }
                else if (_modeAffichage == forms.ModeAffichage.Insert)
                {
                    grbAddProduct.Text = @"Ajouter un produit";
                    grbAddProduct.Visible = true;
                    grbListeDesProduits.Visible = true;

                    btnModifier.Visible = false;
                    txtLibelle.Enabled = true;
                    if (dgvProduits.Rows.Count > 0)
                    {
                        grbListeDesProduits.Top = 144;
                        grbListeDesProduits.Height = 323;

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
                    grbAddProduct.Text = @"Modifier le produit";
                    grbListeDesProduits.Visible = true;
                    grbListeDesProduits.Top = 144;
                    grbListeDesProduits.Height = 323;

                    txtLibelle.Enabled = true;
                    btnModifier.Visible = false;
                    lstfamille.Enabled = false;
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
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des produits");
            }
        }

        private void SaveOrUpdate()
        {

            //test libelle

            if (string.IsNullOrEmpty(txtLibelle.Text.Trim()))
            {
                MessageBox.Show(@"Vous devez entrer un libelle", @"Gestion des produits", MessageBoxButtons.OK,
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
                    txtLibelle.Text = string.Empty;
                    btnAnnuler.Visible = false;
                    grbListeDesProduits.Visible = false;
                    LoadAll();
                    grbListeDesProduits.Visible = true;
                    _produit = null;
                    _modeAffichage = forms.ModeAffichage.Insert;
                    ModeAffichage();


                }
                else //update
                {
                    if (_produit.Libelle.ToUpper().CompareTo(txtLibelle.Text.ToUpper()) == 0 &&
                        _produit.Famille.Libelle.CompareTo(cmbFamille.Text) == 0)
                    {
                        MessageBox.Show(@"Vous devez faire au moins un changement", @"Gestion des produits", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                        return;
                    }

                    _produit.Code = Convert.ToInt32(lblCode.Text);
                    _produit.Libelle = txtLibelle.Text;
                    _produit.Famille = cmbFamille.SelectedItem as Famille;
                    _produitService.Update(_produit);
                    txtLibelle.Text = string.Empty;
                    btnAnnuler.Visible = false;
                    LoadAll();
                }


            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, @"Une erreur s'est produite lors de la sauvegarde des données", "Gestion des produits");
            }
        }

        private void Delete()
        {
            try
            {
                if (MessageBox.Show(@"Vous confirmer la suppression du produit : " + _produit.Libelle,
                                    @"Gestion des produits",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _produitService.Delete(_produit);
                    LoadAll();
                }
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, @"Une erreur s'est produite lors de supression du produit", @"Gestion des produits");
            }
        }

        private void Add()
        {
            _isAjoutMode = true;
            _produit = null;
            _modeAffichage = forms.ModeAffichage.Insert;
            ModeAffichage();
        }

        private void Cancel()
        {
            try
            {
                _isAjoutMode = false;
                txtLibelle.Text = string.Empty;
                btnAnnuler.Visible = false;
                _modeAffichage = forms.ModeAffichage.Browse;

            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des produits");
            }

            ModeAffichage();
        }

        private void Modify()
        {
            try
            {
                //_isAjoutMode = true;
                _modeAffichage = forms.ModeAffichage.Update;
                _produit = dgvProduits.SelectedRows[0].DataBoundItem as Produit;
                ModeAffichage();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des produits");
            }

        }

        private void lstfamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
                }
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des produits");
            }
        }

        private void dgvProduits_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduits.Rows.Count > 0)
                {
                    if (dgvProduits.SelectedRows.Count > 0)
                    {
                        _produit = dgvProduits.SelectedRows[0].DataBoundItem as Produit;
                        if (_isAjoutMode)
                            _modeAffichage = forms.ModeAffichage.Insert;
                        else
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
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des produits");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrUpdate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modify();
        }

        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des produits");
            }
        }

        private void txtLibelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SaveOrUpdate();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                if (btnSave.Visible)
                    SaveOrUpdate();
                return true;
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                if (btnDelete.Visible)
                    Delete();
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                if (btnAdd.Visible)
                    Add();
                return true;
            }

            if (keyData == (Keys.Control | Keys.E))
            {
                if (btnModifier.Visible)
                    Modify();
                return true;
            }

            if (keyData == (Keys.Control | Keys.Z))
            {
                if (btnAnnuler.Visible)
                    Cancel();
                return true;
            }

            if (keyData == (Keys.Escape))
            {
                if (btnExit.Visible)
                    OnCloseForm();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnCloseForm();
        }
    }

    enum ModeAffichage
    {
        Browse = 0,
        Insert,
        Update
    }
}
