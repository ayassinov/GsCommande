using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Outils;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, System.EventArgs e)
        {
            this.Close();
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

            try
            {
                //todo valider information.

                Properties.GsCommande.Default.DataBaseFilePath = txtDbFilePath.Text;
                Properties.GsCommande.Default.BackUpPath = txtRestoreFolder.Text;
                Properties.GsCommande.Default.Save();

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
                txtDbFilePath.Text = openFileDialogdb.FileName;
            }

            if (openFileDialogdb.FileName == string.Empty)
            {

            }
        }

        private void btnOuvrirDossier_Click(object sender, EventArgs e)
        {
            
        }
    }
}
