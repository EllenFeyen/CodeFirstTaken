using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstTaken
{
    [Table("NonFoodArtikels")]
    public class NonFoodArtikel : Artikel
    {
        public int Garantie { get; set; }
    }
}
