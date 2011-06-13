using System.Collections.Generic;
using Com.GlagSoft.GsCommande.DataAccessObjects;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.Services
{
    public class CommandeService
    {
        private readonly CommandeData _commandeData = new CommandeData();

        //todo transaction
        public Commande Create(Commande commande)
        {
            commande = _commandeData.Create(commande);
            if (commande.Id > 0)
            {
                var ligneCommandeService = new LigneCommandeService();
                foreach (var ligneCommande in commande.LigneCommande)
                {
                    ligneCommande.Commande = commande;
                    bool isCreated = ligneCommandeService.Create(ligneCommande);
                    if (!isCreated)
                    {
                        //delete commande et sortir de la boucle.
                        this.Delete(commande);
                        break;
                    }
                }
            }

            return commande;
        }

        //todo transaction
        public bool Delete(Commande commande)
        {
            bool isDeleted = _commandeData.Delete(commande);

            if (isDeleted)
            {
                var ligneCommandeService = new LigneCommandeService();
                ligneCommandeService.Delete(commande);
            }

            return isDeleted;
        }

        //todo transaction
        //todo no need to update all list of ligne commande
        public bool Update(Commande commande)
        {
            bool isUpdated = _commandeData.Update(commande);
            if (isUpdated)
            {
                var ligneCommandeService = new LigneCommandeService();
                foreach (var ligneCommande in commande.LigneCommande)
                {
                    ligneCommandeService.Update(ligneCommande);
                }
            }
            return isUpdated;
        }

        public void Deliver(Commande commande)
        {
            //todo implement
        }

        public void CancelDelivration(Commande commande)
        {
            //todo implement
        }

        public Commande Get(int id)
        {
            //todo implement
            return null;
        }
    }
}
