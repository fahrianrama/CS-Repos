using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Buah
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] Sort = new string[30];
            string[,] Gudang = new string[30, 3];
            int menu = 0;
            do
            {
                Console.Clear();
                Stats(Gudang);
                Menu();
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                if (menu == 1)
                {
                    Stats(Gudang);
                    Tambah(Gudang);
                }
                else if (menu == 2)
                {
                    Stats(Gudang);
                    Lihat(Gudang);
                }
                else if (menu == 3)
                {
                    Stats(Gudang);
                    Ubah(Gudang);
                }
                else if (menu == 4)
                {
                    Stats(Gudang);
                    Urut(Gudang, Sort);
                }
                Console.ReadKey();

            } while (menu != 5);

        }

        static void Stats(string[,] Gudang)
        {
            Console.WriteLine("======== Stok Buah Gudang ========");
            Console.WriteLine("Total Stok : {0} Kg", Total(Gudang));
            Console.WriteLine("Jenis Buah : {0} Jenis", Jenis(Gudang));
            Console.WriteLine("==================================");
        }

        static void Menu()
        {
            Console.WriteLine("Pilih Menu : ");
            Console.WriteLine("\t1. Tambah Stok : ");
            Console.WriteLine("\t2. Lihat Stok : ");
            Console.WriteLine("\t3. Ubah Stok : ");
            Console.WriteLine("\t4. Sortir Stok : ");
            Console.WriteLine("\t5. Keluar : ");
            Console.WriteLine("==================================");
            Console.WriteLine("Pilih : ");
        }

        static void Lihat(string[,] Gudang)
        {
            for (int loop = 0; loop < 30; loop++)
            {
                if (Gudang[loop, 1] != null)
                {
                    Console.WriteLine("Jenis Buah : {0}\n\tStok : {1}Kg\n\tHarga : {2}.", Gudang[loop, 0], Gudang[loop, 1], Gudang[loop, 2]);
                }
            }
        }
        static int Total(string[,] Gudang)
        {
            int total = 0;
            for (int loop = 0; loop < 30; loop++)
            {
                if (Gudang[loop, 1] != null)
                {
                    total += int.Parse(Gudang[loop, 1]);
                }
            }
            return total;
        }
        static int Jenis(string[,] Gudang)
        {
            int jenis = 0;
            for (int loop = 0; loop < 30; loop++)
            {
                if (Gudang[loop, 0] != null)
                {
                    jenis++;
                }
            }
            return jenis;
        }

        static int Index(string[,] Gudang)
        {
            int indeks = 0;
            for (int i = 0; i < Gudang.Length / 3; i++)
            {
                if (Gudang[i, 0] != null)
                {
                    indeks++;
                }
            }
            return indeks;
        }

        static void Tambah(string[,] Gudang)
        {
            int indeks = Index(Gudang);
            Console.WriteLine("Jenis Buah : ");
            string jenisbuah = Console.ReadLine();
            Console.WriteLine("Jumlah Buah (kg) : ");
            string beratbuah = Console.ReadLine();
            Console.WriteLine("Harga Buah (kg) : ");
            string hargabuah = Console.ReadLine();

            Gudang[indeks, 0] = jenisbuah;
            Gudang[indeks, 1] = beratbuah;
            Gudang[indeks, 2] = hargabuah;
        }

        static void Ubah(string[,] Gudang)
        {
            Lihat(Gudang);
            Console.WriteLine("==============================");
            Console.WriteLine("Masukkan Jenis Buah : ");
            string jenisbuah = Console.ReadLine();
            for (int i = 0; i < Gudang.Length / 3; i++)
            {
                if (Gudang[i, 0] == jenisbuah)
                {
                    Console.WriteLine("Jumlah Awal : {0}Kg", Gudang[i, 1]);
                    Console.WriteLine("Ubah Jumlah Buah (kg) : ");
                    string beratbuah = Console.ReadLine();
                    Console.WriteLine("Harga Awal : {0}/kg", Gudang[i, 2]);
                    Console.WriteLine("Harga Buah (kg) : ");
                    string hargabuah = Console.ReadLine();
                    Gudang[i, 1] = beratbuah;
                    Gudang[i, 2] = hargabuah;
                }
            }
        }

        static void Urut(string[,] Gudang, string[] Sort)
        {
            Array.Clear(Sort, 0, Sort.Length);
            int indeks = 0;
            for (int i = 0; i < Gudang.Length / 3; i++)
            {
                if (Gudang[i, 0] != null)
                {
                    Sort[indeks] = Gudang[i, 0];
                    indeks++;
                }
            }
            Console.WriteLine("Pilih Menu : \n\t1. Sortir Menaik\n\t2. Sortir Menurun");
            int sortir = int.Parse(Console.ReadLine());
            Array.Sort(Sort);
            Console.WriteLine("Hasil Pengurutan Jenis Buah : ");
            if (sortir == 1)
            {
                for (int i = 0; i < Sort.Length; i++)
                {
                    if (Sort[i] != null)
                    {
                        for (int j = 0; j < Sort.Length; j++)
                        {
                            if (Sort[i] == Gudang[j, 0])
                            {
                                Console.WriteLine("Jenis Buah : {0}\n\tStok : {1}Kg\n\tHarga : {2}.", Gudang[j, 0], Gudang[j, 1], Gudang[j, 2]);
                            }
                        }
                    }
                }
            }
            else if (sortir == 2)
            {
                for (int i = 29; i >= 0; i--)
                {
                    if (Sort[i] != null)
                    {
                        for (int j = 0; j < Sort.Length; j++)
                        {
                            if (Sort[i] == Gudang[j, 0])
                            {
                                Console.WriteLine("Jenis Buah : {0}\n\tStok : {1}Kg\n\tHarga : {2}.", Gudang[j, 0], Gudang[j, 1], Gudang[j, 2]);
                            }
                        }
                    }
                }
            }
        }
    }
}
