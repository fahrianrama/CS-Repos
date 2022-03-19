using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int jumlah = 5;
            string[] nama = new string[jumlah];
            string[] alamat = new string[jumlah];

            for (int i = 0; i < jumlah; i++)
            {
                char same = 'y';
                while (same == 'y')
                {
                    same = 'n';
                    Console.Write("Nama {0} : ", i + 1);
                    string namainput = Console.ReadLine();
                    for (int j = 0; j < i; j++)
                    {
                        if (nama[j] == namainput)
                        {
                            same = 'y';
                        }
                    }
                    if (same != 'y')
                    {
                        Console.Write("Alamat : ");
                        string alamatinput = Console.ReadLine();
                        nama[i] = namainput;
                        alamat[i] = alamatinput;
                    }
                    else
                    {
                        Console.WriteLine("Nama sudah ada!");
                    }
                }
            }
            char cari = 'y';
            while (cari == 'y')
            {
                Console.Write("==> Cari nama : ");
                string namacari = Console.ReadLine();
                for (int j = 0; j < jumlah; j++)
                {
                    if (nama[j] == namacari)
                    {
                        Console.WriteLine("Alamat : {0}", alamat[j]);
                    }
                }
                Console.Write("Cari lagi? (y/n) : ");
                cari = Console.ReadKey().KeyChar;
                Console.WriteLine("");
            }
        }
    }
}
