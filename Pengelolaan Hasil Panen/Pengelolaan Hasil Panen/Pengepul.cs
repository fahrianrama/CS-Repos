using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengelolaan_Hasil_Panen
{
    class Pengepul
    {
        public string nama;
        public string domisili;
        public string komoditas;

        public void Status()
        {
            Console.WriteLine("============ Data Pengepul =============");
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("Domisili : {0}", domisili);
            Console.WriteLine("Komoditas : {0}", komoditas);
            Console.WriteLine("========================================\n");
        }

        public Pengepul(string namapengepul, string domisilipengepul, string komoditi)
        {
            nama = namapengepul;
            domisili = domisilipengepul;
            komoditas = komoditi;
        }
    }
}
