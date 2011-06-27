using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.DataAccessObjects
{
    public class ProduitData : BaseData
    {
        public List<Produit> GetByFamille(Famille famille)
        {
            var produits = new List<Produit>();
            using (var helper = new SqliteHelper("SELECT Id, Code, Libelle FROM produit WHERE familleId = @id order by code"))
            {
                helper.AddInParameter("id", DbType.Int32, famille.Id);
                using (var reader = helper.ExecuteQuery())
                {
                    while (reader.Read())
                    {
                        produits.Add(
                            new Produit
                            {
                                Id = reader.GetIntFromReader("Id"),
                                Code = reader.GetIntFromReader("Code"),
                                Libelle = reader.GetStringFromReader("Libelle"),
                                Famille = famille
                            }
                            );
                    }
                }
            }
            return produits;
        }

        public List<Produit> ListProduitStock()
        {
            var sb = new StringBuilder();
            sb.Append("SELECT p.Id as IdProduit, p.code, p.Libelle as LibelleProduit,");
            sb.Append(" f.Id as IdFamille, f.Libelle as LibelleFamille ,");
            sb.Append(" sum(l.QteKilo) as TotalKilo , sum(l.QteDemiKilo) as TotalDemiKilo");
            sb.Append(" FROM LigneCommande l, Produit p , Famille f, Commande c");
            sb.Append("  WHERE  l.CommandeId = c.Id AND l.ProduitId = p.Id AND p.FamilleId = f.id AND c.IsLivree = 0");
            sb.Append(" group by p.id order by f.id, p.code ");

            var produits = new List<Produit>();
            using (var helper = new SqliteHelper(sb.ToString()))
            {
                using (var reader = helper.ExecuteQuery())
                {
                    while (reader.Read())
                    {
                        produits.Add(
                            new Produit
                            {
                                Id = reader.GetIntFromReader("IdProduit"),
                                Code = reader.GetIntFromReader("Code"),
                                Libelle = reader.GetStringFromReader("LibelleProduit"),
                                TotalQteKilo = reader.GetIntFromReader("TotalKilo"),
                                TotalQteDemiKilo = reader.GetIntFromReader("TotalDemiKilo"),
                                Famille = new Famille
                                {
                                    Id = reader.GetIntFromReader("IdFamille"),
                                    Libelle = reader.GetStringFromReader("LibelleFamille")
                                }
                            }
                            );
                    }
                }
            }

            return produits;
        }

        public Produit Create(Produit produit)
        {
            using (var helper = new SqliteHelper("INSERT INTO produit (Code, Libelle, familleId) VALUES(@code, @libelle, @familleId); Select last_insert_rowid(); "))
            {
                helper.AddInParameter("code", DbType.Int32, produit.Code);
                helper.AddInParameter("libelle", DbType.String, produit.Libelle);
                helper.AddInParameter("familleId", DbType.Int32, produit.Famille.Id);

                produit.Id = helper.ExecuteCreateQuery();
            }

            return produit;
        }

        public bool Update(Produit produit)
        {
            bool isUpdated;

            using (var helper = new SqliteHelper("UPDATE produit set Libelle = @Libelle, familleId = @familleId, Code = @Code  WHERE Id = @Id"))
            {
                helper.AddInParameter("Libelle", DbType.String, produit.Libelle);
                helper.AddInParameter("Code", DbType.Int32, produit.Code);
                helper.AddInParameter("familleId", DbType.Int32, produit.Famille.Id);
                helper.AddInParameter("Id", DbType.Int32, produit.Id);

                isUpdated = helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public bool DeleteTransaction(Produit produit)
        {
            bool isDeleted;

            using (Helper)
            {
                Helper.PrepareCommand("DELETE FROM produit WHERE Id = @Id");
                Helper.AddInParameter("Id", DbType.Int32, produit.Id);

                isDeleted = Helper.ExecuteNonQuery();
            }

            return isDeleted;
        }

        public bool UpdateCodeTransaction(Produit produit)
        {
            bool isUpdated;

            using (Helper)
            {
                Helper.PrepareCommand("Update produit set code = @code WHERE Id = @Id");

                Helper.AddInParameter("code", DbType.Int32, produit.Code);
                Helper.AddInParameter("Id", DbType.Int32, produit.Id);

                isUpdated = Helper.ExecuteNonQuery();
            }

            return isUpdated;
        }

        public Produit Get(int id)
        {

            var sb = new StringBuilder();
            sb.Append("SELECT p.Code, p.Libelle, f.Id famId, f.Libelle famLibelle");
            sb.Append("FROM produit p , famille f  WHERE p.familleId = f.id  AND p.Id = @id");
            Produit produit = null;
            using (var helper = new SqliteHelper(sb.ToString()))
            {
                helper.AddInParameter("id", DbType.Int32, id);
                using (var reader = helper.ExecuteQuery())
                {
                    if (reader.Read())
                    {
                        produit =
                            new Produit
                            {
                                Id = reader.GetIntFromReader("Id"),
                                Code = reader.GetIntFromReader("Code"),
                                Libelle = reader.GetStringFromReader("Libelle"),
                                Famille = new Famille
                                {
                                    Id = reader.GetIntFromReader("famId"),
                                    Libelle = reader.GetStringFromReader("famLibelle")
                                }
                            };
                    }
                }
            }
            return produit;
        }

        public int GetMaxCodeByFamille(Famille famille)
        {
            var code = 0;
            using (var helper = new SqliteHelper("SELECT max(code) code FROM produit WHERE familleId  = @familleId"))
            {
                helper.AddInParameter("familleId", DbType.Int32, famille.Id);
                using (var reader = helper.ExecuteQuery())
                {
                    if (reader.Read())
                        code = reader.GetIntFromReader("code");
                }
            }
            return code;
        }

        public bool IsCanDelete(Produit produit)
        {
            var isCanDelete = true;
            using (var helper = new SqliteHelper("SELECT ProduitId FROM LigneCommande Where ProduitId = @Id"))
            {
                helper.AddInParameter("Id", DbType.Int32, produit.Id);
                using (var reader = helper.ExecuteQuery())
                {
                    if (reader.Read())
                        isCanDelete = false;
                }
            }
            return isCanDelete;
        }

        public List<Produit> ListToUpdateAfterDelete(int codeProduit)
        {
            var produits = new List<Produit>();
            using (var helper = new SqliteHelper("SELECT Id, Code, Libelle FROM produit WHERE Code > @Code order by code"))
            {
                helper.AddInParameter("Code", DbType.Int32, codeProduit);
                using (var reader = helper.ExecuteQuery())
                {
                    while (reader.Read())
                    {
                        produits.Add(
                            new Produit
                            {
                                Id = reader.GetIntFromReader("Id"),
                                Code = reader.GetIntFromReader("Code"),
                                Libelle = reader.GetStringFromReader("Libelle"),
                            }
                            );
                    }
                }
            }
            return produits;
        }
    }
}