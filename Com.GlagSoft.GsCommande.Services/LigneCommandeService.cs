using System;
using System.Collections.Generic;
using Com.GlagSoft.GsCommande.DataAccessObjects;
using Com.GlagSoft.GsCommande.Objects;

namespace Com.GlagSoft.GsCommande.Services
{
    public class LigneCommandeService
    {
        private readonly LigneCommandeData _ligneCommandeData = new LigneCommandeData();

        public bool DeleteTransaction(Commande commande)
        {
            return _ligneCommandeData.DeleteTransaction(commande);
        }

        public bool DeleteTransaction(LigneCommande ligneCommande)
        {
            return _ligneCommandeData.DeleteTransaction(ligneCommande);
        }

        private bool UpdateTransaction(LigneCommande ligneCommande)
        {
            return _ligneCommandeData.UpdateTransaction(ligneCommande);
        }

        public bool CreateTransaction(LigneCommande ligneCommande)
        {
            return _ligneCommandeData.CreateTransaction(ligneCommande);
        }

        public List<LigneCommande> ListByCommande(Commande selectedCommande)
        {
            return _ligneCommandeData.ListByCommande(selectedCommande);
        }

        public bool UpdateTransactionByState(LigneCommande ligneCommande)
        {
            var res = false;
            switch (ligneCommande.StateEnum)
            {
                case State.New:
                    res = CreateTransaction(ligneCommande); break;
                case State.Deleted:
                    res = DeleteTransaction(ligneCommande); break;
                case State.Updated:
                    res = UpdateTransaction(ligneCommande); break;
                case State.Unchanged:
                    res = true; break;
            }
            return res;
        }


    }
}