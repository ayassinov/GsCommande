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

        public FormProduitGestion()
        {
            InitializeComponent();
            LoadAll();
        }

        private void LoadAll()
        {
            var i = lstfamille.SelectedIndex;

            lstfamille.DataSource = _familleService.ListAll();
            if (lstfamille.Items.Count > 0)
            {
                if (i > 0)
                    lstfamille.SelectedIndex = i;
                else
                    lstfamille.SelectedIndex = 0;
            }
            else
            {
                _famille = null;
                //todo when no famille ?? message pas de famille vous devez ajouter une
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
                grbListeDesProduits.Visible = false;
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
            if (_produit == null) // add
            {
                //test libelle

                _produitService.Create(new Produit()
                                           {
                                               Code = Convert.ToInt32(lblCode.Text),
                                               Libelle = txtLibelle.Text,
                                               Famille = _famille
                                           }
                    );

                LoadAll();
            }
        }


        private void lstfamille_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstfamille.SelectedValue != null)
            {
                _famille = lstfamille.SelectedItem as Famille;
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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            SwitchAddEditMode(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrUpdate();
        }

        private void dgvProduits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduits.Rows.Count > 0)
            {
                if (dgvProduits.SelectedRows.Count > 0)
                {
                    _produit = dgvProduits.SelectedRows[0].DataBoundItem as Produit;
                    SwitchAddEditMode(0);
                }
                else
                {
                    _produit = null;
                    SwitchAddEditMode(0);
                }
            }
            else
            {
                _produit = null;
                SwitchAddEditMode(0);
            }
        }
    }
}
