using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manajemen_Gudang
{
    class Stok
    {
        public List<int> idbarang = new List<int>();
        public List<string> namabarang = new List<string>();
        public List<int> hargabarang = new List<int>();
        public List<int> jumlahbarang = new List<int>();

        public void Header()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("============== Menu Stok ================");
            Console.WriteLine("=========================================");
        }

        public void StokBaru()
        {
            Console.WriteLine("Masukkan ID Barang : ");
            int id = int.Parse(Console.ReadLine());
            idbarang.Add(id);
            Console.WriteLine("Masukkan Nama Barang : ");
            string nama = Console.ReadLine();
            namabarang.Add(nama);
            Console.WriteLine("Masukkan Harga Satuan : ");
            int harga = int.Parse(Console.ReadLine());
            hargabarang.Add(harga);
            Console.WriteLine("Masukkan Jumlah Stok : ");
            int jumlah = int.Parse(Console.ReadLine());
            jumlahbarang.Add(jumlah);
            Console.Clear();
            Console.WriteLine("Stok Barang Berhasil\n");
        }

        public void DataStok()
        {
            Console.WriteLine("Data Barang Gudang Utama");
            for (int i = 0; i < idbarang.Count; i++)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("ID Barang -{0}", idbarang[i]);
                Console.WriteLine("\tNama Barang : {0}", namabarang[i]);
                Console.WriteLine("\tHarga Satuan : {0}", hargabarang[i]);
                Console.WriteLine("\tTotal Stok : {0}", jumlahbarang[i]);
                Console.WriteLine("========================================\n");
            }
        }

        public void HapusStok()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Masukkan ID Barang : ");
            int id = int.Parse(Console.ReadLine());
            string available = "n";
            Console.WriteLine("========================================");
            for (int i = 0; i < idbarang.Count; i++)
            {
                if (idbarang[i] == id)
                {
                    Console.WriteLine("Data Barang dengan ID-{0} ({1}) telah dihapus", idbarang[i], namabarang[i]);
                    idbarang.RemoveAt(i);
                    namabarang.RemoveAt(i);
                    hargabarang.RemoveAt(i);
                    jumlahbarang.RemoveAt(i);
                    Console.WriteLine("========================================");
                    available = "y";
                }
            }
            if (available == "n")
            {
                Console.WriteLine("Data dengan ID {0} tidak ditemukan", id);
            }
        }
        public int GetBarang()
        {
            Console.WriteLine("Masukkan ID Barang : ");
            int idcari = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Jumlah Pengiriman : ");
            int total = int.Parse(Console.ReadLine());
            string available = "n";
            Console.WriteLine("========================================");
            for (int i = 0; i < idbarang.Count; i++)
            {
                if (idbarang[i] == idcari)
                {
                    Console.WriteLine("Data Barang dengan ID-{0} ({1}) telah dikirim sebanyak {2}pcs", idbarang[i], namabarang[i], total);
                    Console.WriteLine("========================================");
                    jumlahbarang[i] -= total;
                    available = "y";
                    return idbarang[i];
                }
            }
            if (available == "n")
            {
                Console.WriteLine("Data dengan ID {0} tidak ditemukan", idcari);
                return 0;
            }
            return 0;
        }
    }
}
