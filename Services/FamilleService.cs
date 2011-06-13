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
            return _familleData.Create(famille);
        }

        public List<Famille> ListAll()
        {
            return _familleData.ListAll();
        }
    }
}