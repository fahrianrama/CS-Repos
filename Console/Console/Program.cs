using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai : ");
            int height = int.Parse(Console.ReadLine());
            while (height < 2)
            {
                Console.WriteLine("Nilai minimal 2!");
                Console.Write("Masukkan nilai : ");
                height = int.Parse(Console.ReadLine());
            }
                int i, j, counter = height / 2;
                for (i = 0; i < height; i++)
                {
                    Console.Write("*");
                    for (j = 0; j <= height; j++)
                    {
                        if (j == height)
                            Console.Write("*");
                        else if ((i >= height / 2)
                                && (j == counter
                                || j == height - counter - 1))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    if (i >= height / 2)
                    {
                        counter++;
                    }
                    Console.Write("\n");
                }
            Console.ReadKey();
        }
    }
}
