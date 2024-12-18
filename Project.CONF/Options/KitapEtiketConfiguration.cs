﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class KitapEtiketConfiguration : BaseConfiguration<KitapEtiket>
    {
        //Iliskiler
        public KitapEtiketConfiguration()
        {
            ToTable("Kitap Etiketleri");
            Ignore(x => x.Id);

            HasKey(x => new
            {
                x.KitapId,
                x.EtiketId
            });
        }
    }
}
