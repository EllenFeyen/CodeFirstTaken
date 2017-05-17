using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTaken
{
    public class TakenContext : DbContext
    {
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<Artikelgroep> Artikelgroepen { get; set; }
        public DbSet<Leverancier> Leveranciers { get; set; }
    }
}
