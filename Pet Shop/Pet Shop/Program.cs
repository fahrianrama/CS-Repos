using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] Kandang = new int[30, 2];
            string[,] Hewan = new string[30, 3];
            int menu = 0;
            do
            {
                Header();
                Home();
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.Clear();
                    Header();
                    TambahKandang(Kandang);
                }
                else if (menu == 2)
                {
                    Console.Clear();
                    Header();
                    TambahPeliharaan(Hewan, Kandang);
                }

                else if (menu == 3)
                {
                    Console.Clear();
                    Header();
                    CekKandang(Hewan, Kandang);
                }

                else if (menu == 4)
                {
                    Console.Clear();
                    Header();
                    CariHewan(Hewan);
                }

                else if (menu == 5)
                {
                    Console.Clear();
                    Header();
                    SortirHewan(Hewan);
                }
                Console.ReadKey();
                Console.Clear();
            } while (menu != 6);
        }

        static void Home()
        {
            Console.WriteLine("Menu Admin :");
            Console.WriteLine("\t1. Tambah Kandang");
            Console.WriteLine("\t2. Tambah Peliharaan");
            Console.WriteLine("\t3. Cek Kandang");
            Console.WriteLine("\t4. Cari Nama Hewan");
            Console.WriteLine("\t5. Sortir Hewan");
            Console.WriteLine("\t6. Exit");
            Console.WriteLine("=========================================");
            Console.WriteLine("Pilih : ");
        }

        static void Header()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("========== Menu Admin Petshop ===========");
            Console.WriteLine("=========================================");
        }

        static void TambahKandang(int[,] kandang)
        {
            int next = 0;
            foreach (int i in kandang)
            {
                if (i > 0)
                {
                    next++;
                }
            }
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("============= Kandang Baru =============");
            Console.WriteLine("========================================");
            Console.WriteLine("Masukkan Nomor Kandang : ");
            int nomor = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Kapasitas : ");
            int kapasitas = int.Parse(Console.ReadLine());
            kandang[next, 0] = nomor;
            kandang[next, 1] = kapasitas;
            Console.WriteLine("======== Kandang Ditambahkan !! ========");
        }

        static void TambahPeliharaan(string[,] Hewan, int[,] Kandang)
        {
            int next = 0;
            for (int i = 0; i < 30; i++)
            {
                if (Hewan[i, 0] != null)
                {
                    next++;
                }
            }
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("=========== Peliharaan Baru ============");
            Console.WriteLine("========================================");
            Console.WriteLine("Masukkan Jenis Peliharaan : ");
            string jenis = Console.ReadLine();
            Console.WriteLine("Masukkan Nama : ");
            string nama = Console.ReadLine();
            Console.WriteLine("Dimasukkan ke Kandang Nomor : ");
            string nomor = Console.ReadLine();
            int index = 0;
            for (int i = 0; i < Kandang.Length / 2; i++)
            {

                if (Kandang[i, 0] > 0)
                {
                    if (Kandang[i, 0].ToString() == nomor)
                    {
                        int isi = 0;
                        string nokandang = Kandang[i, 0].ToString();
                        for (int j = 0; j < Hewan.Length / 3; j++)
                        {
                            if (Hewan[j, 2] == nokandang)
                            {
                                isi++;
                            }
                        }
                        if (isi < Kandang[i, 1])
                        {
                            Hewan[next, 0] = jenis;
                            Hewan[next, 1] = nama;
                            Hewan[next, 2] = nomor;
                            Console.WriteLine("======== Hewan Ditambahkan !! ==========");
                        }
                        else
                        {
                            Console.WriteLine("======== Kandang Penuh !! ==========");
                        }
                        index++;
                    }

                }
                else
                {
                    index++;
                }
            }
        }
        static void CekKandang(string[,] Hewan, int[,] Kandang)
        {
            int index = 0;
            for (int i = 0; i < Kandang.Length / 2; i++)
            {
                if (Kandang[i, 0] > 0)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("Nomor Kandang : {0}", Kandang[index, 0]);
                    Console.WriteLine("\tKapasitas Kandang : {0}", Kandang[index, 1]);
                    int isi = 0;
                    Console.WriteLine("\tIsi Kandang : ");
                    string nokandang = Kandang[index, 0].ToString();
                    for (int j = 0; j < Hewan.Length / 3; j++)
                    {
                        if (Hewan[j, 2] == nokandang)
                        {
                            isi++;
                            Console.WriteLine("\t\tHewan ke {0} = {1}", isi, Hewan[j, 0]);
                        }
                    }
                    Console.WriteLine("\tTotal Isi Kandang : {0} Hewan", isi);
                    Console.WriteLine("========================================\n");
                    index++;
                }
                else
                {
                    index++;
                }
            }
        }

        static void CariHewan(string[,] Hewan)
        {
            Console.WriteLine("Masukkan nama peliharaan yang akan dicari : ");
            string nama = Console.ReadLine();
            int x = 0;
            bool found = false;
            foreach (string i in Hewan)
            {
                if (i != null)
                {
                    if (nama == Hewan[x, 1])
                    {
                        Console.WriteLine("========== Peliharaan Ditemukan !! ===========");
                        Console.WriteLine("Nama : {0}", Hewan[x, 1]);
                        Console.WriteLine("\tKandang Nomor : {0}", Hewan[x, 2]);
                        Console.WriteLine("\tJenis Hewan : {0}", Hewan[x, 0]);
                        Console.WriteLine("==============================================\n");
                        found = true;
                    }
                    x++;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Hewan dengan nama {0} tidak ditemukan", nama);
            }
        }

        static void SortirHewan(string[,] Hewan)
        {
            int x = 0;
            int[] NoKandang = new int[Hewan.Length / 3];
            for (int i = 0; i < NoKandang.Length; i++)
            {
                if (Hewan[i, 2] != null)
                {
                    NoKandang[x] = int.Parse(Hewan[i, 2]);
                    x++;
                }
            }
            Array.Sort(NoKandang);
            Console.WriteLine("==== Hewan Berdasarkan Nomor Kandang ====");
            int index;
            int temp = 0;
            foreach (int j in NoKandang)
            {
                if (j > 0)
                {
                    if (j != temp)
                    {
                        Console.WriteLine("\tKandang Nomor : {0}", j);
                        for (int k = 0; k < NoKandang.Length; k++)
                            if (Hewan[k, 0] != null)
                            {
                                if (int.Parse(Hewan[k, 2]) == j)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("\tNama : {0}", Hewan[k, 1]);
                                    Console.WriteLine("\tJenis Hewan : {0}", Hewan[k, 0]);
                                    Console.WriteLine("=========================================");
                                }
                            }
                    }
                    temp = j;
                }
            }
        }
    }
}
