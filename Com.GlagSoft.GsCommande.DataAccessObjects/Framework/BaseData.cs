namespace Com.GlagSoft.GsCommande.DataAccessObjects.Framework
{
    public class BaseData
    {
        private SqliteHelper _helper;

        public SqliteHelper Helper
        {
            get { return _helper ?? (_helper = SqliteHelper.Helper); }
            set { _helper = value; }
        }

        public void BeginTransaction()
        {
            Helper.BeginTransaction();
        }

        public void Commit()
        {
            Helper.Commit();
        }

        public void RollBack()
        {
            Helper.RollBack();
        }
    }
}