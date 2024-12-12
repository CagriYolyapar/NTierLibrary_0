using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class EtiketConfiguration : BaseConfiguration<Etiket>
    {
        public EtiketConfiguration()
        {
            ToTable("Etiketler");
        }
    }
}
