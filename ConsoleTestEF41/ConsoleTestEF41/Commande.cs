using System.Collections.Generic;

namespace ConsoleTestEF41
{
    public class Commande
    {
        public int CommandeId { get; set; }
        public string Client { get; set; }
        
        public virtual ICollection<LigneCommande> LigneCommandes { get; set; }
    }
}