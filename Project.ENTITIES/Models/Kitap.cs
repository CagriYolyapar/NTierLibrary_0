using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Kitap :BaseEntity
    {
        public string Isim { get; set; }

        public int YazarId { get; set; }

        public int RafId { get; set; }

        public int KategoriId { get; set; }


        //Relational Properties

        public virtual Yazar Yazar { get; set; }

        public virtual Raf Raf { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual List<KitapEtiket> KitapEtiketleri { get; set; }

    }
}
