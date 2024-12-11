using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Raf : BaseEntity
    {
        public string RafNo { get; set; }

        public int OdaId { get; set; }

        //Relational Properties

        public virtual List<Kitap> Kitaplar { get; set; }

        public virtual Oda Oda { get; set; }
    }
}
