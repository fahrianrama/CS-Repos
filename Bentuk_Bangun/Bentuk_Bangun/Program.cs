using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bentuk_Bangun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Butuh apa?");
            Console.WriteLine("1. Kapal");
            Console.WriteLine("2. Rumah");
            Console.Write("Nomor berapa : ");
            int nomor = int.Parse(Console.ReadLine());
            Console.Write("Ukuran Berapa : ");
            int ukuran = int.Parse(Console.ReadLine());
            
            if (nomor == 1)
            {
                int posisi = ukuran;
                int posisi2 = ukuran;
                for (int i = 0; i < ukuran; i++)
                {
                    for (int j = 0; j < ukuran * 2 + 1; j++)
                    {
                        if (j == posisi || j == posisi2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                    posisi--;
                    posisi2++;
                }
                posisi = 1;
                posisi2 = (ukuran * 2) - 1;
                for (int i = 0; i < 3; i++)
                {
                    for (int j=0; j<ukuran*2+1; j++)
                    {
                        if (j == posisi || j == posisi2)
                        {
                            Console.Write("*");
                        }
                        else if (j == ukuran)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                }
                posisi = 1;
                posisi2 = (ukuran * 2)-1;
                for (int i=0; i < ukuran; i++)
                {
                    for (int j=0; j<ukuran*2+1; j++)
                    {
                        if (j == posisi || j == posisi2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                    posisi++;
                    posisi2--;
                }
            }
            else if (nomor == 2)
            {
                int posisi = ukuran;
                int posisi2 = ukuran;
                int posisi3 = ukuran*3-1;
                int posisi4 = ukuran*3-1;
                for (int i = 0; i < ukuran; i++)
                {
                    for (int j = 0; j < ukuran * 4 + 1; j++)
                    {
                        if (j == posisi || j == posisi2 || j == posisi3 || j == posisi4)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                    posisi--;
                    posisi2++;
                    posisi3--;
                    posisi4++;
                }
                posisi = 1;
                posisi2 = (ukuran * 2) - 1;
                posisi3 = ukuran * 2;
                posisi4 = ukuran * 4-2;
                for (int i = 0; i < ukuran; i++)
                {
                    if (i == ukuran-1)
                    {
                        for (int j = 0; j < ukuran * 4 - 1; j++)
                        {
                            if (j == posisi || j == posisi2 || j == posisi3 || j == posisi4)
                            {
                                Console.Write("|");
                            }
                            else if (j == 0 || j == ukuran * 2)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("_");
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < ukuran * 4 + 1; j++)
                        {
                            if (j == posisi || j == posisi2 || j == posisi3 || j == posisi4)
                            {
                                Console.Write("|");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
