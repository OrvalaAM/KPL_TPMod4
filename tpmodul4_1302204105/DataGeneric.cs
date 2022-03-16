using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204105
{
    internal class DataGeneric<T>
    {
        private T data;
        public DataGeneric() { }
        public DataGeneric(T isi)
        {
            data = isi;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
