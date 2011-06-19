using System.Collections.Generic;
using System.Data;
using System.Text;
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
                helper.AddInParameter("DateCommande", DbType.Date, commande.DateCommande.Value.Date);
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

        public List<Commande> Recherche(Commande commande)
        {

            var sb = new StringBuilder("SELECT Id, DateCommande, NomPrenomClient, IsLivree FROM Commande WHERE 1 = 1");

            if (commande.DateCommande.HasValue)
                sb.Append(" AND DateCommande = @DateCommande");

            if (!string.IsNullOrEmpty(commande.NomPrenomClient.Trim()))
                sb.Append(" AND NomPrenomClient = @NomPrenomClient");

            if (commande.Id > 0)
                sb.Append(" AND Id = @Id");

            sb.Append(" AND IsLivree = @IsLivree");

            var commandes = new List<Commande>();

            using (var helper = new SqliteHelper(sb.ToString()))
            {
                if (commande.DateCommande.HasValue)
                    helper.AddInParameter("DateCommande", DbType.DateTime, commande.DateCommande.Value.Date);

                if (!string.IsNullOrEmpty(commande.NomPrenomClient.Trim()))
                    helper.AddInParameter("NomPrenomClient", DbType.String, commande.NomPrenomClient);

                if (commande.Id > 0)
                    helper.AddInParameter("Id", DbType.Int32, commande.Id);

                helper.AddInParameter("IsLivree", DbType.Boolean, commande.IsLivree);


                using (var reader = helper.ExecuteQuery())
                {
                    while (reader.Read())
                    {
                        commandes.Add(new Commande()
                                          {
                                              Id = reader.GetIntFromReader("Id"),
                                              DateCommande = reader.GetDateTimeFromReader("DateCommande"),
                                              NomPrenomClient = reader.GetStringFromReader("NomPrenomClient"),
                                              IsLivree = reader.GetBoolFromReader("IsLivree"),

                                          });
                    }
                }
            }

            return commandes;
        }
    }
}