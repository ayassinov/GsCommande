using System;
using System.Collections.Generic;

namespace Com.GlagSoft.GsCommande.Objects
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public string NomPrenomClient { get; set; }
        public bool IsLivree { get; set; }
        public List<LigneCommande> LigneCommande { get; set; }
    }
}