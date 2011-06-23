namespace Com.GlagSoft.GsCommande.DataAccessObjects.Framework
{
    public class BaseData
    {
        protected readonly SqliteHelper Helper = SqliteHelper.Helper;

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