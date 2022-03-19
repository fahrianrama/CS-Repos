using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laprak1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            bool ulang = true;
            Console.WriteLine("A = {0}, B = {1}", a, b);
            while(ulang == true)
            {
                if (a == b)
                {
                    Console.WriteLine("A sama dengan B\n");
                    a += 1;
                    Console.WriteLine("A ditambah 1");
                    Console.WriteLine("A = {0}, B = {1}", a, b);
                }
                else if (a > b)
                {
                    Console.WriteLine("A lebih dari B\n");
                    b += 2;
                    Console.WriteLine("B ditambah 2");
                    Console.WriteLine("A = {0}, B = {1}", a, b);
                }
                else if (a < b)
                {
                    Console.WriteLine("A kurang dari B");
                    ulang = false;
                }
            }
            Console.ReadKey();
            
            
        }
    }
}
