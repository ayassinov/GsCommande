using System;
using System.Data;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class LigneCommandeData
    {
        public bool Create(LigneCommande ligneCommande)
        {
            var isCreated = false;
            using (var helper = new SqliteHelper("INSERT INTO LigneCommande (CommandeId, ProduitId, QteKilo, QteDemiKilo) "
                                            + " VALUES(@CommandeId, @ProduitId, @QteKilo, @QteDemiKilo)"))
            {
                helper.AddInParameter("CommandeId", DbType.Int32, ligneCommande.Commande.Id);
                helper.AddInParameter("ProduitId", DbType.Int32, ligneCommande.Produit.Id);
                helper.AddInParameter("QteKilo", DbType.Int32, ligneCommande.Qtekilo);
                helper.AddInParameter("QteDemiKilo", DbType.Int32, ligneCommande.QteDemiKilo);

                isCreated = helper.ExecuteNonQuery();
            }

            return isCreated;
        }

        public bool Delete(LigneCommande ligneCommande)
        {
            bool isDeleted;
            using (var helper = new SqliteHelper("DELETE FROM LigneCommande WHERE CommandeId = @CommandeId AND ProduitId = @ProduitId"))
            {
                helper.AddInParameter("CommandeId", DbType.Int32, ligneCommande.Commande.Id);
                helper.AddInParameter("ProduitId", DbType.Int32, ligneCommande.Produit.Id);

                isDeleted = helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public bool Delete(Commande commande)
        {
            bool isDeleted;
            using (var helper = new SqliteHelper("DELETE FROM LigneCommande WHERE CommandeId = @CommandeId "))
            {
                helper.AddInParameter("CommandeId", DbType.Int32, commande.Id);

                isDeleted = helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public bool Update(LigneCommande ligneCommande)
        {
            bool isUpdated;

            using (var helper = new SqliteHelper("UPDATE LigneCommande set QteKilo = @QteKilo, QteDemiKilo = @QteDemiKilo "
                                                + " WHERE CommandeId = @CommandeId AND ProduitId = @ProduitId"))
            {
                helper.AddInParameter("QteKilo", DbType.Int32, ligneCommande.Qtekilo);
                helper.AddInParameter("QteDemiKilo", DbType.Int32, ligneCommande.QteDemiKilo);
                helper.AddInParameter("CommandeId", DbType.Int32, ligneCommande.Commande.Id);
                helper.AddInParameter("ProduitId", DbType.Int32, ligneCommande.Produit.Id);

                isUpdated = helper.ExecuteNonQuery();
            }

            return isUpdated;
        }
    }
}