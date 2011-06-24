using System;
using System.IO;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var isDataBaseValide = IsDataBaseValid();
            var isDirectoryValide = IsBackupFolderValide();
            var mainform = new MainForm(isDataBaseValide && isDirectoryValide);
            if (!mainform.IsClosed)
                Application.Run(mainform);
        }

        private static bool IsDataBaseValid()
        {
            try
            {
                GestionParametre.Instance.DataBaseFilePath = Properties.GsCommande.Default.DataBaseFilePath;
            }
            catch (Exception exception)
            {
                GestionException.LogOnly(exception);
                return false;
            }

            var maintenanceService = new MaintenanceService();
            return maintenanceService.IsDataBaseValid();
        }

        private static bool IsBackupFolderValide()
        {
            var isValide = false;

            try
            {
                GestionParametre.Instance.RestoreFolder = Properties.GsCommande.Default.BackUpPath;
                isValide = Directory.Exists(GestionParametre.Instance.RestoreFolder);
            }
            catch (Exception exception)
            {
                GestionException.LogOnly(exception);
            }

            return isValide;
        }
    }
}
