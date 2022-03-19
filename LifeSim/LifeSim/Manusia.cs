using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSim
{
    class Manusia
    {
        public string nama;
        public int umur;
        public int tingkat = 0;
        public int stamina;
        public string kesehatan;

        public void Belajar()
        {
            if (tingkat < 7)
            {
                Console.WriteLine("Anda belajar dengan tekun dan naik tingkat");
                tingkat += 1;
                if (tingkat == 1)
                {
                    Console.WriteLine("Anda Menempuh SD");
                }
                else if (tingkat == 2)
                {
                    Console.WriteLine("Anda Menempuh SMP");
                }
                else if (tingkat == 3)
                {
                    Console.WriteLine("Anda Menempuh SMA");
                }
                else if (tingkat == 4)
                {
                    Console.WriteLine("Anda Menempuh S1");
                }
                else if (tingkat == 5)
                {
                    Console.WriteLine("Anda Menempuh S2");
                }
                else if (tingkat == 6)
                {
                    Console.WriteLine("Anda Menempuh S3");
                }
            }
            else
            {
                Console.WriteLine("Anda sudah pada tingkat tertinggi");
            }
        }
        public int Kerja()
        {
            if (tingkat == 0)
            {
                Console.WriteLine("Anda tidak dapat bekerja tanpa pendidikan apapun");
                return 0;
            }
            else if (tingkat == 1)
            {
                Random uang = new Random();
                int hasil = uang.Next(100000, 300000);
                Console.WriteLine("Anda bekerja dengan giat dan mendapatkan Uang sebesar Rp{0}", hasil);
                return hasil;
            }
            else if (tingkat == 2)
            {
                Random uang = new Random();
                int hasil = uang.Next(300000, 500000);
                Console.WriteLine("Anda bekerja dengan giat dan mendapatkan Uang sebesar Rp{0}", hasil);
                return hasil;
            }
            else if (tingkat == 3)
            {
                Random uang = new Random();
                int hasil = uang.Next(500000, 1000000);
                Console.WriteLine("Anda bekerja dengan giat dan mendapatkan Uang sebesar Rp{0}", hasil);
                return hasil;
            }
            else if (tingkat == 4)
            {
                Random uang = new Random();
                int hasil = uang.Next(1000000, 4000000);
                Console.WriteLine("Anda bekerja dengan giat dan mendapatkan Uang sebesar Rp{0}", hasil);
                return hasil;
            }
            else if (tingkat == 5)
            {
                Random uang = new Random();
                int hasil = uang.Next(4000000, 10000000);
                Console.WriteLine("Anda bekerja dengan giat dan mendapatkan Uang sebesar Rp{0}", hasil);
                return hasil;
            }
            else
            {
                Random uang = new Random();
                int hasil = uang.Next(1000000, 20000000);
                Console.WriteLine("Anda bekerja dengan giat dan mendapatkan Uang sebesar Rp{0}", hasil);
                return hasil;
            }

        }
        public void Istirahat()
        {
            Console.WriteLine("Anda beristirahat dan memulihkan 10 stamina");
        }
        public Manusia(string nama_sim, int usia, int pendidikan, int sta_meter, string kondisi)
        {
            nama = nama_sim;
            umur = usia;
            tingkat = pendidikan;
            stamina = sta_meter;
            kesehatan = kondisi;
        }
    }
}
