using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitung_Bangun
{
    class Program
    {
        static void hitung_persegi(int sisi, int pilihan)
        {
            if (pilihan == 1)
            {
                Console.WriteLine("Keliling persegi panjang adalah = " + (sisi * 4));
            }
            else
            {
                Console.WriteLine("Luas persegi panjang adalah = " + (sisi * sisi));
            }
        }
        static void hitung_segitiga(int alas, int tinggi, int pilihan)
        {
            if (pilihan == 1)
            {
                Console.WriteLine("Keliling segitiga adalah = " + (tinggi * 2 + alas));
            }
            else
            {
                Console.WriteLine("Luas segitiga adalah = " + (alas * tinggi) / 2);
            }
        }
        static void hitung_trapesium(int alas1, int alas2, int tinggi, int sisi, int pilihan)
        {
            if (pilihan == 1)
            {
                Console.WriteLine("Keliling trapesium adalah = " + (alas1 + alas2 + tinggi + sisi));
            }
            else
            {
                Console.WriteLine("Luas trapesium adalah = " + ((alas1 + alas2) * tinggi) / 2);
            }
        }
        static void hitungbelahketupat(int d1, int d2, int pilihan)
        {
            if (pilihan == 1)
            {
                Console.WriteLine("Keliling belah ketupat adalah = " + (d1 * 4));
            }
            else
            {
                Console.WriteLine("Luas belah ketupat adalah = " + ((d1 * d2) / 2));
            }
        }
        static void Main(string[] args)
        {
            int loop = 1;
            while (loop == 1)
            {
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Segitiga");
                Console.WriteLine("3. Trapesium");
                Console.WriteLine("4. Belah Ketupat");
                Console.WriteLine("Masukkan menu yang dipilih = ");
                int menu1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Pilihan : ");
                Console.WriteLine("1. Keliling");
                Console.WriteLine("2. Luas");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Yang ingin dihitung = ");
                int menu2 = int.Parse(Console.ReadLine());
                if (menu1 == 1)
                {
                    Console.WriteLine("Input sisi = ");
                    int sisi = int.Parse(Console.ReadLine());
                    if (menu2 == 1)
                    {
                        hitung_persegi(sisi, 1);
                    }
                    else if (menu2 == 2)
                    {
                        hitung_persegi(sisi, 2);
                    }
                    else
                    {
                        Console.WriteLine("Kembali");
                    }
                }
                else if (menu1 == 2)
                {
                    Console.WriteLine("Input alas = ");
                    int alas = int.Parse(Console.ReadLine());
                    if (menu2 == 1)
                    {
                        Console.WriteLine("Input sisi = ");
                        int sisi = int.Parse(Console.ReadLine());
                        hitung_segitiga(alas, sisi, 1);
                    }
                    else if (menu2 == 2)
                    {
                        Console.WriteLine("Input tinggi = ");
                        int tinggi = int.Parse(Console.ReadLine());
                        hitung_segitiga(alas, tinggi, 2);
                    }
                    else
                    {
                        Console.WriteLine("Kembali");
                    }
                }
                else if (menu1 == 3)
                {
                    Console.WriteLine("Input alas a = ");
                    int alas1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input alas b = ");
                    int alas2 = int.Parse(Console.ReadLine());

                    if (menu2 == 1)
                    {
                        Console.WriteLine("Input sisi a = ");
                        int sisi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input sisi b = ");
                        int sisi2 = int.Parse(Console.ReadLine());
                        hitung_trapesium(alas1, alas2, sisi1, sisi2, 1);
                    }
                    else if (menu2 == 2)
                    {
                        Console.WriteLine("Input tinggi = ");
                        int tinggi = int.Parse(Console.ReadLine());
                        hitung_trapesium(alas1, alas2, tinggi, tinggi, 2);
                    }
                    else
                    {
                        Console.WriteLine("Kembali");
                    }
                }
                else if (menu1 == 4)
                {
                    if (menu2 == 1)
                    {
                        Console.WriteLine("Input sisi = ");
                        int sisi = int.Parse(Console.ReadLine());
                        hitungbelahketupat(sisi, sisi, 1);
                    }
                    else if (menu2 == 2)
                    {
                        Console.WriteLine("Input diagonal 1 = ");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input diagonal 2 = ");
                        int d2 = int.Parse(Console.ReadLine());
                        hitungbelahketupat(d1, d2, 2);
                    }
                    else
                    {
                        Console.WriteLine("Kembali");
                    }

                }
                Console.WriteLine("Restart? click any keyboard");
                String restart = Console.ReadLine();
            }
        }
    }
}
