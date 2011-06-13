using System;
using System.Data;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class CommandeData
    {
        public Commande Create(Commande commande)
        {
            using (var helper = new SqliteHelper("INSERT INTO Commande (DateCommande,NomPrenomClient,IsLivree) "
                                            + " VALUES(@DateCommande, @NomPrenomClient, @IsLivree); Select last_insert_rowid();"))
            {
                helper.AddInParameter("DateCommande", DbType.Date, commande.DateCommande.Date);
                helper.AddInParameter("NomPrenomClient", DbType.String, commande.NomPrenomClient);
                helper.AddInParameter("IsLivree", DbType.Boolean, false);

                commande.Id = helper.ExecuteCreateQuery();
            }

            return commande;
        }

        public bool Delete(Commande commande)
        {
            bool isDeleted;
            using (var helper = new SqliteHelper("DELETE FROM Commande WHERE Id = @Id"))
            {
                helper.AddInParameter("Id", DbType.Int32, commande.Id);

                isDeleted = helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public bool Update(Commande commande)
        {
            bool isUpdated;

            using (var helper = new SqliteHelper("UPDATE Commande set DateCommande = @DateCommande, NomPrenomClient = @NomPrenomClient, " +
                                                " IsLivree = @IsLivree WHERE Id = @Id"))
            {
                helper.AddInParameter("DateCommande", DbType.DateTime, commande.DateCommande);
                helper.AddInParameter("NomPrenomClient", DbType.String, commande.NomPrenomClient);
                helper.AddInParameter("IsLivree", DbType.Int32, commande.IsLivree);

                isUpdated = helper.ExecuteNonQuery();
            }

            return isUpdated;
        }
    }
}