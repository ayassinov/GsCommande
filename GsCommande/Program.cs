using System;
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
            Application.Run(new MainForm() { IsDataBaseValide = IsDataBaseValid() });
        }

        private static bool IsDataBaseValid()
        {
            try
            {
                GestionParametre.Instance.DataBaseFilePath = Properties.GsCommande.Default.DataBaseFilePath;
                GestionParametre.Instance.RestoreFolder = Properties.GsCommande.Default.BackUpPath;
            }
            catch (Exception exception)
            {
                GestionException.LogOnly(exception);
                return false;
            }

            var maintenanceService = new MaintenanceService();
            return maintenanceService.IsDataBaseValid();
        }
    }
}
