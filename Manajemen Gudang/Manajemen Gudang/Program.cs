using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manajemen_Gudang
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idg = new List<int>();
            List<int> idp = new List<int>();
            Stok ManajemenBarang = new Stok();
            Cabang GudangCabang = new Cabang();
            int menu = 0;
            while (menu != 4)
            {
                Console.WriteLine("========== Manajemen Gudang Utama ==========");
                Console.WriteLine("Pilih Menu Gudang : \n\t1. Stok Utama\n\t2. Kirim Ke Cabang\n\t3. Manajemen Cabang\n\t4. Keluar");
                Console.WriteLine("=========================================");
                Console.WriteLine("Pilih : ");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    int menustok = 0;
                    while (menustok != 4)
                    {
                        Console.Clear();
                        ManajemenBarang.Header();
                        Console.WriteLine("Pilih Menu : \n\t1. Tampilkan Seluruh Stok\n\t2. Stok Baru\n\t3. Hapus Stok\n\t4. Menu Utama");
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Pilih : ");
                        menustok = int.Parse(Console.ReadLine());
                        if (menustok == 1)
                        {
                            Console.Clear();
                            ManajemenBarang.Header();
                            ManajemenBarang.DataStok();
                        }
                        else if (menustok == 2)
                        {
                            Console.Clear();
                            ManajemenBarang.Header();
                            ManajemenBarang.StokBaru();
                        }
                        else if (menustok == 3)
                        {
                            Console.Clear();
                            ManajemenBarang.Header();
                            ManajemenBarang.HapusStok();
                        }
                        else if (menustok > 4)
                        {
                            Console.Clear();
                            ManajemenBarang.Header();
                            Console.WriteLine("Menu yang anda masukkan salah");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (menu == 2)
                {
                    Kirim Pengiriman = new Kirim();
                    int menukirim = 0;
                    Console.Clear();
                    while (menukirim != 3)
                    {

                        Console.WriteLine("Pilih Menu : \n\t1. Kirim Barang\n\t2. Cek Pengiriman\n\t3. Menu Utama");
                        Console.WriteLine("Pilih : ");
                        menukirim = int.Parse(Console.ReadLine());
                        if (menukirim == 1)
                        {
                            Console.Clear();
                            Pengiriman.Header();
                            int gudang = Pengiriman.GetGudang();
                            int produk = ManajemenBarang.GetBarang();
                            idg.Add(gudang);
                            idp.Add(produk);
                        }
                        else if (menukirim == 2)
                        {
                            Console.Clear();
                            Pengiriman.Header();
                            Console.WriteLine("Data Pengiriman");
                            for (int i = 0; i < idg.Count; i++)
                            {
                                Console.WriteLine("========================================");
                                Console.WriteLine("Pengiriman Ke-{0}", i + 1);
                                Console.WriteLine("\tID Gudang : {0}", idg[i]);
                                Console.WriteLine("\tID Produk : {0}", idp[i]);
                                Console.WriteLine("========================================\n");
                            }
                        }
                        else if (menukirim > 3)
                        {
                            Console.Clear();
                            Pengiriman.Header();
                            Console.WriteLine("Menu yang anda masukkan salah");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                else if (menu == 3)
                {
                    int menucabang = 0;
                    Console.Clear();
                    while (menucabang != 3)
                    {
                        GudangCabang.Header();
                        Console.WriteLine("Pilih Menu : \n\t1. Tambahkan Cabang\n\t2. Cek Cabang\n\t3. Menu Utama");
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Pilih : ");
                        menucabang = int.Parse(Console.ReadLine());
                        if (menucabang == 1)
                        {
                            Console.Clear();
                            GudangCabang.Header();
                            GudangCabang.TambahCabang();
                        }
                        else if (menucabang == 2)
                        {
                            Console.Clear();
                            GudangCabang.Header();
                            GudangCabang.DataGudang();
                        }
                        else if (menucabang > 3)
                        {
                            Console.Clear();
                            GudangCabang.Header();
                            Console.WriteLine("Menu yang anda masukkan salah");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
