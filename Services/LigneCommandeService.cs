using System.Collections.Generic;
using Com.GlagSoft.GsCommande.DataAccessObjects;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.Services
{
    public class LigneCommandeService
    {
        private readonly LigneCommandeData _ligneCommandeData = new LigneCommandeData();

        public bool Create(LigneCommande ligneCommande)
        {
            return _ligneCommandeData.Create(ligneCommande);
        }

        public bool Delete(LigneCommande ligneCommande)
        {
            return _ligneCommandeData.Delete(ligneCommande);
        }

        public bool Delete(Commande commande)
        {
            return _ligneCommandeData.Delete(commande);
        }

        public bool Update(LigneCommande ligneCommande)
        {
            return _ligneCommandeData.Update(ligneCommande);
        }
    }
}