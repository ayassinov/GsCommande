using System;
using System.IO;
using System.Windows.Forms;

namespace Com.GlagSoft.GsCommande.Outils
{
    public class GestionParametre
    {
        public static readonly GestionParametre Instance = new GestionParametre();

        private const string DbFileName = "gscommande.db";
        private const string BackupFolderName = "DbBackup";

        private GestionParametre() { }

        public string DataBaseFilePath { get; set; }
        public string RestoreFolder { get; set; }

        public string DataBaseCreationDate
        {
            get
            {
                var dateTime = File.GetCreationTime(DataBaseFilePath);
                if (dateTime != DateTime.MinValue)
                    return dateTime.ToLongDateString();
                return string.Empty;
            }
        }

        public string ConnexionString
        {
            get
            {
                return string.Format("Data Source=" + @"{0}", DataBaseFilePath);
            }
        }

        public string LoadBackupDefaultValue()
        {
            var appPath = Application.StartupPath;
            appPath = Path.Combine(appPath, BackupFolderName);
            if (!Directory.Exists(appPath))
                Directory.CreateDirectory(appPath);
            RestoreFolder = appPath;
            return appPath;
        }

        public string LoadDbFileDefaultValue()
        {
            var appPath = Application.StartupPath;
            appPath = Path.Combine(appPath, DbFileName);
            DataBaseFilePath = appPath;
            return appPath;
        }
    }
}