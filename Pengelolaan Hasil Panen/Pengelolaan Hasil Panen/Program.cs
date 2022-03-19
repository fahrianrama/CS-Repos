using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengelolaan_Hasil_Panen
{
    class Program
    {
        static void Main(string[] args)
        {
            HasilPanen Database = new HasilPanen();
            int masuk = 0;
            while (masuk != 3)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("== Program Pengelolaan Data Hasil Panen ==");
                Console.WriteLine("==========================================");
                Console.WriteLine("Masuk Sebagai : \n\t1. Pengepul\n\t2. Petani\n\t3. Keluar");
                Console.WriteLine("=========================================");
                Console.WriteLine("Pilih : ");
                masuk = int.Parse(Console.ReadLine());
                if (masuk == 1)
                {
                    Console.Clear();
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Anda Masuk Sebagai : Pengepul");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Masukkan Nama : ");
                    string namapengepul = Console.ReadLine();
                    Console.WriteLine("Masukkan Domisili : ");
                    string domisilipengepul = Console.ReadLine();
                    Console.WriteLine("Masukkan Jenis Komoditas : ");
                    string komoditi = Console.ReadLine();
                    Console.Clear();
                    Pengepul userpengepul = new Pengepul(namapengepul, domisilipengepul, komoditi);

                    int menupengepul = 0;
                    while (menupengepul != 3)
                    {
                        userpengepul.Status();
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Pilih Menu : \n\t1. Tampilkan Data Pengajuan\n\t2. Setujui/Tolak Pengajuan\n\t3. Keluar");
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Pilih : ");
                        menupengepul = int.Parse(Console.ReadLine());

                        if (menupengepul == 1)
                        {
                            Console.Clear();
                            userpengepul.Status();
                            Database.AllData(komoditi);
                        }
                        else if (menupengepul == 2)
                        {
                            Console.Clear();
                            userpengepul.Status();
                            Database.AllData(komoditi);
                            Database.AksiAjuan(komoditi);
                        }
                        else if (menupengepul > 3)
                        {
                            Console.WriteLine("Menu Tidak Tersedia");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (masuk == 2)
                {
                    Console.Clear();
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Anda Masuk Sebagai : Petani");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Masukkan Nama : ");
                    string namapetani = Console.ReadLine();
                    Console.WriteLine("Masukkan Alamat : ");
                    string alamatpetani = Console.ReadLine();
                    Console.WriteLine("Masukkan Jenis Komoditas : ");
                    string komoditi = Console.ReadLine();

                    Console.Clear();
                    Petani userpetani = new Petani(namapetani, alamatpetani, komoditi);

                    int menupetani = 0;
                    while (menupetani != 4)
                    {
                        userpetani.Status();
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Pilih Menu : \n\t1. Ajukan Hasil Panen\n\t2. Tampilkan Pengajuan Saya\n\t3. Hapus Pengajuan Saya\n\t4. Keluar");
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Pilih : ");
                        menupetani = int.Parse(Console.ReadLine());

                        if (menupetani == 1)
                        {
                            Console.Clear();
                            userpetani.Status();
                            Database.AjukanPermintaan(namapetani, komoditi);
                        }
                        else if (menupetani == 2)
                        {
                            Console.Clear();
                            userpetani.Status();
                            Database.CekPengajuan(namapetani);
                        }
                        else if (menupetani == 3)
                        {
                            Console.Clear();
                            userpetani.Status();
                            Database.CekPengajuan(namapetani);
                            Database.HapusAjuan();
                        }
                        else if (menupetani > 4)
                        {
                            Console.WriteLine("Menu Tidak Tersedia");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.Clear();
            }
        }
    }
}
