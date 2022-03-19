using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Nama Anda : ");
            string nama_sim = Console.ReadLine();
            int usia = 6;
            int pendidikan = 0;
            int sta_meter = 100;
            string kondisi = "Baik";
            int uang = 0;
            Console.WriteLine("Selamat datang {0} pada simulasi kehidupan, anda sekarang berumur {1} tahun\nTingkat pendidikan : {2}\nStamina : {3} dengan kondisi {4}\nHarta : {5}\nApa yang akan anda lakukan? : ", nama_sim, usia, pendidikan, sta_meter, kondisi, uang);
            string ulangi = "y";
            do
            {
                Manusia user = new Manusia(nama_sim, usia, pendidikan, sta_meter, kondisi);
                Console.WriteLine("Pilih Kegiatan :");
                Console.WriteLine("1. Sekolah\n2. Kerja\n3. Istirahat");
                int kegiatan = int.Parse(Console.ReadLine());
                if (kegiatan == 1)
                {
                    user.Belajar();
                    if (pendidikan == 0)
                    {
                        usia += 6;
                    }
                    else if (pendidikan == 1)
                    {
                        usia += 3;
                    }
                    else if (pendidikan == 2)
                    {
                        usia += 3;
                    }
                    else if (pendidikan == 3)
                    {
                        usia += 4;
                    }
                    else if (pendidikan == 4)
                    {
                        usia += 2;
                    }
                    else
                    {
                        usia += 3;
                    }
                    sta_meter -= 20;
                    pendidikan++;
                }
                else if (kegiatan == 2)
                {
                    int gaji = user.Kerja();
                    uang += gaji;
                    sta_meter -= 10;
                    usia += 1;
                }
                else
                {
                    user.Istirahat();
                    sta_meter += 10;
                }
                if (sta_meter < 70)
                {
                    kondisi = "Sedang";
                    if (sta_meter < 40)
                    {
                        kondisi = "Buruk";
                        if (sta_meter == 0)
                        {
                            Console.WriteLine("Anda terlalu lelah hingga sakit");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                    }
                }
                Console.WriteLine("Anda sekarang berumur {0} tahun\nTingkat pendidikan : {1}\nStamina : {2} dengan kondisi {3}\nHarta : {4}", usia, pendidikan, sta_meter, kondisi, uang);
                Console.WriteLine("Lakukan kegiatan lain ? <y/n>");

                ulangi = Console.ReadLine();
            } while (ulangi == "y");
        }
    }
}
