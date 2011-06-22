namespace Com.GlagSoft.GsCommande.Objects
{
    public class Produit
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Libelle { get; set; }
        public Famille Famille { get; set; }

        public int TotalQteKilo { get; set; }
        public int TotalQteDemiKilo { get; set; }

        public string FamilleString
        {
            get
            {
                if (Famille != null)
                    return Famille.Libelle;

                return string.Empty;
            }
        }

        public Produit() { }

        public Produit(int produitId)
        {
            Id = produitId;
        }

    }
}