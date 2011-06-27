using System;
using System.Collections.Generic;
using System.Data;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class FamilleData
    {
        public Famille Create(Famille famille)
        {
            using (var helper = new SqliteHelper("INSERT INTO Famille (Libelle) VALUES(@libelle); Select last_insert_rowid();"))
            {
                helper.AddInParameter("libelle", DbType.String, famille.Libelle);

                famille.Id = helper.ExecuteCreateQuery();
            }

            return famille;
        }

        public bool Update(Famille famille)
        {
            bool isUpdated;

            using (var helper = new SqliteHelper("UPDATE famille set Libelle = @Libelle WHERE Id = @Id"))
            {
                helper.AddInParameter("Libelle", DbType.String, famille.Libelle);

                helper.AddInParameter("Id", DbType.Int32, famille.Id);

                isUpdated = helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public bool Delete(Famille famille)
        {
            bool isDeleted;
            using (var helper = new SqliteHelper("DELETE FROM famille WHERE Id = @Id"))
            {
                helper.AddInParameter("Id", DbType.Int32, famille.Id);

                isDeleted = helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public List<Famille> ListAll()
        {
            var familles = new List<Famille>();

            using (var helper = new SqliteHelper("SELECT Id, Libelle FROM Famille ORDER BY Id"))
            {
                using (var reader = helper.ExecuteQuery())
                {

                    while (reader.Read())
                    {
                        familles.Add(new Famille
                        {
                            Id = reader.GetIntFromReader("Id"),
                            Libelle = reader.GetStringFromReader("Libelle")
                        });
                    }
                }
            }

            return familles;
        }

        public bool IsCanDelete(Famille famille)
        {
            var isCanDelete = true;
            using (var helper = new SqliteHelper("SELECT Id FROM Produit Where FamilleId = @Id"))
            {
                helper.AddInParameter("Id", DbType.Int32, famille.Id);
                using (var reader = helper.ExecuteQuery())
                {
                    if (reader.Read())
                        isCanDelete = false;
                }
            }
            return isCanDelete;
        }
    }
}