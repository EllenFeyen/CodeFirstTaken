using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTaken
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TakenContext>());
            using (var context = new TakenContext())
            {
                var fruit = new Artikelgroep { Naam = "Fruit" };
                var appel = new FoodArtikel { Artikelgroep = fruit, Houdbaarheid = 60, Naam = "Appel" };
                var fruitboer = new Leverancier { Naam = "Fruit Boer", Artikels = new List<Artikel> { appel } };
                context.Artikelgroepen.Add(fruit);
                context.Artikels.Add(appel);
                context.Leveranciers.Add(fruitboer);
                context.SaveChanges();
            }
        }
    }
}
