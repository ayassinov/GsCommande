using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcListeProduit : UserControl
    {
        private ProduitService _produitService = new ProduitService();
        List<Produit> _produits = new List<Produit>();

        public bool IsShowPrintButton { get; set; }

        public UcListeProduit()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            try
            {
                _produits = _produitService.ListProduitStock();
                produitBindingSource.DataSource = _produits;
                dgvProduits.DataSource = produitBindingSource;
                IsShowPrintButton = dgvProduits.RowCount > 0;
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Liste des produits");
            }
        }

        public void Imprimer()
        {
            try
            {
                //reportListeProduit.RegisterData(_produits, "ListeProduit");
                reportListeProduit.Show(true);
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Liste des produits");
                throw;
            }
        }
    }
}
