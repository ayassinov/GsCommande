namespace Com.GlagSoft.GsCommande.Outils
{
    public class GestionParametre
    {
        public static readonly GestionParametre Instance = new GestionParametre();

        private GestionParametre() { }

        public string DataBaseFilePath { get; set; }
        public string RestoreFolder { get; set; }

        public delegate void ConnectionStringChangeHandler();
        public event ConnectionStringChangeHandler ConnectionStringChange;

        public string ConnexionString
        {
            get
            {
                var s = string.Format("Data Source=" + @"{0}", DataBaseFilePath);
                CallEvent();
                return s;
            }
        }

        private void CallEvent()
        {
            if (ConnectionStringChange != null)
                ConnectionStringChange();
        }

    }
}