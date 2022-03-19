using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Checker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program asik ihiy");
            int[] bilangan = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Masukkan bilangan ke-{0} : ", i + 1);
                int bil = int.Parse(Console.ReadLine());
                bilangan[i] = bil;
            }
            int menu = 0;
            while (menu != 4)
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Angka ke-{0} : {1}", i + 1, bilangan[i]);
                }
                Console.WriteLine("MENU PROGRAM");
                Console.WriteLine("1. Tampilkan bilangan terbesar");
                Console.WriteLine("2. Tampilkan bilangan terkecil");
                Console.WriteLine("3. Tampilkan rata-rata bilangan");
                Console.WriteLine("4. Exit");
                Console.Write("Input menu : ");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    int max = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        if (max < bilangan[i])
                        {
                            max = bilangan[i];
                        }
                    }
                    Console.WriteLine("Bilangan terbesar : {0}", max);
                }
                else if (menu == 2)
                {
                    int min = 100;
                    for (int i = 0; i < 5; i++)
                    {
                        if (min > bilangan[i])
                        {
                            min = bilangan[i];
                        }
                    }
                    Console.WriteLine("Bilangan terkecil : {0}", min);
                }
                else if (menu == 3)
                {
                    int total = 0;
                    int jumlah = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        total += bilangan[i];
                        jumlah += 1;
                    }
                    double rata = Convert.ToDouble(total) / Convert.ToDouble(jumlah);
                    Console.WriteLine("Rata - rata : {0}", rata);
                }
                Console.ReadLine();
            }
        }
    }
}
