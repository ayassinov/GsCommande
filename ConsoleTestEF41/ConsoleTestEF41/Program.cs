using System;
using System.Data.Entity;
using System.Linq;

namespace ConsoleTestEF41
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProductContext>());
           

             FillCommande();
            // Delete();
             DeleteLigneCommande();
        }

        private static void DeleteLigneCommande()
        {
            using (var db = new ProductContext())
            {
                var commande = db.LigneCommandes.Where(c => c.Commande.CommandeId == 1).FirstOrDefault();
                if (commande != null)
                {
                    db.LigneCommandes.Remove(commande);
                    int nb = db.SaveChanges();
                    Console.WriteLine("removed commande with id " + nb);
                    Console.ReadKey();
                }

                var commande2 = db.Commandes.Find(1);
                if (commande2 == null)
                    return;

                if (commande2.LigneCommandes == null || commande2.LigneCommandes.Count == 0)
                {
                    db.Commandes.Remove(commande2);
                }
            }
        }

        private static void Delete()
        {
            using (var db = new ProductContext())
            {
                var commande = db.Commandes.Find(1);
                if (commande != null)
                {
                    db.Commandes.Remove(commande);
                    int nb = db.SaveChanges();
                    Console.WriteLine("removed commande with id " + nb);
                }
            }
        }


        private static void FillCommande()
        {
            using (var db = new ProductContext())
            {
                int recordsAffected;
                var product = db.Products.Find(1);
                if (product == null)
                {

                    product = new Product() { Name = "merde" };
                    db.Products.Add(product);
                    recordsAffected = db.SaveChanges();
                    Console.WriteLine("Save {0} entities to the database", recordsAffected);
                    Console.ReadKey();
                }

                var commande = db.Commandes.Find(1);
                if (commande == null)
                {
                    commande = new Commande { Client = "client de merde" };
                    db.Commandes.Add(commande);
                    recordsAffected = db.SaveChanges();
                    Console.WriteLine("Save {0} entities to the database", recordsAffected);
                    Console.ReadKey();
                }

                var ligneCommande = new LigneCommande
                {
                    Commande = commande,
                    Product = product,
                    QteDemiKilo = 2,
                    QteKilo = 3
                };

                db.LigneCommandes.Add(ligneCommande);
                recordsAffected = db.SaveChanges();
                Console.WriteLine("Save {0} entities to the database", recordsAffected);
                Console.ReadKey();


                // Query for all Food products using LINQ 
                var allCommandes = from c in db.Commandes
                                   orderby c.Client
                                   select c;

                Console.WriteLine("All commandes in database:");
                foreach (var item in allCommandes)
                {
                    Console.WriteLine(" - {0}", item.Client);
                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
