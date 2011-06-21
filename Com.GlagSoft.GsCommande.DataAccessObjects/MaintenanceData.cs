using System.Data;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class MaintenanceData
    {
        public void CleanAllData()
        {
            ClearTable("LigneCommande");
            ClearTable("Commande");
            ClearTable("Famille");
            ClearTable("Produit");
            Vacuum();

            ResetSequence("Commande");
            ResetSequence("Famille");
            ResetSequence("Produit");
        }

        public void CleanDataBase()
        {
            ClearTable("LigneCommande");
            ClearTable("Commande");
            Vacuum();

            ResetSequence("Commande");
        }

        private static void ClearTable(string tableName)
        {
            using (var helper = new SqliteHelper("DELETE FROM " + tableName))
            {
                helper.ExecuteNonQuery();
            }
        }

        private static void ResetSequence(string seqName)
        {
            using (var helper = new SqliteHelper("UPDATE sqlite_sequence SET seq = 0 WHERE name = @seqName"))
            {
                helper.AddInParameter("seqName", DbType.String, seqName);

                helper.ExecuteNonQuery();
            }
        }

        private static void Vacuum()
        {
            using (var helper = new SqliteHelper("VACUUM"))
            {
                helper.ExecuteNonQuery();
            }
        }
    }
}