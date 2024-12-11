using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Kategori : BaseEntity
    {
        public string Isim { get; set; }

        //Relational Properties

        public virtual List<Kitap> Kitaplar { get; set; }
    }
}
