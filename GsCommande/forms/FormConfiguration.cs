using System;
using System.IO;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormConfiguration : Form
    {
        readonly MaintenanceService _maintenanceService = new MaintenanceService();

        public delegate void CloseFormHandler();
        public event CloseFormHandler CloseConfigurationForm;

        private void OnCloseForm()
        {
            if (CloseConfigurationForm != null)
                CloseConfigurationForm();
        }

        public FormConfiguration()
        {
            InitializeComponent();
        }

        public bool FirstStart { get; set; }

        public void LoadAll()
        {

            if (FirstStart)
            {
                btnQuitter.Visible = true;
                btnAnnuler.Visible = false;
            }
            else
            {
                btnQuitter.Visible = false;
                btnAnnuler.Visible = true;
            }

            try
            {
                txtDbFilePath.Text = GestionParametre.Instance.DataBaseFilePath;
                txtRestoreFolder.Text = GestionParametre.Instance.RestoreFolder;
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des paramètres");
            }
        }

        private bool IsDataBaseValid()
        {
            GestionParametre.Instance.DataBaseFilePath = txtDbFilePath.Text;
            return _maintenanceService.IsDataBaseValid();
        }

        private bool IsBackupFolderValid()
        {
            var isValid = false;

            try
            {
                isValid = Directory.Exists(txtRestoreFolder.Text);
            }
            catch (Exception exception)
            {
                GestionException.LogOnly(exception);
            }

            return isValid;
        }

        private void ValidateAndClose()
        {
            //for testing Purpose
            txtDbFilePath.Text = Properties.Settings.Default.DataBaseFilePath;
            txtRestoreFolder.Text = Properties.Settings.Default.BackUpPath;

            var isCanClose = false;

            if (IsDataBaseValid())
                isCanClose = true;
            else
                MessageBox.Show(@"La connexion à la base de données a échoué, veuillez sélectionner un fichier valide.",
                                @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (IsBackupFolderValid())
                isCanClose = true;
            else
                MessageBox.Show(@"Le dossier que vous avez choisie pour la sauvegarde et la restauration n'est pas valide.",
                              @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (isCanClose)
                Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDbFilePath.Text.Trim()))
            {
                MessageBox.Show(@"Vous devez spécifier un fichier de base de données.",
                     @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtRestoreFolder.Text))
            {
                MessageBox.Show(@"Vous devez spécifier un dossier pour la sauvegarde/restauration de la base de données",
                    @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(txtDbFilePath.Text))
            {
                MessageBox.Show(@"Le fichier que vous avez choisie est introuvable",
                    @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsBackupFolderValid())
            {
                MessageBox.Show(
                    @"Le dossier que vous avez choisie pour la sauvegarde et la restauration n'est pas valide.",
                    @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            try
            {
                if (!IsDataBaseValid())
                {
                    MessageBox.Show(
                        @"La connexion à la base de données a échoué, veuillez sélectionner un fichier valide.",
                        @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                Properties.Settings.Default.DataBaseFilePath = txtDbFilePath.Text;
                Properties.Settings.Default.BackUpPath = txtRestoreFolder.Text;
                Properties.Settings.Default.Save();

                GestionParametre.Instance.DataBaseFilePath = txtDbFilePath.Text;
                GestionParametre.Instance.RestoreFolder = txtRestoreFolder.Text;

                //sauvegarde effectué on peut fermer !!!
                this.Close();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des paramètres");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Exit Application.
            Close();
            OnCloseForm();
        }

        private void btnOuvrirFichierBase_Click(object sender, EventArgs e)
        {
            openFileDialogdb.InitialDirectory = Application.StartupPath;

            if (openFileDialogdb.ShowDialog() == DialogResult.OK)
            {
                txtDbFilePath.Text = openFileDialogdb.FileName;
            }
        }

        private void btnOuvrirDossier_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Application.StartupPath;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtRestoreFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ValidateAndClose();
        }
    }
}
