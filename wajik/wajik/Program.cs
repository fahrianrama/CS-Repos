using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wajik
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool lanjut = false;
            int ukuran = 0;
            while (lanjut == false)
            {
                Console.Write("Masukkan panjang : ");
                ukuran = Convert.ToInt32(Console.ReadLine());
                if (ukuran % 2 == 0 || ukuran < 1)
                {
                    Console.WriteLine("Ukuran Salah!");
                    lanjut = false;
                }
                else
                {
                    lanjut = true;
                }
            }
            if (lanjut == true)
            {
                int tengah = ukuran / 2 + 1;
                int count = tengah - 1;
                for (int j = 1; j <= tengah; j++)
                {
                    for (int i = 1; i <= count; i++)
                    {
                        Console.Write(" ");
                    }
                    count--;
                    for (int i = 1; i <= 2 * j - 1; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                count = 1;
                for (int j = 1; j <= tengah - 1; j++)
                {
                    for (int i = 1; i <= count; i++)
                    {
                        Console.Write(" ");
                    }
                    count++;
                    for (int i = 1; i <= 2 * (tengah - j) - 1; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
