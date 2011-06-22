using System.Collections.Generic;
using System.Data;
using System.Text;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class LigneCommandeData : BaseData
    {
        public bool CreateTransaction(LigneCommande ligneCommande)
        {
            var isCreated = false;

            using (Helper)
            {
                Helper.PrepareCommand("INSERT INTO LigneCommande (CommandeId, ProduitId, QteKilo, QteDemiKilo) "
                                                       + " VALUES(@CommandeId, @ProduitId, @QteKilo, @QteDemiKilo)");
                Helper.AddInParameter("CommandeId", DbType.Int32, ligneCommande.Commande.Id);
                Helper.AddInParameter("ProduitId", DbType.Int32, ligneCommande.Produit.Id);
                Helper.AddInParameter("QteKilo", DbType.Int32, ligneCommande.Qtekilo);
                Helper.AddInParameter("QteDemiKilo", DbType.Int32, ligneCommande.QteDemiKilo);

                isCreated = Helper.ExecuteNonQuery();
            }

            return isCreated;
        }

        public bool DeleteTransaction(LigneCommande ligneCommande)
        {
            bool isDeleted = false;

            using (Helper)
            {
                Helper.PrepareCommand("DELETE FROM LigneCommande WHERE CommandeId = @CommandeId AND ProduitId = @ProduitId");
                Helper.AddInParameter("CommandeId", DbType.Int32, ligneCommande.Commande.Id);
                Helper.AddInParameter("ProduitId", DbType.Int32, ligneCommande.Produit.Id);

                isDeleted = Helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public bool DeleteTransaction(Commande commande)
        {
            bool isDeleted = false;

            using (Helper)
            {
                Helper.PrepareCommand("DELETE FROM LigneCommande WHERE CommandeId = @CommandeId ");
                Helper.AddInParameter("CommandeId", DbType.Int32, commande.Id);

                isDeleted = Helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public bool UpdateTransaction(LigneCommande ligneCommande)
        {
            bool isUpdated;

            using (Helper)
            {
                Helper.PrepareCommand("UPDATE LigneCommande set QteKilo = @QteKilo, QteDemiKilo = @QteDemiKilo "
                                    + " WHERE CommandeId = @CommandeId AND ProduitId = @ProduitId");

                Helper.AddInParameter("QteKilo", DbType.Int32, ligneCommande.Qtekilo);
                Helper.AddInParameter("QteDemiKilo", DbType.Int32, ligneCommande.QteDemiKilo);
                Helper.AddInParameter("CommandeId", DbType.Int32, ligneCommande.Commande.Id);
                Helper.AddInParameter("ProduitId", DbType.Int32, ligneCommande.Produit.Id);

                isUpdated = Helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public List<LigneCommande> ListByCommande(Commande selectedCommande)
        {
            var sb = new StringBuilder();
            sb.Append("SELECT p.Id ProduitId, p.Code, p.Libelle LibelleProduit,");
            sb.Append(" f.Id FamilleId ,f.Libelle LibelleFamille,");
            sb.Append(" l.QteKilo, l.QteDemiKilo FROM LigneCommande l, Produit p, Famille f  ");
            sb.Append(" WHERE l.produitId = p.Id AND p.FamilleId = f.Id AND l.CommandeId = @CommandeId");

            var ligneCommandes = new List<LigneCommande>();

            using (var helper = new SqliteHelper(sb.ToString()))
            {
                helper.AddInParameter("CommandeId", DbType.Int32, selectedCommande.Id);
                using (var reader = helper.ExecuteQuery())
                {

                    while (reader.Read())
                    {
                        ligneCommandes.Add(new LigneCommande
                        {
                            Commande = selectedCommande,
                            Qtekilo = reader.GetIntFromReader("QteKilo"),
                            QteDemiKilo = reader.GetIntFromReader("QteDemiKilo"),
                            Produit = new Produit()
                                          {
                                              Id = reader.GetIntFromReader("ProduitId"),
                                              Code = reader.GetIntFromReader("Code"),
                                              Libelle = reader.GetStringFromReader("LibelleProduit"),
                                              Famille = new Famille()
                                                            {
                                                                Id = reader.GetIntFromReader("FamilleId"),
                                                                Libelle = reader.GetStringFromReader("LibelleFamille")
                                                            }
                                          }
                        });
                    }
                }
            }

            return ligneCommandes;
        }
    }
}