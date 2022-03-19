using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buku_Kas
{
    class Program
    {
        static void Judul()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("======== Program Kas X Mipa 2 ========");
            Console.WriteLine("======================================");
        }

        public static void Main(string[] args)
        {
            int[] Uang = new int[40];
            string[,] Kas = new string[40, 2];
            int inputmenu = 0;
            int bayar = 20000;
            while (inputmenu != 5)
            {
                Judul();
                Console.WriteLine("Jumlah Siswa : {0}", Kas.Length / 2);
                Console.WriteLine("Jumlah Kas : Rp. {0}", bayar);
                Console.WriteLine("======================================");
                Console.WriteLine("Pilih Kegiatan : \n\t1. Status Pembayaran\n\t2. Input Pembayaran\n\t3. Cari Nama Siswa\n\t4. Transkrip Pembayaran\n\t5. Keluar");
                Console.WriteLine("======================================\n");
                inputmenu = int.Parse(Console.ReadLine());
                Console.Clear();
                if (inputmenu == 1)
                {
                    int total = 0;
                    int jumlah = 0;
                    int lunas = 0;
                    foreach (int i in Uang)
                    {
                        if (i > 0)
                        {
                            total += i;
                            jumlah++;
                            if (i >= bayar)
                            {
                                lunas++;
                            }
                        }
                    }

                    Judul();
                    Console.WriteLine("Jumlah Siswa : {0}", Kas.Length / 2);
                    Console.WriteLine("Jumlah Kas : Rp. {0}", bayar);
                    Console.WriteLine("Siswa Membayar : {0}", jumlah);
                    Console.WriteLine("Siswa Belum Membayar : {0}", Uang.Length - jumlah);
                    Console.WriteLine("Siswa Lunas : {0}", lunas);
                    Console.WriteLine("Total Pembayaran : {0}", total);
                }
                else if (inputmenu == 2)
                {
                    Judul();
                    int index = 0;
                    foreach (int i in Uang)
                    {
                        if (i > 0)
                        {
                            index++;
                        }
                    }
                    Console.WriteLine("Nama Siswa : ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Jumlah Pembayaran : ");
                    string setor = Console.ReadLine();
                    Uang[index] = int.Parse(setor);
                    Kas[index, 0] = nama;
                    Kas[index, 1] = setor;
                }
                else if (inputmenu == 3)
                {
                    Judul();
                    Console.WriteLine("Masukkan Nama Siswa : ");
                    string siswa = Console.ReadLine();
                    int status = 0;
                    for (int i = 0; i < Kas.Length / 2; i++)
                    {
                        if (siswa == Kas[i, 0])
                        {
                            status += Uang[i];
                        }
                    }
                    Console.WriteLine("Nama Siswa : {0}\nPembayaran Kas : {1}", siswa, status);
                }
                else if (inputmenu == 4)
                {
                    Judul();
                    int count = 1;
                    for (int a = 0; a < Uang.Length; a++)
                    {
                        if (Uang[a] > 0)
                        {
                            Console.WriteLine("Pembayaran ke-{0}", count);
                            Console.WriteLine("===========================================");
                            Console.WriteLine("Nama Siswa : {0}\nPembayaran Kas : {1}", Kas[a, 0], Uang[a]);
                            Console.WriteLine("===========================================");
                            count++;
                        }
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
