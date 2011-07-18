using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class CommandeData : BaseData
    {
        public Commande CreateTransaction(Commande commande)
        {
            using (Helper)
            {

                Helper.PrepareCommand("INSERT INTO Commande (DateCommande,NomPrenomClient,IsLivree,DateLivraison) "
                    + " VALUES(@DateCommande, @NomPrenomClient, @IsLivree, @DateLivraison); Select last_insert_rowid();");

                Helper.AddInParameter("DateCommande", DbType.Date, commande.DateCommande.Value.Date);
                Helper.AddInParameter("NomPrenomClient", DbType.String, commande.NomPrenomClient);
                Helper.AddInParameter("IsLivree", DbType.Boolean, false);
                Helper.AddInParameter("DateLivraison", DbType.Date, DBNull.Value);

                commande.Id = Helper.ExecuteCreateQuery();

            }
            return commande;
        }

        public bool DeleteTransaction(Commande commande)
        {
            bool isDeleted;

            using (Helper)
            {
                Helper.PrepareCommand("DELETE FROM Commande WHERE Id = @Id");
                Helper.AddInParameter("Id", DbType.Int32, commande.Id);

                isDeleted = Helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public bool UpdateTransaction(Commande commande)
        {
            bool isUpdated;

            using (Helper)
            {
                Helper.PrepareCommand("UPDATE Commande set DateCommande = @DateCommande, NomPrenomClient = @NomPrenomClient WHERE Id = @Id");
                Helper.AddInParameter("Id", DbType.Int32, commande.Id);
                Helper.AddInParameter("DateCommande", DbType.DateTime, commande.DateCommande);
                Helper.AddInParameter("NomPrenomClient", DbType.String, commande.NomPrenomClient);

                isUpdated = Helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public SortableBindingList<Commande> Recherche(Commande commande)
        {
            var sb = new StringBuilder("SELECT Id, DateCommande, NomPrenomClient, IsLivree, DateLivraison FROM Commande WHERE 1 = 1");

            if (commande.DateCommande.HasValue)
                sb.Append(" AND DateCommande = @DateCommande");

            if (!string.IsNullOrEmpty(commande.NomPrenomClient.Trim()))
                sb.Append(" AND upper(NomPrenomClient) like upper('%' || @NomPrenomClient || '%') ");

            if (commande.Id > 0)
                sb.Append(" AND Id = @Id");

            if (!commande.IsLivree)
                sb.Append(" AND IsLivree = @IsLivree");

            sb.Append(" ORDER BY Id ");

            var commandes = new SortableBindingList<Commande>();

            using (var helper = new SqliteHelper(sb.ToString()))
            {
                if (commande.DateCommande.HasValue)
                    helper.AddInParameter("DateCommande", DbType.DateTime, commande.DateCommande.Value.Date);

                if (!string.IsNullOrEmpty(commande.NomPrenomClient.Trim()))
                    helper.AddInParameter("NomPrenomClient", DbType.String, commande.NomPrenomClient);

                if (commande.Id > 0)
                    helper.AddInParameter("Id", DbType.Int32, commande.Id);

                if (!commande.IsLivree)
                    helper.AddInParameter("IsLivree", DbType.Boolean, false);


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
                                              DateLivraison = reader.GetDateTimeNullableFromReader("DateLivraison")
                                          });
                    }
                }
            }

            return commandes;
        }

        public bool Deliver(Commande commande)
        {
            bool isUpdated;

            using (var helper = new SqliteHelper("UPDATE Commande set IsLivree = @IsLivree, DateLivraison = @DateLivraison WHERE Id = @Id"))
            {
                helper.AddInParameter("Id", DbType.Int32, commande.Id);
                helper.AddInParameter("IsLivree", DbType.Int32, true);
                helper.AddInParameter("DateLivraison", DbType.Date, DateTime.Now.Date);

                isUpdated = helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public bool CancelDelivery(Commande commande)
        {
            bool isUpdated;

            using (var helper = new SqliteHelper("UPDATE Commande set IsLivree = @IsLivree, DateLivraison = @DateLivraison WHERE Id = @Id"))
            {
                helper.AddInParameter("Id", DbType.Int32, commande.Id);
                helper.AddInParameter("IsLivree", DbType.Int32, false);
                helper.AddInParameter("DateLivraison", DbType.Date, DBNull.Value);

                isUpdated = helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public Commande Get(int id)
        {
            var commande = new Commande() { Id = id };

            using (var helper = new SqliteHelper("SELECT Id, DateCommande, NomPrenomClient, IsLivree, DateLivraison FROM Commande WHERE Id = @Id"))
            {
                helper.AddInParameter("Id", DbType.Int32, id);

                using (var reader = helper.ExecuteQuery())
                {
                    if (reader.Read())
                    {
                        commande.NomPrenomClient = reader.GetStringFromReader("NomPrenomClient");
                        commande.DateCommande = reader.GetDateTimeFromReader("DateCommande");
                        commande.IsLivree = reader.GetBoolFromReader("IsLivree");
                        commande.DateLivraison = reader.GetDateTimeNullableFromReader("DateLivraison");
                    }
                }
            }

            return commande;
        }

        public bool UpdateCommandeSeqTransaction(int seqVal)
        {
            bool isUpdated;

            using (Helper)
            {
                Helper.PrepareCommand("UPDATE sqlite_sequence set seq = @seq WHERE NAME = 'Commande' ");
                Helper.AddInParameter("seq", DbType.Int32, seqVal);
                isUpdated = Helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public bool IsCommandeIdExist(int id)
        {
            bool isExist = false;

            using (var helper = new SqliteHelper("SELECT Id FROM Commande WHERE Id = @ID "))
            {
                helper.AddInParameter("ID", DbType.Int32, id);

                using (var reader = helper.ExecuteQuery())
                {
                    if (reader.Read())
                        isExist = reader.GetBoolFromReader("ID");
                }
            }

            return isExist;
        }

        public int GetNextId()
        {
            int nextId = -1;

            using (var helper = new SqliteHelper("SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = 'Commande' "))
            {
                using (var reader = helper.ExecuteQuery())
                {
                    if (reader.Read())
                        nextId = reader.GetIntFromReader("SEQ");
                }
            }

            if (nextId == -1)
                throw new Exception("le code de la commande retourer par la séquence n'est pas valide !");

            return ++nextId;
        }
    }
}