using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcCommandeRecherche : UserControl
    {
        FormCommandeDetail _fomCommandeDetail = new FormCommandeDetail();
        private CommandeService _commandeservice = new CommandeService();
        private bool _toInclue = false;

        public Commande SelectedCommande { get; set; }

        public delegate void ChangeSelectedCommandeHandler();
        public event ChangeSelectedCommandeHandler ChangeSelectedCommande;

        private void OnChangeSelectedCommande()
        {
            btnLivrer.Enabled = SelectedCommande != null;

            if (ChangeSelectedCommande != null)
                ChangeSelectedCommande();
        }

        public UcCommandeRecherche()
        {
            InitializeComponent();
        }

        public void Recherche()
        {
            try
            {
                SelectedCommande = null;
                var commande = new Commande()
                                   {
                                       Id = (int)numericUpDown1.Value,
                                       DateCommande = (dateTimePicker.Value == DateTime.MinValue) ? (DateTime?)null : dateTimePicker.Value,
                                       IsLivree = _toInclue,
                                       NomPrenomClient = txtClient.Text.Trim()
                                   };

                SortableBindingList<Commande> commandes = _commandeservice.Recherche(commande);
                commandeBindingSource.DataSource = commandes;
                ligneCommandeBindingSource.DataSource = commandeBindingSource;
                dgvCommandes.AutoResizeColumns();
                dgvLigneCommande.AutoResizeColumns();
                OnChangeSelectedCommande();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Recherche commande");
            }
        }

        public void Reset()
        {
            SelectedCommande = null;
            dateTimePicker.Value = DateTime.MinValue;
            txtClient.Text = string.Empty;
            numericUpDown1.Text = string.Empty;
            numericUpDown1.Value = 0;
            commandeBindingSource.DataSource = new List<Commande>();
            OnChangeSelectedCommande();
        }

        private void Livrer()
        {
            try
            {
                if (SelectedCommande == null)
                {
                    MessageBox.Show(@"Aucune commmande n'est sélectionné", @"Modification de la commande",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show(string.Format("Vous êtes sur de vouloir livrer la commande {0} ?", SelectedCommande.Id),
                    @"Modification de la commande",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                _commandeservice.Deliver(SelectedCommande);

            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Modification de la commande");
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            _toInclue = false;
            Recherche();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Livrer selected ligne
            Livrer();

            Recherche(); // reload the last search result.
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _toInclue = true;
            Recherche();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _toInclue = true;
            Reset();
            Recherche();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCommandes.SelectedRows.Count > 0)
            {
                SelectedCommande = dgvCommandes.SelectedRows[0].DataBoundItem as Commande;
                OnChangeSelectedCommande();
            }
        }

        private void dgvCommandes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCommandes.SelectedRows.Count > 0)
            {
                SelectedCommande = dgvCommandes.SelectedRows[0].DataBoundItem as Commande;
                OnChangeSelectedCommande();
                OpenCommandeDetail();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            dgvCommandes.AutoResizeColumns();
            dgvLigneCommande.AutoResizeColumns();
        }

        private void dgvCommandes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCommandes.RowCount == 0)
                return;

            Sort(e.ColumnIndex);
        }

        private void Sort(int selectedColumnIndex)
        {

            ListSortDirection direction;
            var newColumn = dgvCommandes.Columns[selectedColumnIndex];
            var oldColumn = dgvCommandes.SortedColumn;
            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dgvCommandes.SortOrder == SortOrder.Ascending)
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

            dgvCommandes.Sort(newColumn, direction);

            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void OpenCommandeDetail()
        {
            _fomCommandeDetail = new FormCommandeDetail();
            _fomCommandeDetail.CloseCommandeDetailForm += CloseCommandeDetailForm;
            _fomCommandeDetail.SelectedCommande = SelectedCommande;
            _fomCommandeDetail.LoadAll();
            _fomCommandeDetail.ShowDialog();
        }

        private void CloseCommandeDetailForm()
        {
            _fomCommandeDetail.Close();
            _fomCommandeDetail.Dispose();
            Recherche(); // reload the last search result.
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Recherche();
        }
    }
}
