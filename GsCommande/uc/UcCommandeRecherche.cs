using System;
using System.Collections.Generic;
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

                List<Commande> commandes = _commandeservice.Recherche(commande);
                commandeBindingSource.DataSource = commandes;
                ligneCommandeBindingSource.DataSource = commandeBindingSource;
                dgvCommandes.AutoResizeColumns();
                dgvLigneCommande.AutoResizeColumns();
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
         //   ligneCommandeBindingSource.DataSource = new List<LigneCommande>();
            OnChangeSelectedCommande();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            _toInclue = false;
            Recherche();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            _toInclue = false;
            Reset();
            Recherche();
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

        private void dgvCommandes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCommandes.SelectedRows.Count > 0)
            {
                SelectedCommande = dgvCommandes.SelectedRows[0].DataBoundItem as Commande;
                OnChangeSelectedCommande();
                OpenCommandeDetail();
            }
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

     
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
dgvCommandes.AutoResizeColumns();
                dgvLigneCommande.AutoResizeColumns();
        } 
    }
}
