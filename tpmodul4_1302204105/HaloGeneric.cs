﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204105
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T sapa)
        {
            Console.WriteLine("Halo user " + sapa);
        }
    }
}
