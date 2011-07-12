using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcListeProduit : UserControl
    {
        private ProduitService _produitService = new ProduitService();
        SortableBindingList<Produit> _produits = new SortableBindingList<Produit>();

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
                reportListeProduit.Load("listeproduit.frx");
                reportListeProduit.Show(true);
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Liste des produits");
            }
        }

        private void dgvProduits_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProduits.RowCount == 0)
                return;

            Sort(e.ColumnIndex);
        }

        private void Sort(int selectedColumnIndex)
        {

            ListSortDirection direction;
            var newColumn = dgvProduits.Columns[selectedColumnIndex];
            var oldColumn = dgvProduits.SortedColumn;
            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dgvProduits.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            dgvProduits.Sort(newColumn, direction);

            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
