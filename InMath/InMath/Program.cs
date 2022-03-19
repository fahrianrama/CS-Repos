using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int bangun = 0;
            int pilmenu = 0;
            while (pilmenu != 3)
            {
                double hasil = 0;
                Console.WriteLine("======================================================");
                Console.WriteLine("======== Selamat Datang di Aplikasi InMath !! ========");
                Console.WriteLine("==== Sarana Belajar Bangun Datar dan Bangun Ruang ====");
                Console.WriteLine("======================================================");
                Console.WriteLine("================ Pilih Jenis Rumus : =================");
                Console.WriteLine("=============== 1. Luas Bangun Datar =================");
                Console.WriteLine("============== 2. Volume Bangun Ruang ================");
                Console.WriteLine("==================== 3. Keluar =======================");
                Console.WriteLine("======================================================");
                Console.WriteLine("Pilihan : ");
                pilmenu = int.Parse(Console.ReadLine());
                Console.Clear();
                if (pilmenu == 1)
                {
                    Console.WriteLine("Beri Nama Bangun Datar Ini : ");
                    string nama = Console.ReadLine();
                    while (bangun != 9)
                    {
                        Console.Clear();
                        Console.WriteLine("======================================================");
                        Console.WriteLine("============= Pilih Jenis Bangun Datar : =============");
                        Console.WriteLine("==================== 1. Persegi ======================");
                        Console.WriteLine("================ 2. Persegi Panjang ==================");
                        Console.WriteLine("=================== 3. Segitiga ======================");
                        Console.WriteLine("================== 4. Trapesium ======================");
                        Console.WriteLine("================ 5. Jajar Genjang ====================");
                        Console.WriteLine("================ 6. Layang Layang ====================");
                        Console.WriteLine("================ 7. Belah Ketupat ====================");
                        Console.WriteLine("================== 8. Lingkaran ======================");
                        Console.WriteLine("==================== 9. Keluar =======================");
                        Console.WriteLine("======================================================");
                        Console.WriteLine("Pilihan : ");
                        bangun = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (bangun == 1)
                        {
                            Console.WriteLine("Masukkan Panjang Sisi Persegi : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, sisiA, 0);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        else if (bangun == 2)
                        {
                            Console.WriteLine("Masukkan Panjang : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Lebar : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        else if (bangun == 3)
                        {
                            Console.WriteLine("Masukkan Alas : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        else if (bangun == 4)
                        {
                            Console.WriteLine("Masukkan Panjang Sisi Atas : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Panjang Sisi Bawah : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiC = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, sisiB, sisiC);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        else if (bangun == 5)
                        {
                            Console.WriteLine("Masukkan Alas : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        else if (bangun == 6)
                        {
                            Console.WriteLine("Masukkan Panjang Diagonal 1 : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Panjang Diagonal 2 : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        else if (bangun == 7)
                        {
                            Console.WriteLine("Masukkan Panjang Diagonal 1 : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Panjang Diagonal 2 : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        else if (bangun == 8)
                        {
                            Console.WriteLine("Masukkan Jari Jari : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            BangunDatar bangunku = new BangunDatar(bangun, sisiA, 0, 0);
                            hasil = bangunku.Luas();
                            Console.WriteLine("Luas {0} adalah : {1} cm^2", nama, hasil);
                        }
                        System.Console.ReadKey();
                        Console.Clear();
                    }

                }
                else if (pilmenu == 2)
                {
                    Console.WriteLine("Beri Nama Bangun Ruang Ini : ");
                    string nama = Console.ReadLine();
                    while (bangun != 8)
                    {
                        Console.Clear();
                        Console.WriteLine("======================================================");
                        Console.WriteLine("============ Pilih Jenis Bangun Ruang : ==============");
                        Console.WriteLine("==================== 1. Kubus ========================");
                        Console.WriteLine("==================== 2. Balok ========================");
                        Console.WriteLine("================= 3. Limas Segi 3 ====================");
                        Console.WriteLine("==================== 4. Prisma =======================");
                        Console.WriteLine("==================== 5. Tabung =======================");
                        Console.WriteLine("==================== 6. Kerucut ======================");
                        Console.WriteLine("==================== 7. Bola =========================");
                        Console.WriteLine("==================== 8. Keluar =======================");
                        Console.WriteLine("======================================================");
                        Console.WriteLine("Pilihan : ");
                        bangun = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (bangun == 1)
                        {
                            Console.WriteLine("Masukkan Panjang Sisi Kubus : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            BangunRuang bangunku = new BangunRuang(bangun, sisiA, 0, 0);
                            hasil = bangunku.Volume();
                            Console.WriteLine("Volume {0} adalah : {1} cm^3", nama, hasil);
                        }
                        else if (bangun == 2)
                        {
                            Console.WriteLine("Masukkan Panjang : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Lebar : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiC = int.Parse(Console.ReadLine());
                            BangunRuang bangunku = new BangunRuang(bangun, sisiA, sisiB, sisiC);
                            hasil = bangunku.Volume();
                            Console.WriteLine("Volume {0} adalah : {1} cm^3", nama, hasil);
                        }
                        else if (bangun == 3)
                        {
                            Console.WriteLine("Masukkan Luas Alas : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunRuang bangunku = new BangunRuang(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Volume();
                            Console.WriteLine("Volume {0} adalah : {1} cm^3", nama, hasil);
                        }
                        else if (bangun == 4)
                        {
                            Console.WriteLine("Masukkan Luas Alas : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunRuang bangunku = new BangunRuang(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Volume();
                            Console.WriteLine("Volume {0} adalah : {1} cm^3", nama, hasil);
                        }
                        else if (bangun == 5)
                        {
                            Console.WriteLine("Masukkan Jari Jari : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunRuang bangunku = new BangunRuang(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Volume();
                            Console.WriteLine("Volume {0} adalah : {1} cm^3", nama, hasil);
                        }
                        else if (bangun == 6)
                        {
                            Console.WriteLine("Masukkan Jari Jari : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukkan Tinggi : (cm)");
                            int sisiB = int.Parse(Console.ReadLine());
                            BangunRuang bangunku = new BangunRuang(bangun, sisiA, sisiB, 0);
                            hasil = bangunku.Volume();
                            Console.WriteLine("Volume {0} adalah : {1} cm^3", nama, hasil);
                        }
                        else if (bangun == 7)
                        {
                            Console.WriteLine("Masukkan Jari Jari : (cm)");
                            int sisiA = int.Parse(Console.ReadLine());
                            BangunRuang bangunku = new BangunRuang(bangun, sisiA, 0, 0);
                            hasil = bangunku.Volume();
                            Console.WriteLine("Volume {0} adalah : {1} cm^3", nama, hasil);
                        }
                        System.Console.ReadKey();
                        Console.Clear();
                    }
                    Console.Clear();
                }
            }
        }
    }
}
