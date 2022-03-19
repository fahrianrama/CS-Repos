using System;
namespace Mamikos
{

    public class Kos
    {
        string jenis_kos;
        int periode;
        int biaya;

        public Kos(string ukuran, int lama_huni, int bayar)
        {
            jenis_kos = ukuran;
            periode = lama_huni;
            biaya = bayar;
        }

        public void Pesan()
        {
            if (jenis_kos == "big")
            {
                if (periode > 3)
                {
                    biaya = 600000 * periode;
                    biaya = biaya * 90 / 100;
                }
                else
                {
                    biaya = 600000 * periode;
                }
                Console.WriteLine("Biaya kos untuk kamar {0} dan jangka waktu {1} bulan adalah : {2} : ", jenis_kos, periode, biaya);
                Console.WriteLine("Konfirmasi pesanan? <y/t> : ");
                string konfir = Console.ReadLine();
                if (konfir == "y")
                {
                    Console.WriteLine("Terima kasih atas pesanannya, Kos akan disiapkan oleh pemilik");
                }
                else
                {
                    Console.WriteLine("Kos batal dipesan");
                }
            }
            else if (jenis_kos == "medium")
            {
                if (periode > 3)
                {
                    biaya = 400000 * periode;
                    biaya = biaya * 90 / 100;
                }
                else
                {
                    biaya = 400000 * periode;
                }
                Console.WriteLine("Biaya kos untuk kamar {0} dan jangka waktu {1} bulan adalah : {2} : ", jenis_kos, periode, biaya);
                Console.WriteLine("Konfirmasi pesanan? <y/t> : ");
                string konfir = Console.ReadLine();
                if (konfir == "y")
                {
                    Console.WriteLine("Terima kasih atas pesanannya, Kos akan disiapkan oleh pemilik");
                }
                else
                {
                    Console.WriteLine("Kos batal dipesan");
                }
            }
            else
            {
                if (periode > 3)
                {
                    biaya = 300000 * periode;
                    biaya = biaya * 90 / 100;
                }
                else
                {
                    biaya = 300000 * periode;

                    Console.WriteLine("Biaya kos untuk kamar {0} dan jangka waktu {1} bulan adalah : {2} : ", jenis_kos, periode, biaya);
                    Console.WriteLine("Konfirmasi pesanan? <y/t> : ");
                    string konfir = Console.ReadLine();
                    if (konfir == "y")
                    {
                        Console.WriteLine("Terima kasih atas pesanannya, Kos akan disiapkan oleh pemilik");
                    }
                    else
                    {
                        Console.WriteLine("Kos batal dipesan");
                    }
                }
            }
        }
    }

    public class Kontrakan
    {
        int kamar;
        int kamar_mandi;
        string tingkat;
        int biaya;

        public Kontrakan(int jumlah_kamar, int jumlah_km, string lantai2, int harga)
        {
            kamar = jumlah_kamar;
            kamar_mandi = jumlah_km;
            tingkat = lantai2;
            biaya = harga;
        }

        public void Pesan()
        {
            if (tingkat == "y")
            {
                biaya = kamar * 1500000 + kamar_mandi * 500000;
                biaya += 3000000;
                Console.WriteLine("Kontrakan dengan jumlah kamar : {0}, Jumlah kamar mandi : {1} dan bertingkat adalah : {2}.", kamar, kamar_mandi, biaya);
                Console.WriteLine("Konfirmasi pesanan? <y/t> : ");
                string konfir = Console.ReadLine();
                if (konfir == "y")
                {
                    Console.WriteLine("Terima kasih atas pesanannya, Kontrakan akan disiapkan oleh pemilik");
                }
                else
                {
                    Console.WriteLine("Kontrakan batal dipesan");
                }
            }
            else
            {
                biaya = kamar * 1500000 + kamar_mandi * 500000;
                Console.WriteLine("Kontrakan dengan jumlah kamar : {0}, Jumlah kamar mandi : {1} adalah : {2}.", kamar, kamar_mandi, biaya);
                Console.WriteLine("Konfirmasi pesanan? <y/t> : ");
                string konfir = Console.ReadLine();
                if (konfir == "y")
                {
                    Console.WriteLine("Terima kasih atas pesanannya, Kontrakan akan disiapkan oleh pemilik");
                }
                else
                {
                    Console.WriteLine("Kontrakan batal dipesan");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string lanjut = "y";
            while (lanjut == "y")
            {
                Console.WriteLine("Mamikos : Pesan Kos dan Kontrakan terbaik !\nPilih Menu : \n");
                Console.WriteLine("1. Pesan Kos\n2. Pesan Kontrakan\n");
                int menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Pilih ukuran kamar : (big/medium/small)");
                    string ukuran = Console.ReadLine();
                    Console.WriteLine("Masukkan lama menghuni (bulan) : (lebih dari 3 bulan diskon 10%)");
                    int lama_huni = int.Parse(Console.ReadLine());
                    Kos kosan = new Kos(ukuran, lama_huni, 0);
                    kosan.Pesan();
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Pilih Jumlah kamar : ");
                    int jumlah_kamar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pilih Jumlah kamar mandi : ");
                    int jumlah_km = int.Parse(Console.ReadLine());
                    Console.WriteLine("Apakah anda mencari rumah bertingkat? <y/t> : ");
                    string lantai2 = Console.ReadLine();
                    Kontrakan kontrak = new Kontrakan(jumlah_kamar, jumlah_km, lantai2, 0);
                    kontrak.Pesan();
                }

                Console.WriteLine("Apakah Anda Ingin Mengulang? <y/n> : ");

                lanjut = Console.ReadLine();
            }
        }
    }
}