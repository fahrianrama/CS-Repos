using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog_Buku
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] Katalog = new string[100, 1, 3];
            int[] IDbuku = new int[100];
            int pilihan = 0;
            while (pilihan != 5)
            {
                Console.WriteLine("======================================================\n");
                Console.WriteLine("Welcome To Program Katalog Buku Perpustakaan JayaStudi\n");
                Console.WriteLine("======================================================\n");
                Console.WriteLine("Silahkan Pilih Opsi Menu : \n\t1. Tampilkan Seluruh Data\n\t2. Masukkan Data Buku\n\t3. Cari Data Buku\n\t4. Urutkan Data Buku\n\t5. Keluar");
                Console.WriteLine("======================================================\n");
                Console.WriteLine("Pilih : ");
                pilihan = int.Parse(Console.ReadLine());
                if (pilihan == 1)
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("======== Data Buku Perpustakaan ========");
                    Console.WriteLine("========================================");
                    int x = 0;
                    foreach (int i in IDbuku)
                    {
                        if (i > 0)
                        {
                            Console.WriteLine("========================================");
                            Console.WriteLine("Data Buku -{0}", x + 1);
                            Console.WriteLine("\tID Buku : {0}", Katalog[x, 0, 0]);
                            Console.WriteLine("\tJudul Buku : {0}", Katalog[x, 0, 1]);
                            Console.WriteLine("\tPenerbit : {0}", Katalog[x, 0, 2]);
                            Console.WriteLine("========================================\n");
                            x++;
                        }
                    }
                }
                else if (pilihan == 2)
                {
                    Console.Clear();
                    int posisi = 0;
                    foreach (int i in IDbuku)
                    {
                        if (i > 0)
                        {
                            posisi++;
                        }
                    }
                    Console.WriteLine("Masukkan banyak data yang akan diinput");
                    int jumlah = int.Parse(Console.ReadLine());
                    for (int i = 0; i < jumlah; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("========================================");
                        Console.WriteLine("=========== Input Data Buku ============");
                        Console.WriteLine("========================================");
                        Console.WriteLine("Input Buku ke -{0}", i + 1);
                        Console.WriteLine("Masukkan ID Buku : ");
                        int id = int.Parse(Console.ReadLine());
                        string idbuku = id.ToString();
                        Console.WriteLine("Masukkan Judul Buku : ");
                        string judul = Console.ReadLine();
                        Console.WriteLine("Masukkan Penerbit Buku : ");
                        string penerbit = Console.ReadLine();
                        IDbuku[posisi] = id;
                        Katalog[posisi, 0, 0] = idbuku;
                        Katalog[posisi, 0, 1] = judul;
                        Katalog[posisi, 0, 2] = penerbit;
                        posisi++;
                    }
                }
                else if (pilihan == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Masukkan ID Buku yang akan dicari : ");
                    string cari = Console.ReadLine();
                    int x = 0;
                    string pencarian = "";
                    foreach (int i in IDbuku)
                    {
                        if (i > 0)
                        {
                            if (cari == Katalog[x, 0, 0])
                            {
                                Console.WriteLine("========================================");
                                Console.WriteLine("========== Data Ditemukan !! ===========");
                                Console.WriteLine("========================================");
                                Console.WriteLine("Data Buku -{0}", x + 1);
                                Console.WriteLine("\tID Buku : {0}", Katalog[x, 0, 0]);
                                Console.WriteLine("\tJudul Buku : {0}", Katalog[x, 0, 1]);
                                Console.WriteLine("\tPenerbit : {0}", Katalog[x, 0, 2]);
                                Console.WriteLine("========================================\n");
                                pencarian = "sukses";
                            }
                            x++;
                        }
                    }
                    if (pencarian != "sukses")
                    {
                        Console.WriteLine("Data tidak ditemukan");
                    }
                }
                else if (pilihan == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Urutkan Berdasarkan : \n\t1. ID Buku\n\t2. Judul Buku\n Pilih : ");
                    int urutan = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (urutan == 1)
                    {
                        Array.Sort(IDbuku);
                        Console.WriteLine("========================================");
                        Console.WriteLine("======== Data Hasil Pengurutan =========");
                        Console.WriteLine("========================================");
                        int x = 0;
                        int y = 0;
                        foreach (int i in IDbuku)
                        {
                            if (i > 0)
                            {
                                string idbook = IDbuku[x].ToString();
                                for (int j = 0; j < IDbuku.Length; j++)
                                {
                                    if (idbook == Katalog[j, 0, 0])
                                    {
                                        Console.WriteLine("Data Buku -{0}", y + 1);
                                        Console.WriteLine("\tID Buku : {0}", Katalog[j, 0, 0]);
                                        Console.WriteLine("\tJudul Buku : {0}", Katalog[j, 0, 1]);
                                        Console.WriteLine("\tPenerbit : {0}", Katalog[j, 0, 2]);
                                        Console.WriteLine("========================================\n");
                                    }
                                }
                                y++;
                                x++;
                            }
                            else
                            {
                                x++;
                            }
                        }
                    }
                    else if (urutan == 2)
                    {
                        int total = 0;
                        foreach (int i in IDbuku)
                        {
                            if (i > 0)
                            {
                                total++;
                            }
                        }
                        string[] JudulBuku = new string[total];
                        int count = 0;
                        int x = 0;
                        foreach (int i in IDbuku)
                        {
                            if (i > 0)
                            {
                                string idbook = IDbuku[x].ToString();
                                for (int j = 0; j < IDbuku.Length; j++)
                                {
                                    if (idbook == Katalog[j, 0, 0])
                                    {
                                        JudulBuku[count] = Katalog[j, 0, 1];
                                        count++;
                                    }
                                }
                                x++;
                            }
                            else
                            {
                                x++;
                            }
                        }
                        Array.Sort(JudulBuku);
                        Console.WriteLine("========================================");
                        Console.WriteLine("======== Data Hasil Pengurutan =========");
                        Console.WriteLine("========================================");
                        for (int i = 0; i < JudulBuku.Length; i++)
                        {
                            for (int j = 0; j < IDbuku.Length; j++)
                            {
                                if (JudulBuku[i] == Katalog[j, 0, 1])
                                {
                                    Console.WriteLine("Data Buku -{0}", i + 1);
                                    Console.WriteLine("\tJudul Buku : {0}", Katalog[j, 0, 1]);
                                    Console.WriteLine("\tID Buku : {0}", Katalog[j, 0, 0]);
                                    Console.WriteLine("\tPenerbit : {0}", Katalog[j, 0, 2]);
                                    Console.WriteLine("========================================\n");
                                }
                            }
                        }
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
