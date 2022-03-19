using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendataanPenduduk
{
    class Program
    {
        static void Main(string[] args)
        {
            Penduduk datapenduduk = new Penduduk();
            int menuprogram = 0;
            Console.WriteLine("============================================");
            Console.WriteLine("Selamat datang di Program Pendataan Penduduk");
            Console.WriteLine("============================================");
            Console.WriteLine("Silahkan masukkan nama Anda : ");
            string petugas = Console.ReadLine();
            Petugas pendata = new Petugas(petugas);
            while (menuprogram != 6)
            {
                Console.Clear();
                pendata.Sign();
                Console.WriteLine("Silahkan Pilih Menu Petugas : ");
                Console.WriteLine("\t 1. Tambah Data Penduduk : ");
                Console.WriteLine("\t 2. Tampilkan Seluruh Data Penduduk : ");
                Console.WriteLine("\t 3. Data Umur Penduduk : ");
                Console.WriteLine("\t 4. Data Status Pekerjaan Penduduk : ");
                Console.WriteLine("\t 5. Data Penghasilan Penduduk : ");
                Console.WriteLine("\t 6. Matikan Program : ");
                Console.WriteLine("============================================");
                Console.WriteLine("Pilih Menu : ");
                menuprogram = int.Parse(Console.ReadLine());
                if (menuprogram != 6)
                {
                    Console.Clear();
                    pendata.Sign();
                }
                if (menuprogram == 1)
                {
                    datapenduduk.TambahData();
                }
                else if (menuprogram == 2)
                {
                    datapenduduk.TampilkanData();
                }
                else if (menuprogram == 3)
                {
                    datapenduduk.DataUmur();
                }
                else if (menuprogram == 4)
                {
                    datapenduduk.DataBekerja();
                }
                else if (menuprogram == 5)
                {
                    datapenduduk.RataPenghasilan();
                }
                else if (menuprogram > 6)
                {
                    Console.WriteLine("Maaf menu tidak tersedia");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
