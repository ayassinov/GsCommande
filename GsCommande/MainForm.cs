using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;
using GsUpdater.Framework;

namespace Com.GlagSoft.GsCommande
{
    public partial class MainForm : Form
    {
        private const string UpdateUrl = "http://cloud.github.com/downloads/ayassinov/GsCommande/UpdateFeed.xml";

        MaintenanceService _maintenanceService = new MaintenanceService();

        FormProduitGestion _formProduitGestion = new FormProduitGestion();
        FormFamilleGestion _formFamilleGestion = new FormFamilleGestion();
        FormCommandeDetail _fomCommandeDetail = new FormCommandeDetail();

        bool _formProduitGestionClosed = false;

        [DefaultValue(false)]
        public bool IsNeedToClose { get; set; }

        public MainForm(bool isDataBaseValide)
        {
            InitializeComponent();

            if (!isDataBaseValide)
            {
                var form = new FormConfiguration();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowInTaskbar = true;
                form.TopMost = true;
                form.FirstStart = true;
                form.CloseConfigurationForm += CloseConfigurationForm;
                form.LoadAll();
                form.ShowDialog();

                AfficherAjoutCommande();
            }
            else
            {
                AfficherAjoutCommande();
            }

            toolStripStatusLabel1.Text = string.Format("Base de données crée le : {0}", GestionParametre.Instance.DataBaseCreationDate);
            this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }

        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }

        private void OpenGestionProduit()
        {
            _formProduitGestionClosed = false;
            _formProduitGestion = new FormProduitGestion();
            _formProduitGestion.CloseGestionProduitForm += CloseGestionProduitForm;
            _formProduitGestion.LoadAll();
            if (!_formProduitGestionClosed)
                _formProduitGestion.ShowDialog();
        }

        private void OpenGestionFamille()
        {
            _formFamilleGestion = new FormFamilleGestion();
            _formFamilleGestion.CloseGestionFamilleForm += CloseGestionFamilleForm;
            _formFamilleGestion.LoadAll();
            _formFamilleGestion.ShowDialog();
        }

        private void OpenCommandeDetail()
        {
            _fomCommandeDetail = new FormCommandeDetail();
            _fomCommandeDetail.CloseCommandeDetailForm += CloseCommandeDetailForm;
            _fomCommandeDetail.SelectedCommande = ucCommandeRecherche1.SelectedCommande;
            _fomCommandeDetail.LoadAll();
            _fomCommandeDetail.ShowDialog();
        }

        private void btnGestionProduit_Click(object sender, EventArgs e)
        {
            OpenGestionProduit();
        }

        private void btnGestionFamille_Click(object sender, EventArgs e)
        {
            OpenGestionFamille();
        }

        private void CloseConfigurationForm(bool isValid)
        {
            if (isValid)//les paramètres sont valide, on ne quitte pas !
            {
                IsNeedToClose = false;
            }
            else
            {
                IsNeedToClose = true;
                Close();
            }
        }

        private void CloseGestionProduitForm()
        {
            _formProduitGestionClosed = true;
            _formProduitGestion.Close();
            _formProduitGestion.Dispose();
        }

        private void CloseGestionFamilleForm()
        {
            _formFamilleGestion.Close();
            _formFamilleGestion.Dispose();
        }

        private void CloseCommandeDetailForm()
        {
            _fomCommandeDetail.Close();
            _fomCommandeDetail.Dispose();
            ucCommandeRecherche1.Recherche(); // reload the last search result.
        }

        private void AfficherAjoutCommande()
        {
            ucCommandeAjouter1.Reset();

            ucCommandeRecherche1.Visible = false;
            ucCommandeAjouter1.Visible = true;
            ucListeProduit1.Visible = false;

            mnuAddCommand.Enabled = false;
            mnuChercherCommande.Enabled = true;
            mnuListerProduit.Enabled = true;

            btnSauvegarder.Visible = true;
            btnDetail.Visible = false;
            btnImprimer.Visible = false;

            btnChercherCommande.Enabled = true;
            btnAjouterCommande.Enabled = false;
            btnListeProduits.Enabled = true;
        }

        private void AfficherRechercheCommmande()
        {
            ucCommandeRecherche1.ChangeSelectedCommande += ucCommandeRecherche1_ChangeSelectedCommande;
            ucCommandeRecherche1.Reset();

            ucCommandeRecherche1.Visible = true;
            ucCommandeAjouter1.Visible = false;
            ucListeProduit1.Visible = false;

            mnuAddCommand.Enabled = true;
            mnuChercherCommande.Enabled = false;
            mnuListerProduit.Enabled = true;

            btnSauvegarder.Visible = false;
            btnDetail.Visible = true;
            btnImprimer.Visible = false;

            btnChercherCommande.Enabled = false;
            btnAjouterCommande.Enabled = true;
            btnListeProduits.Enabled = true;
        }

        private void AfficherListeCommande()
        {
            ucListeProduit1.LoadAll();
            btnImprimer.Enabled = ucListeProduit1.IsShowPrintButton;

            ucListeProduit1.Visible = true;
            ucCommandeAjouter1.Visible = false;
            ucCommandeRecherche1.Visible = false;

            mnuAddCommand.Enabled = true;
            mnuChercherCommande.Enabled = true;
            mnuListerProduit.Enabled = false;

            btnSauvegarder.Visible = false;
            btnDetail.Visible = false;
            btnImprimer.Visible = true;

            btnChercherCommande.Enabled = true;
            btnAjouterCommande.Enabled = true;
            btnListeProduits.Enabled = false;
        }

        private void ucCommandeRecherche1_ChangeSelectedCommande()
        {
            btnDetail.Enabled = ucCommandeRecherche1.SelectedCommande != null;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F2))
            {
                if (btnAjouterCommande.Enabled)
                    AfficherAjoutCommande();
                return true;
            }

            if (keyData == (Keys.F3))
            {
                if (btnChercherCommande.Enabled)
                    AfficherRechercheCommmande();
                return true;
            }

            if (keyData == (Keys.F4))
            {
                if (btnListeProduits.Enabled)
                    AfficherListeCommande();
                return true;
            }

            if (keyData == (Keys.F5))
            {
                if (!btnAjouterCommande.Enabled)
                    ucCommandeAjouter1.AddLigneCommande();
                return true;
            }

            if (keyData == (Keys.F6))
            {
                if (!btnAjouterCommande.Enabled)
                    ucCommandeAjouter1.UpdateLigneCommande();
                return true;
            }

            if (keyData == (Keys.F7))
            {
                if (!btnAjouterCommande.Enabled)
                    ucCommandeAjouter1.DeleteLigneCommande();
                return true;
            }

            if (keyData == (Keys.F11))
            {
                OpenGestionFamille();
                return true;
            }

            if (keyData == (Keys.F12))
            {
                OpenGestionProduit();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            AfficherAjoutCommande();
        }

        private void btnChercherCommande_Click(object sender, EventArgs e)
        {
            AfficherRechercheCommmande();
        }

        private void btnListeProduits_Click(object sender, EventArgs e)
        {
            AfficherListeCommande();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            ucCommandeAjouter1.SaveCommande();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            OpenCommandeDetail();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            ucListeProduit1.Imprimer();
        }

        private void mnuReset_Click(object sender, EventArgs e)
        {
            var form = new FormConfiguration();
            form.FirstStart = false;
            form.LoadAll();
            form.ShowDialog();

            AfficherAjoutCommande();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuResetCommande_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Êtes-vous sûr de vouloir supprimer définitivement toutes les commandes de la base de données ?",
                @"Maintenance",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                _maintenanceService.BackupDataBase(BackupRaison.ClearCommandeAction);
                _maintenanceService.CleanDataBase();
                AfficherAjoutCommande();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Maintenance");
            }
        }

        private void mnuResetTotal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Êtes-vous sûr de vouloir supprimer définitivement toutes les données ?",
                @"Maintenance",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                _maintenanceService.BackupDataBase(BackupRaison.ClearAllDataAction);
                _maintenanceService.CleanAll();
                AfficherAjoutCommande();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Maintenance");
            }
        }

        private void mnuBachup_Click(object sender, EventArgs e)
        {
            var formBackup = new FormBackup();
            formBackup.LoadAll();
            formBackup.ShowDialog();
            toolStripStatusLabel1.Text = string.Format("Base de données crée le : {0}", GestionParametre.Instance.DataBaseCreationDate);
            AfficherAjoutCommande();
        }

        private void mnuAddCommand_Click(object sender, EventArgs e)
        {
            if (mnuAddCommand.Enabled)
                AfficherAjoutCommande();
        }

        private void mnuChercherCommande_Click(object sender, EventArgs e)
        {
            if (mnuChercherCommande.Enabled)
                AfficherRechercheCommmande();
        }

        private void mnuListerProduit_Click(object sender, EventArgs e)
        {
            if (mnuListerProduit.Enabled)
                AfficherListeCommande();
        }

        private void mnugerLesfamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenGestionFamille();
        }

        private void mnuGestionProduit_Click(object sender, EventArgs e)
        {
            OpenGestionProduit();
        }

        private void mnuModeleDuRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                report1.Load("listeproduit.frx");
                report1.Design();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "GsCommande");
            }

        }

        private void mnuAPropos_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void mnuCheckUpdate_Click(object sender, EventArgs ee)
        {
            try
            {
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                var isupdate = UpdateManager.Instance.CheckForUpdate(UpdateUrl, version);

                if (isupdate)
                {
                    var formUpdate = new FormUpdate();
                    formUpdate.Init(UpdateManager.Instance.CurrentUpdate);
                    formUpdate.ShowDialog();
                }
                else
                {
                    MessageBox.Show(@"Vous disposez de la dernière version.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Une erreur s'est produite lors de la vérification des mises à jours."
                 + Environment.NewLine
                 + @"Detail de l'erreur :"
                 + Environment.NewLine
                 + e.Message);
            }
        }

        private void fichierLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                var pathToLog = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), "Logs");

                pathToLog = Path.Combine(pathToLog, "gscommande.log");

                if (File.Exists(pathToLog))
                    Process.Start("notepad.exe", pathToLog);
                else
                    MessageBox.Show(@"Le Fichier log n'existe pas");
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Ouverture du fichier log");
            }
        }
    }
}
