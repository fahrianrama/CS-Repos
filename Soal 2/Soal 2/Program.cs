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
            Random rand = new Random();
            int ukuran = 0;
            Console.Write("Masukkan ukuran : ");
            ukuran = Convert.ToInt32(Console.ReadLine());
            int adder = 0;
            if (ukuran % 2 == 0)
            {
                adder = 0;
            }
            else
            {
                adder = 1;
            }
            int a = 0, b = ukuran * 2 - 2, c = ukuran * 2 - 2, d = ukuran *4 - 4;
            int number = 0;
            
            for (int j = 0; j < ukuran; j++)
            {
                bool verif = false;
                for (int i = 0; i < ukuran * 4 - 3; i++)
                {
                    if (i == a || i == b || i == c || i == d)
                    {
                        while (verif == false)
                        {
                            number = rand.Next(0, 10);
                            if(number%2 == adder)
                            {
                                verif = true;
                            }
                        }
                        Console.Write("{0}", number);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    verif = false;
                }
                a++;
                b--;
                c++;
                d--;
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

