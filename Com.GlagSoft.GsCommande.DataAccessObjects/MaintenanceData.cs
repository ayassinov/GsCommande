using System;
using System.Data;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class MaintenanceData : BaseData
    {
        public void CleanAllData()
        {
            ClearTable("LigneCommande");
            ClearTable("Commande");
            ClearTable("Famille");
            ClearTable("Produit");

            ResetSequence("Commande");
            ResetSequence("Famille");
            ResetSequence("Produit");
        }

        public void CleanDataBase()
        {
            ClearTable("LigneCommande");

            ClearTable("Commande");

            ResetSequence("Commande");
        }


        private int GetRowCount(string tableName)
        {
            var count = 0;

            using (Helper)
            {
                Helper.PrepareCommand("Select count(*) as Total FROM " + tableName);
                using (var reader = Helper.ExecuteQuery())
                {
                    if (reader.Read())
                        count = reader.GetIntFromReader("Total");
                }
            }

            return count;

        }

        private void ClearTable(string tableName)
        {
            var isOk = false;

            using (Helper)
            {
                Helper.PrepareCommand("DELETE FROM " + tableName);
                isOk = Helper.ExecuteNonQuery();
            }

            var count = GetRowCount(tableName);

            if (!isOk && count > 0)
                throw new Exception(string.Format("Erreur lors de la suppression de la table <{0}>", tableName));
        }

        private void ResetSequence(string seqName)
        {
            var isOk = false;

            using (Helper)
            {
                Helper.PrepareCommand("UPDATE sqlite_sequence SET seq = 0 WHERE name = @seqName");
                Helper.AddInParameter("seqName", DbType.String, seqName);

                isOk = Helper.ExecuteNonQuery();
            }

            if (!isOk)
                throw new Exception(string.Format("Erreur lors de la suppression de la séquence <{0}>", seqName));
        }

        public void Vacuum()
        {
            using (var helper = new SqliteHelper("VACUUM"))
            {
                helper.ExecuteNonQuery();
            }
        }

        public bool IsDataBaseValid()
        {
            var isValide = false;
            var helper = new SqliteHelper("SELECT name FROM sqlite_master WHERE name='Commande'");

            using (var reader = helper.ExecuteQuery())
            {
                if (reader.Read())
                    isValide = true;
            }
            helper.Dispose();
            return isValide;
        }
    }
}