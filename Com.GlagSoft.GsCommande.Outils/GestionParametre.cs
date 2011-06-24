namespace Com.GlagSoft.GsCommande.Outils
{
    public class GestionParametre
    {
        public static GestionParametre Instance = new GestionParametre();

        private GestionParametre() { }

        public string DataBaseFilePath { get; set; }
        public string RestoreFolder { get; set; }
       
        public string ConnexionString
        {
            get
            {
                var s = string.Format("Data Source=" + @"{0}", DataBaseFilePath);
                return s;
            }
        }

       
    }
}