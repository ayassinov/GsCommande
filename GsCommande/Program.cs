using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Properties;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (mutex.WaitOne(TimeSpan.Zero, true))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    LoadDefaultSettings();
                    var isDataBaseValide = IsDataBaseValid();
                    var isDirectoryValide = IsBackupFolderValide();
                    var mainform = new MainForm(isDataBaseValide && isDirectoryValide);
                    if (!mainform.IsNeedToClose) // il faut fermer donc on appelle pas run.
                        Application.Run(mainform);
                    mutex.ReleaseMutex();
                }
                else
                {
                    // send our Win32 message to make the currently running instance
                    // jump on top of all the other windows
                    NativeMethods.PostMessage(
                        (IntPtr)NativeMethods.HWND_BROADCAST,
                        NativeMethods.WM_SHOWME,
                        IntPtr.Zero,
                        IntPtr.Zero);
                }
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "GsCommande");
            }
        }

        private static bool IsDataBaseValid()
        {
            try
            {
                GestionParametre.Instance.DataBaseFilePath = Properties.Settings.Default.DataBaseFilePath;
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
                GestionParametre.Instance.RestoreFolder = Properties.Settings.Default.BackUpPath;
                isValide = Directory.Exists(GestionParametre.Instance.RestoreFolder);
            }
            catch (Exception exception)
            {
                GestionException.LogOnly(exception);
            }

            return isValide;
        }

        private static void LoadDefaultSettings()
        {
            if (string.IsNullOrEmpty(Settings.Default.DataBaseFilePath))
            {
                Settings.Default.DataBaseFilePath = GestionParametre.Instance.LoadDbFileDefaultValue();
                Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Settings.Default.BackUpPath))
            {
                Settings.Default.BackUpPath = GestionParametre.Instance.LoadBackupDefaultValue();
                Settings.Default.Save();
            }
        }
    }
}
