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

        public FormConfiguration()
        {
            InitializeComponent();
        }

        private bool IsDataBaseValid(string pathToDataBase)
        {
            try
            {
                GestionParametre.Instance.DataBaseFilePath = pathToDataBase;
                GestionParametre.Instance.RestoreFolder = Properties.GsCommande.Default.BackUpPath;
            }
            catch (Exception exception)
            {
                GestionException.LogOnly(exception);
                return false;
            }

            return _maintenanceService.IsDataBaseValid();
        }

        private void btnQuitter_Click(object sender, System.EventArgs e)
        {
            if (IsDataBaseValid(GestionParametre.Instance.DataBaseFilePath))
                Close();
            else
                MessageBox.Show(@"La connexion à la base de données a échoué, veuillez sélectionner un fichier valide.",
                                @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadAll()
        {
            try
            {
                txtDbFilePath.Text = Properties.GsCommande.Default.DataBaseFilePath;
                txtRestoreFolder.Text = Properties.GsCommande.Default.BackUpPath;
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des paramètres");
            }
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

            try
            {
                if (!IsDataBaseValid(txtDbFilePath.Text.Replace(@"\\", @"\").ToString()))
                {
                    MessageBox.Show(
                        @"La connexion à la base de données a échoué, veuillez sélectionner un fichier valide.",
                        @"Gestion des paramètres", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                Properties.GsCommande.Default.DataBaseFilePath = txtDbFilePath.Text.Replace(@"\\", @"\");
                Properties.GsCommande.Default.BackUpPath = txtRestoreFolder.Text;
                Properties.GsCommande.Default.Save();

                GestionParametre.Instance.DataBaseFilePath = Properties.GsCommande.Default.DataBaseFilePath;
                GestionParametre.Instance.RestoreFolder = Properties.GsCommande.Default.BackUpPath;

                this.Close();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des paramètres");
            }
        }

        private void btnOuvrirFichierBase_Click(object sender, EventArgs e)
        {
            openFileDialogdb.InitialDirectory = Application.StartupPath;
            if (openFileDialogdb.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = Path.GetDirectoryName(openFileDialogdb.FileName);
                txtDbFilePath.Text = openFileDialogdb.FileName;
            }
        }

        private void btnOuvrirDossier_Click(object sender, EventArgs e)
        {

        }
    }
}
