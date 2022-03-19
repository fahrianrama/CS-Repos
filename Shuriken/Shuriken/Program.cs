using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuriken
{
    class Program
    {
        static void Main(string[] args)
        {
            int triple = 0;
            Console.Write("Masukkan panjang : ");
            int panjang = int.Parse(Console.ReadLine());
            int posisi = panjang * 4;
            int posisi2 = panjang * 4;
            int posisi3 = panjang * 4;
            int posisibintang = panjang + panjang - 3;
            int bintang = panjang * 4-1;
            int bintang2 = panjang * 4+1;
            for (int i=0; i<panjang*4-1; i++)
            {
                for(int j=0; j<panjang*8+1; j++)
                {
                    if (j == posisi || j == posisi2)
                    {
                        Console.Write("*");
                    }
                    else if (i >= posisibintang )
                    {
                        if (i<=posisibintang + 4)
                        {
                            if (j == bintang || j == bintang2)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                if (i >= posisibintang)
                {
                    if (i <= posisibintang + 1)
                    {
                        if (i == posisibintang + 1)
                        {
                            bintang--;
                            bintang2++;
                        }
                        else
                        {
                            bintang -= 2;
                            bintang2 += 2;
                        }
                        
                    }
                    else
                    {
                        if (i == posisibintang + 2)
                        {
                            bintang++;
                            bintang2--;
                        }
                        else
                        {
                            bintang += 2;
                            bintang2 -= 2;
                        }
                        
                    }
                }
                Console.WriteLine("");
                if (i >= panjang-1)
                {
                    if (i>=panjang*2-1)
                    {
                        if (i < panjang * 2 + triple - 1)
                        {
                            posisi += 3;
                            posisi2 -= 3;
                        }
                        else if (i<panjang*3-1)
                        {
                            posisi += 2;
                            posisi2 -= 2;
                        }
                        else
                        {
                            posisi++;
                            posisi2--;
                        }
                    }
                    else
                    {
                        if (i < panjang+1)
                        {
                            posisi -= 2;
                            posisi2 += 2;
                        }
                        else
                        {
                            posisi -= 3;
                            posisi2 += 3;
                            triple++;
                        }
                    }
                }
                else
                {
                    posisi--;
                    posisi2++;
                }
            }
            Console.ReadKey();
        }
    }
}
