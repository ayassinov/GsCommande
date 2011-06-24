namespace Com.GlagSoft.GsCommande.DataAccessObjects.Framework
{
    public class BaseData
    {
        private static SqliteHelper _helper;

        protected static SqliteHelper Helper
        {
            get { return _helper ?? (_helper = new SqliteHelper()); }
        }

        public static void BeginTransaction()
        {
            Helper.BeginTransaction();
        }

        public static void Commit()
        {
            Helper.Commit();
        }

        public static void RollBack()
        {
            Helper.RollBack();
        }
    }
}