namespace Com.GlagSoft.GsCommande.Objects
{
    public class LigneCommande
    {
        public Commande Commande { get; set; }
        public Produit Produit { get; set; }
        public int Qtekilo { get; set; }
        public int QteDemiKilo { get; set; }
        public State StateEnum { get; set; }

        public string LibelleFamille
        {
            get
            {
                if (Produit != null && Produit.Famille != null)
                    return Produit.Famille.Libelle;

                return string.Empty;

            }
        }

        public string LibelleProduit
        {
            get
            {
                if (Produit != null)
                    return Produit.Libelle;
                return string.Empty;
            }
        }

        public LigneCommande()
        {
            StateEnum = State.Unchanged;
        }

        public LigneCommande(int produitId, int qteKilo, int qteDemiKilo)
        {
            Produit = new Produit(produitId);
            Qtekilo = qteKilo;
            QteDemiKilo = qteDemiKilo;
            StateEnum = State.Unchanged;
        }
    }

    public enum State
    {
        Unchanged,
        Deleted,
        New,
        Updated
    }
}