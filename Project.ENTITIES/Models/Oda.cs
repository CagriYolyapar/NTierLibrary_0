using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Oda : BaseEntity
    {
        public string OdaIsmi { get; set; }


        //Relational Properties

        public virtual List<Raf> Raflar { get; set; }
    }
}
