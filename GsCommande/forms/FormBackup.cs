using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormBackup : Form
    {
        private MaintenanceService _maintenanceService = new MaintenanceService();

        public FormBackup()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            try
            {
                string folder = GestionParametre.Instance.RestoreFolder;
                lblBackupPath.Text = folder;

                if (!Directory.Exists(folder))
                {
                    MessageBox.Show(@"Dossier de sauvegarde introuvable", @"Sauvegarde/Restauration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRestaurer.Enabled = false;
                    btnRestaurer.Enabled = false;
                    btnDelete.Enabled = false;
                    return;
                }


                var files = new List<DataBaseFile>();

                foreach (var file in Directory.EnumerateFiles(folder))
                {
                    var filepath = Path.Combine(folder, file);
                    var extension = Path.GetExtension(filepath);
                    if (!string.IsNullOrEmpty(extension) && extension.CompareTo(".db") == 0)
                    {
                        var dateTime = File.GetCreationTime(filepath);
                        var dbfile = new DataBaseFile() { CreationDate = dateTime, FileName = Path.GetFileName(file), FullPathName = file };
                        int nbrBackupRaison;
                        if (!Int32.TryParse(dbfile.FileName[0].ToString(), out nbrBackupRaison))
                            nbrBackupRaison = 3;
                        dbfile.BackupRaison = (BackupRaison)nbrBackupRaison;
                        files.Add(dbfile);
                    }
                }

                files = files.OrderBy(f => f.CreationDate).Reverse().ToList();

                dgvdbFiles.DataSource = files;

                btnRestaurer.Enabled = dgvdbFiles.RowCount > 0;
                btnDelete.Enabled = dgvdbFiles.RowCount > 0;

            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Sauvegarde/Restauration");
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRestaurer_Click(object sender, EventArgs e)
        {
            if (dgvdbFiles.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedfile = dgvdbFiles.SelectedRows[0].DataBoundItem as DataBaseFile;

                    if (selectedfile == null)
                        throw new Exception("Fichier non séléctionné introuvable");

                    if (MessageBox.Show(@"Êtes-vous sûr de vouloir restaurer la sauvegarde " + selectedfile.FileName + @" les données récentes seront perdu !",
                                        @"Sauvegarde/Restauration", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    _maintenanceService.RestaurerBase(selectedfile);

                    Close();
                }
                catch (Exception exception)
                {
                    GestionException.TraiterException(exception, "Sauvegarde/Restauration");
                }
            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                _maintenanceService.BackupDataBase(BackupRaison.UserAction);

                LoadAll();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Sauvegarde/Restauration");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(@"Êtes-vous sûr de vouloir supprimer la sauvegarde sélectionné ?",
                @"Sauvegarde/Restauration", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (dgvdbFiles.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedfile = dgvdbFiles.SelectedRows[0].DataBoundItem as DataBaseFile;

                    if (selectedfile == null)
                        throw new Exception("Fichier non séléctionné introuvable");


                    File.Delete(selectedfile.FullPathName);

                    LoadAll();
                }
                catch (Exception exception)
                {
                    GestionException.TraiterException(exception, "Sauvegarde/Restauration");
                }
            }
        }
    }
}
