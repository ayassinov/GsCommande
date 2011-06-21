using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormCommandeDetail : Form
    {
        LigneCommandeService _ligneCommandeService = new LigneCommandeService();
        CommandeService _commandeService = new CommandeService();

        public Commande SelectedCommande { get; set; }

        public delegate void CloseFormHandler();
        public event CloseFormHandler CloseCommandeDetailForm;

        private void OnCloseForm()
        {
            if (CloseCommandeDetailForm != null)
                CloseCommandeDetailForm();
        }

        public FormCommandeDetail()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            try
            {
                if (SelectedCommande != null)
                {
                    this.Text = string.Format("GsCommande - Modification de la commande N° {0}", SelectedCommande.Id);
                    toolStripStatusLabel1.Text = this.Text;

                    if (SelectedCommande.IsLivree)
                    {
                        btnLivrer.Enabled = false;
                        btnSave.Enabled = false;
                        btnSupprimer.Enabled = false;
                        ucCommandeAjouter1.Visible = false;
                        label1.Text =
                            string.Format("Cette Commande a été livrée le {0}. \n \t Il n'est pas possible de la modifier.", SelectedCommande.DateLivraison.Value.ToShortDateString());
                    }
                    else
                    {
                        SelectedCommande.LigneCommande = _ligneCommandeService.ListByCommande(SelectedCommande);
                        ucCommandeAjouter1.LigneCommandes = SelectedCommande.LigneCommande;
                        ucCommandeAjouter1.CommandeForUpdate = SelectedCommande;
                        ucCommandeAjouter1.LoadForUpdate();
                    }
                }
                else
                {
                    MessageBox.Show(@"Vous devez séléctionner une commande pour la modifier",
                            @"Modification de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Modification de la commande");
            }
        }

        public void UpdateModification()
        {
            //todo !!!
        }

        private void btnQuitter_Click(object sender, System.EventArgs e)
        {
            OnCloseForm();
        }

        private void btnLivrer_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MessageBox.Show(@"Vous êtes sur de vouloir livrer cette commande ?",
                    @"Modification de la commande",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                _commandeService.Deliver(SelectedCommande);

                MessageBox.Show(@"La commande a été livrée avec succès.", @"Modification de la commande",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnCloseForm();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Modification de la commande");
            }
        }

        private void btnAnnulerLivraison_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(@"Vous êtes sur de vouloir annuler la livraison de cette commande ?",
                    @"Modification de la commande",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                _commandeService.CancelDelivery(SelectedCommande);

                MessageBox.Show(@"L'annulation de la livraison de la commande a été effectuée avec succès.", @"Modification de la commande",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnCloseForm();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Modification de la commande");
            }
        }

        private void btnSupprimer_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            // sauvegarder toutes les nouvelles modifications :s
        }

        private void FormCommandeDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnCloseForm();
        }


    }
}
