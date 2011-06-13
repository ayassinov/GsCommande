namespace Com.GlagSoft.GsCommande.Objects
{
    public class LigneCommande
    {
        public Commande Commande { get; set; }
        public Produit Produit { get; set; }
        public int Qtekilo { get; set; }
        public int QteDemiKilo { get; set; }

        public LigneCommande() { }

        public LigneCommande(int produitId, int qteKilo, int qteDemiKilo)
        {
            Produit = new Produit(produitId);
            Qtekilo = qteKilo;
            QteDemiKilo = qteDemiKilo;
        }
    }
}