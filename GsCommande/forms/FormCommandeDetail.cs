using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
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
                            string.Format("Cette Commande a été livrée le {0}. \n \t Il n'est pas possible de la modifier.",
                            SelectedCommande.DateLivraison.Value.ToShortDateString());
                    }
                    else
                    {
                        SelectedCommande = _commandeService.Get(SelectedCommande.Id);
                        var liste = _ligneCommandeService.ListByCommande(SelectedCommande);
                        SelectedCommande.LigneCommande = new List<LigneCommande>(liste);
                        ucCommandeAjouter1.LigneCommandes = new List<LigneCommande>(liste);
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

        private void PrepareLigneCommandeForUpdate()
        {
            //search for modified Or changed list
            LigneCommande ligneCommande = null;
            foreach (var ltoUpdate in SelectedCommande.LigneCommande)
            {
                ligneCommande = ucCommandeAjouter1.LigneCommandes.FirstOrDefault(l => l.Produit.Id == ltoUpdate.Produit.Id);
                if (ligneCommande != null) // existe
                {
                    if (ligneCommande.Qtekilo == ltoUpdate.Qtekilo
                        && ligneCommande.QteDemiKilo == ltoUpdate.QteDemiKilo)
                    {
                        ltoUpdate.StateEnum = State.Unchanged;
                    }
                    else
                    {
                        ltoUpdate.Qtekilo = ligneCommande.Qtekilo;
                        ltoUpdate.QteDemiKilo = ligneCommande.QteDemiKilo;
                        ltoUpdate.StateEnum = State.Updated;
                    }
                }
                else
                {
                    ltoUpdate.StateEnum = State.Deleted;
                }
            }

            //search for added ligne commande.
            var listtosave = new List<LigneCommande>();

            foreach (var lCommande in ucCommandeAjouter1.LigneCommandes)
            {
                if (!SelectedCommande.LigneCommande.Exists(l => l.Produit.Id == lCommande.Produit.Id))
                {
                    lCommande.StateEnum = State.New;
                    listtosave.Add(lCommande);
                }
            }

            SelectedCommande.LigneCommande.AddRange(listtosave);
        }

        private bool ValidateForUpdate()
        {
            bool isChanged = false;

            if (ucCommandeAjouter1.txtClient.Text.CompareTo(SelectedCommande.NomPrenomClient) != 0)
                isChanged = true;

            if (ucCommandeAjouter1.dateTimePicker.Value.Date.CompareTo(SelectedCommande.DateCommande.Value.Date) != 0)
                isChanged = true;

            if (SelectedCommande.LigneCommande.Exists(l => l.StateEnum != State.Unchanged)) // aucun changement dans les ligne de commande.
                isChanged = true;

            return isChanged;
        }

        public void UpdateModification()
        {
            PrepareLigneCommandeForUpdate();
            if (ValidateForUpdate())
            {
                _commandeService.UpdateTransaction(SelectedCommande);
            }
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
            try
            {
                if (MessageBox.Show(@"Vous êtes sur de vouloir supprimer cette commande ? \n Cette action est irréversible!",
                    @"Modification de la commande",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                _commandeService.Delete(SelectedCommande);

                MessageBox.Show(@"La suppression de la commande a été effectuée avec succès.", @"Modification de la commande",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnCloseForm();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Modification de la commande");
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            // sauvegarder toutes les nouvelles modifications :s
            UpdateModification();
        }

        private void FormCommandeDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnCloseForm();
        }


    }
}
