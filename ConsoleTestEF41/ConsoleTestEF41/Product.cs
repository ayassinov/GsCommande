using System.Collections.Generic;

namespace ConsoleTestEF41
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LigneCommande> LigneCommandes { get; set; }
    }
}