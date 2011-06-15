using System.ComponentModel.DataAnnotations;
namespace ConsoleTestEF41
{
    public class LigneCommande
    {
        // public int LigneCommandeId { get; set; }
        [Key, Column(Order = 0)]
        public int CommandeId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        public int QteKilo { get; set; }
        public int QteDemiKilo { get; set; }


        public virtual Commande Commande { get; set; }
        public virtual Product Product { get; set; }
    }
}