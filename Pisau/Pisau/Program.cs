using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisau
{
    class Program
    {
        static void Main(string[] args)
        {
            int posisi = 0;
            int panjang = 0;
            while (panjang < 4)
            {
                Console.Write("Masukkan panjang pisau : ");
                panjang = int.Parse(Console.ReadLine());
                if (panjang < 4)
                {
                    Console.WriteLine("Pisau terlalu pendek");
                }
            }
            for (int i=0; i < panjang * 3; i++)
            {
                if (i == panjang * 2 - 1)
                {
                    for (int j = 0; j < panjang; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 0; j < panjang; j++)
                    {
                        if (j == 0 || j == posisi)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine("");
                if (i < panjang-1)
                {
                    posisi++;
                }
                if (i == panjang * 2 - 1)
                {
                    posisi = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
