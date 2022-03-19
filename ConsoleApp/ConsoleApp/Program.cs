using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka1, angka2;
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Pilih angka : ");
            int angka = int.Parse(Console.ReadLine());
            if (angka == 1)
            {
                Console.Write("Masukkan angka pertama : ");
                angka1 = int.Parse(Console.ReadLine());
                Console.Write("Masukkan angka kedua : ");
                angka2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angka1 + angka2);
            }
            else if(angka == 2)
            {
                Console.Write("Masukkan angka pertama : ");
                angka1 = int.Parse(Console.ReadLine());
                Console.Write("Masukkan angka kedua : ");
                angka2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angka1 - angka2);
            }
            else if (angka == 3)
            {
                Console.Write("Masukkan angka pertama : ");
                angka1 = int.Parse(Console.ReadLine());
                Console.Write("Masukkan angka kedua : ");
                angka2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angka1 * angka2);
            }
            else if (angka == 4)
            {
                Console.Write("Masukkan angka pertama : ");
                float angkapertama = int.Parse(Console.ReadLine());
                Console.Write("Masukkan angka kedua : ");
                float angkakedua = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angkapertama/angkakedua);
            }
            else
            {
                Console.WriteLine("Menu tidak tersedia");
            }
            Console.ReadKey();
        }
    }
}
