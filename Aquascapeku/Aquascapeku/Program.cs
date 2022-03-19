using System;
namespace Aquascape
{

    public class Ikan
    {
        public string Judul = "Ikan Hias";
        int ikan_beli;
        int jumlah;
        public void Isi()
        {
            if (ikan_beli == 1)
            {
                Console.WriteLine("Anda ingin memasukkan ikan Koi dengan jumlah : {0}? <ya/tidak> : ", jumlah);
                string tentu = Console.ReadLine();
                if (tentu == "ya")
                {
                    Console.WriteLine("{0} Ikan Koi Ditambahkan ke aquascape", jumlah);
                }
                else
                {
                    Console.WriteLine("Ikan batal dimasukkan");
                }
            }
            else if (ikan_beli == 2)
            {
                Console.WriteLine("Anda ingin memasukkan ikan Guppy dengan jumlah : {0}? <ya/tidak> : ", jumlah);
                string tentu = Console.ReadLine();
                if (tentu == "ya")
                {
                    Console.WriteLine("{0} Ikan Guppy Ditambahkan ke aquascape", jumlah);
                }
                else
                {
                    Console.WriteLine("Ikan batal dimasukkan");
                }
            }
            else if (ikan_beli == 3)
            {
                Console.WriteLine("Anda ingin memasukkan ikan Cupang dengan jumlah : {0}? <ya/tidak> : ", jumlah);
                string tentu = Console.ReadLine();
                if (tentu == "ya")
                {
                    Console.WriteLine("{0} Ikan Cupang Ditambahkan ke aquascape", jumlah);
                }
                else
                {
                    Console.WriteLine("Ikan batal dimasukkan");
                }
            }
        }
        public Ikan(int jenisikan, int jumlahikan)
        {
            ikan_beli = jenisikan;
            jumlah = jumlahikan;
        }
    }

    public class Makan
    {
        int kapasitas;
        int jumlah_pakan;
        int keadaan;

        public void Berimakan()
        {
            keadaan = jumlah_pakan - kapasitas;
            if (keadaan < 0)
            {
                Console.WriteLine("Jumlah ikan yang sakit : {0}", keadaan * -1);
            }
            else
            {
                Console.WriteLine("Seluruh ikan mendapat pakan");
            }
        }
        public Makan(int kap_tank, int beripakan, int keadaanikan)
        {
            kapasitas = kap_tank;
            jumlah_pakan = beripakan;
            keadaan = keadaanikan;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int isi = 0;
            string ulang = "y";
            do
            {
                Console.WriteLine("Aquascape-Ku");
                Console.WriteLine("Pilih Aktivitas : \n1. Cek Aquascape\n2. Isi Aquascape\n3. Beri Pakan\nPilih : ");
                int pil = int.Parse(Console.ReadLine());
                if (pil == 1)
                {
                    Console.WriteLine("Jumlah ikan : {0}", isi);
                }
                if (pil == 2)
                {
                    Console.WriteLine("Pilih Jenis Ikan yang akan diisikan : \n1. Koi\n2. Guppy\n3. Cupang\nPilih : ");
                    int ikan_beli = int.Parse(Console.ReadLine());
                    Console.WriteLine("Berapa banyak? : ");
                    int jumlah = int.Parse(Console.ReadLine());
                    Ikan ikanku = new Ikan(ikan_beli, jumlah);
                    ikanku.Isi();
                    isi += jumlah;
                }
                else if (pil == 3)
                {
                    Console.WriteLine("Masukkan Jumlah Pakan : ");
                    int jpakan = int.Parse(Console.ReadLine());
                    Makan kasihpakan = new Makan(isi, jpakan, 0);
                    kasihpakan.Berimakan();
                }
                Console.WriteLine("Apakah Anda Ingin Mengulang? <y/n> : ");

                ulang = Console.ReadLine();
            }
            while (ulang == "y");
        }
    }
}