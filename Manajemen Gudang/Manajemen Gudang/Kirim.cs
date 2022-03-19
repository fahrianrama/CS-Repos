using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manajemen_Gudang
{
    class Kirim
    {
        public void Header()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("======= Pengiriman Menuju Cabang ========");
            Console.WriteLine("=========================================");
        }

        public int GetGudang()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Masukkan ID Gudang : ");
            int idgudang = int.Parse(Console.ReadLine());
            return idgudang;
        }
    }
}
