using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manajemen_Gudang
{
    class Cabang
    {
        List<int> idgudang = new List<int>();
        List<string> namagudang = new List<string>();
        List<string> lokasigudang = new List<string>();

        public void Header()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("========== Menu Gudang Cabang ===========");
            Console.WriteLine("=========================================");
        }

        public void TambahCabang()
        {
            Console.WriteLine("Masukkan ID Gudang : ");
            int id = int.Parse(Console.ReadLine());
            idgudang.Add(id);
            Console.WriteLine("Masukkan Nama Gudang : ");
            string nama = Console.ReadLine();
            namagudang.Add(nama);
            Console.WriteLine("Masukkan Lokasi Gudang : ");
            string lokasi = Console.ReadLine();
            lokasigudang.Add(lokasi);
            Console.WriteLine("========================================");
            Console.WriteLine("Gudang Cabang Berhasil Ditambahkan");
            Console.WriteLine("========================================");
        }
        public void DataGudang()
        {
            Console.WriteLine("Data Seluruh Gudang Cabang");
            for (int i = 0; i < idgudang.Count; i++)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("ID Gudang -{0}", idgudang[i]);
                Console.WriteLine("\tNama Gudang : {0}", namagudang[i]);
                Console.WriteLine("\tLokasi Gudang : {0}", lokasigudang[i]);
                Console.WriteLine("========================================\n");
            }
        }
    }
}
