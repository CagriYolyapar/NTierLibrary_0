using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Etiket : BaseEntity
    {
        public string Baslik { get; set; }

        //Relational Properties

        public virtual List<KitapEtiket> KitapEtiketleri { get; set; }
    }
}
