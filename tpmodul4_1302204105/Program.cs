using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204105
{
    public class Program
    {
        public static void Main()
        {
<<<<<<< HEAD
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Orvala");
        }
    }
}
=======
            DataGeneric<string> data = new DataGeneric<string>("Orvala");
            data.PrintData();
        }
    }
}
>>>>>>> generic-class
