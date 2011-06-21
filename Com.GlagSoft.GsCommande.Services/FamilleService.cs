using System;
using System.Collections.Generic;
using Com.GlagSoft.GsCommande.DataAccessObjects;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.Services
{
    public class FamilleService
    {
        private readonly FamilleData _familleData = new FamilleData();

        public Famille Create(Famille famille)
        {
            famille = _familleData.Create(famille);
            if (!(famille.Id > 0))
                throw new Exception("Famille non ajouté");
            return famille;
        }

        public List<Famille> ListAll()
        {
            return _familleData.ListAll();
        }

        public void Update(Famille famille)
        {
            var isok = _familleData.Update(famille);

            if (!isok)
                throw new Exception("Famille non mis à jour");
        }

        public void Delete(Famille famille)
        {
            var isOk = _familleData.Delete(famille);
            if (!isOk)
                throw new Exception("Famille non supprimé");
        }
    }
}