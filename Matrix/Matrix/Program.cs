using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static int Determinan(int[,] a)
        {
            return a[0, 0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * a[2, 0] + a[0, 2] * a[1, 0] * a[2, 1] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 0] * a[1, 2] * a[2, 1] - a[0, 1] * a[1, 0] * a[2, 2];
        }
        static void Cofactor(int[,] a,int determinan)
        {
            int i, j, count = 0;
            float [,] kofaktor = new float [30, 30];
            float[,] kofaktortrans = new float[30, 30];

            kofaktor[0, 0] = (float)(a[1, 1] * a[2, 2] - a[1, 2] * a[2, 1]) ;
            kofaktor[0, 1] = (float)(a[1, 0] * a[2, 2] - a[1, 2] * a[2, 0]) ;
            kofaktor[0, 2] = (float)(a[1, 0] * a[2, 1] - a[1, 1] * a[2, 0]) ;
            kofaktor[1, 0] = (float)(a[0, 1] * a[2, 2] - a[0, 2] * a[2, 1]) ;
            kofaktor[1, 1] = (float)(a[0, 0] * a[2, 2] - a[0, 2] * a[2, 0]) ;
            kofaktor[1, 2] = (float)(a[0, 0] * a[2, 1] - a[0, 1] * a[2, 0]) ;
            kofaktor[2, 0] = (float)(a[0, 1] * a[1, 2] - a[0, 2] * a[1, 1]) ;
            kofaktor[2, 1] = (float)(a[0, 0] * a[1, 2] - a[0, 2] * a[1, 0]) ;
            kofaktor[2, 2] = (float)(a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0]) ;

            Console.WriteLine("Inverse Matrix : ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (count % 2 == 1)
                    {
                        kofaktortrans[i, j] = kofaktor[i, j] * -1;
                    }
                    else
                    {
                        kofaktortrans[i, j] = kofaktor[i, j];
                    }
                    count+=1;
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    kofaktor[j, i] = kofaktortrans[i, j]/determinan;

                }
            }

            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", kofaktor[i, j]);
            }
        }
        static void Main(string[] args)
        {
            int i, j;
            int[,] matrix = new int[30, 30];
            int[,] transpose = new int[30, 30];
 
            Console.Write("Input matrix 3x3! : \n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Kolom {0}, Baris {1} : ", j+1, i+1);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            
            char ulang = 'y';
            while (ulang == 'y')
            {
                Console.Clear();
                Console.WriteLine("Matrix 3x3 : ");
                for (i = 0; i < 3; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < 3; j++)
                        Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine("\nMenu\n1. Transpose Matrix\n2. Invers Matrix\n3. Determinan Matrix");
                Console.Write("Input : ");
                int menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (menu == 1)
                {
                    
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            transpose[j, i] = matrix[i, j];
                        }
                    }
                    Console.Write("\n\nTranspose Matrix : ");
                    for (i = 0; i < 3; i++)
                    {
                        Console.Write("\n");
                        for (j = 0; j < 3; j++)
                        {
                            Console.Write("{0}\t", transpose[i, j]);
                        }
                    }
                    Console.Write("\n\n");
                }
                else if (menu == 2)
                {
                    int det = Determinan(matrix);
                    Cofactor(matrix,det);
                    Console.WriteLine("");
                }
                else if(menu == 3)
                {
                    Console.WriteLine("Determinan : {0}",Determinan(matrix));
                }
                Console.Write("Ulang (y)/(n)?");
                ulang = Console.ReadLine()[0];
            }

            Console.Clear();
        }
    }
}
