using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
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

        private void Recherche()
        {
            var commande = new Commande()
                               {
                                   DateCommande = dateTimePicker.Value,
                                   IsLivree = chkIsLivered.Checked,
                                   NomPrenomClient = txtClient.Text
                               };

            List<Commande> commandes = _commandeservice.Recherche(commande);
            dataGridView1.DataSource = commandes;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
           Recherche();
        }
    }
}
