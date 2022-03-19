using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih = 0;
            while (pilih != 4)
            {
                Console.WriteLine("Pilih Menu :");
                Console.WriteLine("1. Cek Palindrom");
                Console.WriteLine("2. Transkrip Nilai");
                Console.WriteLine("3. Kartu Keluarga");
                Console.WriteLine("4. Selesai/Keluar");
                pilih = int.Parse(Console.ReadLine());
                if (pilih == 1)
                {
                    string kata, reverse = string.Empty;
                    Console.Write("Masukkan kata : ");
                    kata = Console.ReadLine();
                    if (kata != null)
                    {
                        for (int i = kata.Length - 1; i >= 0; i--)
                        {
                            reverse += kata[i].ToString();
                        }
                        if (reverse == kata)
                        {
                            Console.WriteLine("Kata {0} adalah Palindrome", kata);
                        }
                        else
                        {
                            Console.WriteLine("Kata {0} bukan Palindrome", kata);
                        }
                    }
                    Console.ReadLine();
                }
                else if (pilih == 2)
                {
                    string[,,] nilai = new string[6, 1, 3];
                    Console.WriteLine("Masukkan NIM : ");
                    int nim = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukkan Nama : ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Masukkan Kelas : ");
                    string kelas = Console.ReadLine();
                    Console.WriteLine("---------------------");
                    for (int i = 0; i < nilai.GetLength(0); i++)
                    {
                        Console.WriteLine("Masukkan Nama Mata Kuliah : ");
                        string matkul = Console.ReadLine();
                        nilai[i, 0, 0] = matkul;
                        Console.WriteLine("Masukkan Nilai Angka : ");
                        string angka = Console.ReadLine();
                        nilai[i, 0, 1] = angka;
                        Console.WriteLine("Masukkan Nilai Huruf : ");
                        string huruf = Console.ReadLine();
                        nilai[i, 0, 2] = huruf;
                    }
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Transkrip Kuliah");
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine("NIM : {0}", nim);
                    Console.WriteLine("Nama : {0}", nama);
                    Console.WriteLine("Kelas : {0}", kelas);
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine("Transkrip Mahasiswa dengan NIM : {0}", nim);
                    Console.WriteLine("Mata Kuliah\tNilai Angka\tNilai Huruf");
                    for (int i = 0; i < nilai.GetLength(0); i++)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", nilai[i, 0, 0], nilai[i, 0, 1], nilai[i, 0, 2]);
                    }
                    Console.ReadLine();
                }
                else if (pilih == 3)
                {
                    Console.WriteLine("Masukkan Jumlah Anggota Keluarga : ");
                    int jumlah = int.Parse(Console.ReadLine());
                    string[,,] keluarga = new string[jumlah, 1, 3];
                    for (int i = 0; i < keluarga.GetLength(0); i++)
                    {
                        Console.WriteLine("Masukkan Nama Lengkap : ");
                        string namalengkap = Console.ReadLine();
                        keluarga[i, 0, 0] = namalengkap;
                        Console.WriteLine("Masukkan Pendidikan Terakhir : ");
                        string pendidikan = Console.ReadLine();
                        keluarga[i, 0, 1] = pendidikan;
                        Console.WriteLine("Masukkan Status : ");
                        string status = Console.ReadLine();
                        keluarga[i, 0, 2] = status;
                    }
                    Console.WriteLine("\nData Kartu Keluarga");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Nama Lengkap\tPendidikan Terakhir\tStatus");
                    for (int i = 0; i < keluarga.GetLength(0); i++)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", keluarga[i, 0, 0], keluarga[i, 0, 1], keluarga[i, 0, 2]);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
