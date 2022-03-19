using System;
namespace Gajian
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nama_karyawan;
            string[] divisi_karyawan;
            int[] gaji_karyawan;

            Console.WriteLine("Masukkan banyak karyawan yang ada : ");
            int total = int.Parse(Console.ReadLine());
            nama_karyawan = new string[total];
            divisi_karyawan = new string[total];
            gaji_karyawan = new int[total];

            string ulang = "ya";
            while (ulang == "ya")
            {
                Console.WriteLine("Pilih Menu :");
                Console.WriteLine("1. Hitung Gaji");
                Console.WriteLine("2. Input Data");
                Console.WriteLine("3. Show Data");
                int pilih = int.Parse(Console.ReadLine());
                if (pilih == 1)
                {
                    Console.WriteLine("Masukkan Nama Karyawan : ");
                    string id = Console.ReadLine();
                    Console.WriteLine("Masukkan Divisi Karyawan : \n  produksi\n  pemasaran\n  umum");
                    string bagian = Console.ReadLine();
                    Console.WriteLine("Masukkan Lama Kerja (tahun) : ");
                    int tahun = int.Parse(Console.ReadLine());
                    Karyawan karyawanku = new Karyawan(id, bagian, tahun, 0);
                    karyawanku.Hitung();
                }
                else if (pilih == 2)
                {
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine("Masukkan Nama Karyawan : ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Masukkan Divisi Karyawan : \n  produksi\n  2. pemasaran\n  3. umum");
                        string bagian = Console.ReadLine();
                        Console.WriteLine("Masukkan Lama Kerja (tahun) : ");
                        int tahun = int.Parse(Console.ReadLine());
                        Karyawan karyawanku = new Karyawan(id, bagian, tahun, 0);
                        int hasil = karyawanku.Hitung();
                        nama_karyawan[i] = id;
                        divisi_karyawan[i] = bagian;
                        gaji_karyawan[i] = hasil;
                    }
                }
                else
                {
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine("Nama : " + nama_karyawan[i] + "\nDivisi : " + divisi_karyawan[i] + "\nGaji : " + gaji_karyawan[i]);
                    }
                }
            Console.WriteLine("Ulangi menu? (ya/tidak)");

            ulang = Console.ReadLine();
            }
        }
    }
}