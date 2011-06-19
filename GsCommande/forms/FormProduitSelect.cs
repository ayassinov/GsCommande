using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormProduitSelect : Form
    {

        private readonly FamilleService _familleService = new FamilleService();
        private readonly ProduitService _produitService = new ProduitService();

        public LigneCommande LigneCommande = null;
        public bool IsUpdate;
        public List<LigneCommande> LigneCommandes { get; set; }

        public delegate void CloseFormHandler();
        public event CloseFormHandler CloseFormProduitSelect;

        private void OnCloseForm()
        {
            if (CloseFormProduitSelect != null)
                CloseFormProduitSelect();
        }


        public FormProduitSelect()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            lstFamille.DataSource = _familleService.ListAll();

            if (LigneCommande != null)
            {
                //update
                lstFamille.SelectedValue = LigneCommande.Produit.Famille.Id;
                lstProduit.SelectedValue = LigneCommande.Produit.Id;
                txtQteKilo.Value = LigneCommande.Qtekilo;
                txtQteDemiKilo.Value = LigneCommande.QteDemiKilo;

                lstFamille.Enabled = false;
                lstProduit.Enabled = false;
                txtQteDemiKilo.Focus();
            }
            else
            {
                //add
                lstFamille.Enabled = true;
                lstProduit.Enabled = true;
                lstFamille.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFamille.SelectedValue != null)
            {
                var familleId = (int)lstFamille.SelectedValue;
                var allCommandes = _produitService.GetByFamille(new Famille { Id = familleId });

                foreach (var lcmd in LigneCommandes)
                {
                    //todo check this !
                    //supprimer si on est en ajout.
                    if(!IsUpdate)
                        allCommandes.RemoveAll(l => l.Id == lcmd.Produit.Id);
                    //else if(LigneCommande != null && lcmd.Produit.Id != LigneCommande.Produit.Id)
                    //    allCommandes.RemoveAll(l => l.Id == lcmd.Produit.Id);
                }

                lstProduit.DataSource = allCommandes;

                if (!IsUpdate)
                {
                    btnProduitAjouter.Enabled = lstProduit.Items.Count != 0;
                    groupBox1.Enabled = lstProduit.Items.Count != 0;

                }
            }
        }

        private void btnProduitAjouter_Click(object sender, EventArgs e)
        {
            if (lstProduit.SelectedItem == null)
            {
                MessageBox.Show(@"Vous devez choisir un produit", @"Séléction de produit", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                return;

            }

            if (txtQteKilo.Value == 0 && txtQteDemiKilo.Value == 0)
            {
                MessageBox.Show(@"Vous devez enter une quantité.", @"Séléction de produit", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            LigneCommande = new LigneCommande
                                {
                                    Commande = null,
                                    Produit = lstProduit.SelectedItem as Produit,
                                    Qtekilo = (int)txtQteKilo.Value,
                                    QteDemiKilo = (int)txtQteDemiKilo.Value
                                };
            LigneCommande.Produit.Famille = lstFamille.SelectedItem as Famille;
            OnCloseForm();
        }

        private void txtQteDemiKilo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((NumericUpDown)sender).Text.Trim()))
                ((NumericUpDown)sender).Text = @"0";
        }

        private void FormProduitSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseForm();
        }
    }
}
