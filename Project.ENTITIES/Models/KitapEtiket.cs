using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class KitapEtiket : BaseEntity
    {
        public int KitapId { get; set; }

        public int EtiketId { get; set; }


        //Relational Properties

        public virtual Kitap Kitap { get; set; }

        public virtual Etiket Etiket { get; set; }
    }
}
