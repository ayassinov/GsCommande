using System;

namespace Com.GlagSoft.GsCommande.Objects
{
    public class DataBaseFile
    {
        public string FileName { get; set; }
        public DateTime CreationDate { get; set; }
        public string FullPathName { get; set; }
        public BackupRaison BackupRaison { get; set; }

        public string BackupRaisonString
        {
            get
            {
                switch (BackupRaison)
                {
                    case BackupRaison.ClearAllDataAction:
                        return "Suppression de toutes les données";
                    case BackupRaison.ClearCommandeAction:
                        return "Suppression de toutes les commandes";
                    case BackupRaison.UserAction:
                        return "Effectué par l'utilisateur";
                    default:
                        return "Non connue";
                }
            }
        }

        public DataBaseFile()
        {
            BackupRaison = BackupRaison.UserAction;
        }
    }

    public enum BackupRaison
    {
        ClearAllDataAction = 0,
        ClearCommandeAction = 1,
        UserAction = 2,
        Undifined = 3
    }
}