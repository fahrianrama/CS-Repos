using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Program
    {
        static int Jumlah(int a, int b)
        {
            return a + b;
        }
        static int Kurang(int a,int b)
        {
            return a - b;
        }
        static int Kali(int a, int b)
        {
            return a * b;
        }
        static Double Bagi(double a,double b)
        {
            return a / b;
        }
        static int Mod(int a,int b)
        {
            return a % b;
        }
        static Double Div(double a, double b)
        {
            return a / b;
        }
        static int Pangkat(int a, int b)
        {
            Console.Write("Masukkan banyak pangkat : ");
            int x = int.Parse(Console.ReadLine());
            int c = a;
            for (int i = 1; i < x; i++)
            {
                c *= a;
            }
            return c;
        }
        static Double Akar(int a)
        {
            return Math.Sqrt(a);
        }
        static int Faktorial (int a)
        {
            int x = Convert.ToInt32(a);
            int c = a;
            for (int i = 1; i < a; i++)
            {
                x -= 1;
                c *= x;
            }
            return c;
        }
        static Double Log (int a)
        {
            return Math.Log(a);
        }
        public static void Main(string[] args)
        {
            char ulang = 'y';
            while (ulang == 'y')
            {
                Console.Clear();
                Console.WriteLine("Kalkulator");
                Console.WriteLine("Silahkan pilih operator anda : ");
                Console.WriteLine("1. Penjumlahan (+)");
                Console.WriteLine("2. Pengurangan (-)");
                Console.WriteLine("3. Perkalian (x)");
                Console.WriteLine("4. Pembagian (/)");
                Console.WriteLine("5. Mod");
                Console.WriteLine("6. Div");
                Console.WriteLine("7. Pangkat ^");
                Console.WriteLine("8. Akar Pangkat 2");
                Console.WriteLine("9. Faktorial (!)");
                Console.WriteLine("10. Log");
                Console.Write("Pilih input anda : ");
                int menu = int.Parse(Console.ReadLine());
                int a = 0, b = 0, c = 0;
                double d = 0;
                if (menu < 7)
                {
                    Console.Write("Masukkan angka pertama : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan angka kedua : ");
                    b = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Masukkan angka : ");
                    a = int.Parse(Console.ReadLine());
                }
                if (menu == 1)
                {
                    c = Jumlah(a, b);
                }
                else if (menu == 2)
                {
                    c = Kurang(a, b);
                }
                else if (menu == 3)
                {
                    c = Kali(a, b);
                }
                else if (menu == 4)
                {
                    double x = Convert.ToDouble(a);
                    double y = Convert.ToDouble(b);
                    d = Bagi(x, y);
                }
                else if (menu == 5)
                {
                    c = Mod(a, b);
                }
                else if (menu == 6)
                {
                    d = Div(a, b);
                }
                else if (menu == 7)
                {
                    c = Pangkat(a, b);
                }
                else if (menu == 8)
                {
                    d = Akar(a);
                }
                else if (menu == 9)
                {
                    c = Faktorial(a);
                }
                else if (menu == 10)
                {
                    d = Log(a);
                }

                if (c > 0)
                {
                    Console.WriteLine("Hasilnya : {0}", c);
                }
                else
                {
                    Console.WriteLine("Hasilnya : {0}", d);
                }
                Console.Write("Apakah ingin menggunakan kalkulator lagi? (y/n) : ");
                ulang = Convert.ToChar(Console.ReadLine());
            }
            
        }
    }
}
