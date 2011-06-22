﻿using System;
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
                commande = _commandeData.CreateTransaction(commande);
                if (commande.Id > 0)
                {
                    foreach (var ligneCommande in commande.LigneCommande)
                    {
                        ligneCommande.Commande = commande;
                        bool isCreated = _ligneCommandeService.CreateTransaction(ligneCommande);
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

        public void Delete(Commande commande)
        {
            _commandeData.BeginTransaction();
            try
            {
                bool isDeleted = _commandeData.DeleteTransaction(commande);

                if (isDeleted)
                {
                    bool isligneDeleted = _ligneCommandeService.DeleteTransaction(commande);
                    if (!isligneDeleted)
                        throw new Exception("Une erreur s'est produite lors de la suppression de la ligne commande");
                }
                else
                {
                    throw new Exception("Une erreur s'est produite lors de la suppression de la commande");
                }

                _commandeData.Commit();
            }
            catch (Exception)
            {
                _commandeData.RollBack();
                throw;
            }
        }

        public void UpdateTransaction(Commande commande)
        {

            _commandeData.BeginTransaction();
            try
            {
                var isUpdated = _commandeData.UpdateTransaction(commande);

                if (isUpdated)
                {
                    foreach (var ligneCommande in commande.LigneCommande)
                    {
                        ligneCommande.Commande = commande;
                        var isexecuted = _ligneCommandeService.UpdateTransactionByState(ligneCommande);
                        if (!isexecuted)
                            throw new Exception("Une erreur s'est produite lors du traitement sur de la ligne commande");
                    }
                }
                else
                {
                    throw new Exception("Une erreur s'est produite lors de la mise à jour de la commande");
                }

                _commandeData.Commit();
            }
            catch (Exception exception)
            {
                _commandeData.RollBack();
                throw;
            }
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
            return _commandeData.Get(id);
        }

        public List<Commande> Recherche(Commande commande)
        {
            return _commandeData.Recherche(commande);
        }


    }
}