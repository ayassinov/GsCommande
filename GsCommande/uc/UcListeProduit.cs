using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcListeProduit : UserControl
    {
        private ProduitService _produitService = new ProduitService();
        public bool IsShowPrintButton { get; set; }

        public UcListeProduit()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            try
            {
                dgvProduits.DataSource = _produitService.ListProduitStock();
                IsShowPrintButton = dgvProduits.RowCount > 0;
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Liste des produits");
            }
        }
    }
}
