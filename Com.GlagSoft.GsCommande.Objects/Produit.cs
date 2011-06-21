using System;

namespace Com.GlagSoft.GsCommande.Objects
{
    public class Produit
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Libelle { get; set; }
        public Famille Famille { get; set; }

        public Produit() { }

        public Produit(int produitId)
        {
            Id = produitId;
        }

    }
}