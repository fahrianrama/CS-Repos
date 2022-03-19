using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengelolaan_Hasil_Panen
{
    class Petani
    {
        public string nama;
        public string alamat;
        public string komoditas;

        public void Status()
        {
            Console.WriteLine("============ Data Petani =============");
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("Domisili : {0}", alamat);
            Console.WriteLine("Komoditas : {0}", komoditas);
            Console.WriteLine("======================================\n");
        }

        public Petani(string namapetani, string alamatpetani, string komoditi)
        {
            nama = namapetani;
            alamat = alamatpetani;
            komoditas = komoditi;
        }
    }
}
