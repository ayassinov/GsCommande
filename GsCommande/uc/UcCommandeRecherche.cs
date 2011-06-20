using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcCommandeRecherche : UserControl
    {
        private CommandeService _commandeservice = new CommandeService();

        public UcCommandeRecherche()
        {
            InitializeComponent();
        }

        private void Recherche(bool toInclue)
        {
            try
            {
                var commande = new Commande()
                                       {
                                           DateCommande = (dateTimePicker.Value == DateTime.MinValue) ? (DateTime?)null : dateTimePicker.Value,
                                           IsLivree = toInclue,
                                           NomPrenomClient = txtClient.Text.Trim()
                                       };

                List<Commande> commandes = _commandeservice.Recherche(commande);
                dataGridView1.DataSource = commandes;
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Recherche commande");
            }
        }

        public void Reset()
        {
            dateTimePicker.Value = DateTime.MinValue;
            txtClient.Text = string.Empty;
            chkIsLivered.Checked = false;
            dataGridView1.DataSource = new List<Commande>();
        }

        public void FindAll()
        {
            List<Commande> commandes = _commandeservice.ListAll();
            dataGridView1.DataSource = commandes;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Recherche(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            FindAll();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Recherche(false);
        }
    }
}
