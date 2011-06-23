namespace Com.GlagSoft.GsCommande.Outils
{
    public class GestionParametre
    {
        public static GestionParametre Instance = new GestionParametre();

        private GestionParametre() { }

        public string DataBaseFilePath { get; set; }
        public string RestoreFolder { get; set; }


        private void LoadDefaultParameter()
        {

        }

        public void RefreshParameters()
        {

        }

    }
}