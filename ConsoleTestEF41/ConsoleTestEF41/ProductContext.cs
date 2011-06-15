using System;
using System.Data.Entity;

namespace ConsoleTestEF41
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<LigneCommande> LigneCommandes { get; set; }
        public DbSet<Commande> Commandes { get; set; }
    }
}