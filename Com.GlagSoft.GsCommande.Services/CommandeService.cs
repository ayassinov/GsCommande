using System;
using System.Collections.Generic;
using Com.GlagSoft.GsCommande.DataAccessObjects;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.Services
{
    public class CommandeService
    {
        private CommandeData _commandeData = new CommandeData();
        private LigneCommandeService _ligneCommandeService = new LigneCommandeService();


        public Commande Create(Commande commande)
        {
            _commandeData.BeginTransaction();

            try
            {
                commande = _commandeData.Create(commande);
                if (commande.Id > 0)
                {
                    foreach (var ligneCommande in commande.LigneCommande)
                    {
                        ligneCommande.Commande = commande;
                        bool isCreated = _ligneCommandeService.Create(ligneCommande);
                        if (!isCreated)
                            throw new Exception("Ligne Commande non creer");
                    }
                }
                else
                {

                    throw new Exception("Commande non créer");
                }

                _commandeData.Commit();
            }
            catch (Exception)
            {
                _commandeData.RollBack();
                throw;
            }

            return commande;
        }

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
            bool isDelivred = _commandeData.Deliver(commande);
            if (!isDelivred)
                throw new Exception("Une erreur s'est produite lors de la livraison de la commande");
        }

        public void CancelDelivery(Commande commande)
        {
            bool isCanceled = _commandeData.CancelDelivery(commande);
            if (!isCanceled)
                throw new Exception("Une erreur s'est produite lors de la livraison de la commande");
        }

        public Commande Get(int id)
        {
            //todo implement
            return null;
        }

        public List<Commande> Recherche(Commande commande)
        {
            return _commandeData.Recherche(commande);
        }
    }
}
