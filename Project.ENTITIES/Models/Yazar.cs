using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Yazar : BaseEntity
    {
        public string Isim { get; set; }

        public string SoyIsim { get; set; }


        //Relational Properties

        public virtual List<Kitap> Kitaplar { get; set; }
    }
}
