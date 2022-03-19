using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string yakin = "Z";
            int jumlah_mhs, i, posisi = 1, total = 0;
            ArrayList nim = new ArrayList();
            ArrayList nama = new ArrayList();
            ArrayList nilai = new ArrayList();

            checkpoint:
            Console.Clear();

            Console.Write("Input Jumlah Mahasiswa = ");
            jumlah_mhs = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("INPUT DATA");
            Console.WriteLine("==========");

            for (i = 0; i < jumlah_mhs; i++)
            {
                Console.WriteLine("Mahasiswa ke " + posisi);
                Console.WriteLine("----------------");
                Console.Write("NIM = ");
                nim.Add(Console.ReadLine());
                Console.Write("Nama = ");
                nama.Add(Console.ReadLine());
                Console.Write("Nilai = ");
                int nilaipos = int.Parse(Console.ReadLine());
                nilai.Add(nilaipos);
                total += nilaipos;
                posisi++;
            }
            
            while(yakin!="N")
            {
                Console.Write("Apakah Masih Ada Data (Y/N) = ");
                yakin = Console.ReadLine();
                if (yakin == "Y")
                {
                    goto checkpoint;
                }
            }

            Console.Clear();
            Console.WriteLine("OUTPUT DATA");
            Console.WriteLine("==========");

            for (i = 0; i < jumlah_mhs+1; i++)
            {
                Console.WriteLine("Mahasiswa ke {0}", i+1);
                Console.WriteLine("----------------");
                Console.WriteLine("NIM = " + nim[i]);
                Console.WriteLine("Nama = " + nama[i]);
                Console.WriteLine("Nilai = " + nilai[i]);
            }

            Console.WriteLine("\nJumlah Nilai = " + total);
            Console.WriteLine("Jumlah Mahasiswa = " + nim.Count);
            Console.WriteLine("Rata - Rata = " + (total / nim.Count));

            Console.ReadKey();
        }
    }
}
