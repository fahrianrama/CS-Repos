using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendataanPenduduk
{
    class Petugas
    {
        public string namapetugas;

        public void Sign()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Petugas yang sedang aktif : {0}", namapetugas);
            Console.WriteLine("=================================================\n");
        }
        public Petugas(string petugas)
        {
            namapetugas = petugas;
        }
    }
}
