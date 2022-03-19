using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementasi_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Tangan = new string[20];
            string[,] Saku = new string[20, 2];
            int pilihmenu = 0;
            while (pilihmenu != 4)
            {
                Console.Clear();
                int tangan = 0;
                Console.WriteLine("======== Program Implementasi Array ========");
                Console.WriteLine("Barang di Tangan : ");
                foreach (string i in Tangan)
                {
                    if (i != null)
                    {
                        Console.WriteLine("\t-{0}", i);
                        tangan++;
                    }
                }

                Console.WriteLine("Jumlah Barang di Tangan : {0} Barang", tangan);
                Console.WriteLine("============================================");
                Console.WriteLine("Kegiatan : \n\t1. Ambil Barang\n\t2. Taruh Barang\n\t3. Cari Barang\n\t4. Selesai");
                Console.WriteLine("======================================================\n");
                Console.WriteLine("Pilih : ");
                pilihmenu = int.Parse(Console.ReadLine());
                Console.Clear();
                int id = 0;
                if (pilihmenu == 1)
                {
                    foreach (string isi in Tangan)
                    {
                        if (isi != null)
                        {
                            id++;
                        }
                    }
                    Console.WriteLine("Ambil dari : \n\t1. Luar\n\t2. Saku");
                    int pilihambil = int.Parse(Console.ReadLine());
                    if (pilihambil == 1)
                    {
                        Console.WriteLine("Nama Barang : ");
                        string barang = Console.ReadLine();
                        Tangan[id] = barang;
                    }
                    else if (pilihambil == 2)
                    {
                        int hitung = 1;
                        Console.WriteLine("Pilih Barang : ");
                        foreach (string barang in Saku)
                        {
                            if (barang != null)
                            {
                                Console.WriteLine("\t{0}. {1}", hitung, barang);
                                hitung++;
                            }
                        }
                        Console.WriteLine("=============================\n");
                        Console.WriteLine("Masukkan Nama Barang : ");
                        string barangambil = Console.ReadLine();

                        for (int i = 0; i < Saku.Length / 2; i++)
                        {
                            if (Saku[i, 0] == barangambil)
                            {
                                Tangan[id + 1] = Saku[i, 0];
                                Saku[i, 0] = null;
                                Console.WriteLine("Barang Diambil ");
                            }
                            else if (Saku[i, 1] == barangambil)
                            {
                                Tangan[id + 1] = Saku[i, 1];
                                Saku[i, 1] = null;
                                Console.WriteLine("Barang Diambil ");
                            }
                        }
                    }
                }
                else if (pilihmenu == 2)
                {
                    int idbarang = 0;
                    for (int i = 0; i < Tangan.Length; i++)
                    {
                        if (Saku[i, 0] != null)
                        {
                            idbarang++;
                        }
                        else if (Saku[i, 1] != null)
                        {
                            idbarang++;
                        }
                    }
                    Console.WriteLine("Pilih Barang : ");
                    int hitung = 1;
                    foreach (string barang in Tangan)
                    {
                        if (barang != null)
                        {
                            Console.WriteLine("\t{0}. {1}", hitung, barang);
                            hitung++;
                        }
                    }
                    Console.WriteLine("=============================\n");
                    Console.WriteLine("Masukkan Nama Barang : ");
                    string barangtaruh = Console.ReadLine();
                    Console.WriteLine("Pilih Saku <kanan/kiri> : ");
                    string saku = Console.ReadLine();
                    for (int i = 0; i < Tangan.Length; i++)
                    {
                        if (Tangan[i] == barangtaruh)
                        {
                            if (saku == "kanan")
                            {
                                Saku[id, 0] = Tangan[i];
                                Tangan[i] = null;
                                Console.WriteLine("Barang Ditaruh di Saku Kanan ");
                            }
                            else if (saku == "kiri")
                            {
                                Saku[id, 1] = Tangan[i];
                                Tangan[i] = null;
                                Console.WriteLine("Barang Ditaruh di Saku Kiri ");
                            }
                        }
                    }
                }
                else if (pilihmenu == 3)
                {
                    Console.WriteLine("Masukkan Nama Barang : ");
                    string barangcari = Console.ReadLine();
                    for (int i = 0; i < Tangan.Length; i++)
                    {
                        if (Tangan[i] == barangcari)
                        {
                            Console.WriteLine("Barang berada di Tangan");
                        }
                        else if (Saku[i, 0] == barangcari)
                        {
                            Console.WriteLine("Barang ditemukan di Saku Kanan");
                        }
                        else if (Saku[i, 1] == barangcari)
                        {
                            Console.WriteLine("Barang ditemukan di Saku Kiri");
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
