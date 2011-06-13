using System.Collections.Generic;
using Com.GlagSoft.GsCommande.DataAccessObjects;
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

        public Produit Create(Produit produit)
        {
            produit.Code = _produitData.GetMaxCodeByFamille(produit.Famille);
            return _produitData.Create(produit);
        }

        public bool Update(Produit produit)
        {
            return _produitData.Update(produit);
        }

        public bool Delete(Produit produit)
        {
            return _produitData.Delete(produit);
        }

        public Produit Get(int id)
        {
            return _produitData.Get(id);
        }
    }
}