using System;
using System.Collections.Generic;
using Com.GlagSoft.GsCommande.DataAccessObjects;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.Services
{
    public class ProduitService
    {
        private readonly ProduitData _produitData = new ProduitData();

        public List<Produit> GetByFamille(Famille famille)
        {
            return _produitData.GetByFamille(famille);
        }

        public List<Produit> ListProduitStock()
        {
            return _produitData.ListProduitStock();
        }

        public Produit Create(Produit produit)
        {
            return _produitData.Create(produit);
        }

        public bool Update(Produit produit)
        {
            return _produitData.Update(produit);
        }

        public void DeleteTransaction(Produit produit)
        {
            List<Produit> produits = _produitData.ListToUpdateAfterDelete(produit.Code);

            BaseData.BeginTransaction();
            try
            {
                var isDeleted = _produitData.DeleteTransaction(produit);
                if (isDeleted)
                {
                    foreach (var p in produits)
                    {
                        if (p.Code-- < 0)
                            p.Code = 0;
                        isDeleted = _produitData.UpdateCodeTransaction(p);
                        if (!isDeleted)
                            throw new Exception("Impossible de mettre à jour le code");
                    }
                }
                else
                {
                    throw new Exception("Le produit n'a pas pu etre supprimer");
                }

                BaseData.Commit();
            }
            catch (Exception)
            {
                BaseData.RollBack();
                throw;
            }
        }

        public Produit Get(int id)
        {
            return _produitData.Get(id);
        }

        public int GetNextCodeValue(Famille famille)
        {
            var result = _produitData.GetMaxCodeByFamille(famille);

            if (result == -1)
                result = 0;

            return ++result;
        }

        public bool IsCanDelete(Produit produit)
        {
            return _produitData.IsCanDelete(produit);
        }
    }
}