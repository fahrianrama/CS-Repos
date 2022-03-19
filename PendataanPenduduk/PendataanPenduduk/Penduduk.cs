using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendataanPenduduk
{
    class Penduduk
    {
        List<string> datanama = new List<string>();
        List<int> dataumur = new List<int>();
        List<string> datapekerjaan = new List<string>();
        List<int> datapenghasilan = new List<int>();

        public void TambahData()
        {
            Console.WriteLine("Berapa data yang ingin dimasukkan? : ");
            int jumlah = int.Parse(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine("Data Penduduk Ke-{0} : ", i + 1);
                Console.WriteLine("Masukkan Nama Penduduk : ");
                string nama = Console.ReadLine();
                datanama.Add(nama);
                Console.WriteLine("Masukkan Umur Penduduk : ");
                int umur = int.Parse(Console.ReadLine());
                dataumur.Add(umur);
                Console.WriteLine("Pilih Status Pekerjaan Penduduk : \n\t1. Bekerja\n\t2. Pelajar/Mahasiswa\n\t3. Tidak Bekerja");
                int status = int.Parse(Console.ReadLine());
                string pekerjaan = "kosong";
                if (status == 1)
                {
                    pekerjaan = "Bekerja";
                }
                else if (status == 2)
                {
                    pekerjaan = "Pelajar/Mahasiswa";
                }
                else
                {
                    pekerjaan = "Tidak Bekerja";
                }
                datapekerjaan.Add(pekerjaan);
                if (pekerjaan == "Bekerja")
                {
                    Console.WriteLine("Masukkan Penghasilan Penduduk Perbulan : ");
                    int penghasilan = int.Parse(Console.ReadLine());
                    datapenghasilan.Add(penghasilan);
                }
                else
                {
                    int penghasilan = 0;
                    datapenghasilan.Add(penghasilan);
                }

                Console.WriteLine("========================================");
                Console.WriteLine("====== Data Penduduk Ditambahkan =======");
                Console.WriteLine("========================================");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void TampilkanData()
        {
            int totaldata = datanama.Count;
            for (int i = 0; i < totaldata; i++)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Penduduk Ke -{0}", i + 1);
                Console.WriteLine("\tNama : {0}", datanama[i]);
                Console.WriteLine("\tUmur : {0}", dataumur[i]);
                Console.WriteLine("\tStatus Pekerjaan: {0}", datapekerjaan[i]);
                if (datapenghasilan[i] > 0)
                {
                    Console.WriteLine("\tPenghasilan Perbulan : {0}", datapenghasilan[i]);
                }
                Console.WriteLine("========================================\n");
            }
        }

        public void DataBekerja()
        {
            int totaldata = datapekerjaan.Count;
            int jumlahkerja = 0;
            int jumlahpelajar = 0;
            int jumlahtidakkerja = 0;
            for (int i = 0; i < totaldata; i++)
            {
                if (datapekerjaan[i] == "Bekerja")
                {
                    jumlahkerja++;
                }
                else if (datapekerjaan[i] == "Pelajar/Mahasiswa")
                {
                    jumlahpelajar++;
                }
                else
                {
                    jumlahtidakkerja++;
                }
            }
            Console.WriteLine("===========================================");
            Console.WriteLine("Rekap Data Pekerjaan Penduduk");
            Console.WriteLine("\tPenduduk Bekerja : {0}", jumlahkerja);
            Console.WriteLine("\tPenduduk Pelajar/Mahasiswa : {0}", jumlahpelajar);
            Console.WriteLine("\tPenduduk Belum/Tidak Bekerja : {0}", jumlahtidakkerja);
            Console.WriteLine("===========================================\n");
        }
        public void RataPenghasilan()
        {
            int totaldata = datapenghasilan.Count;
            int totalpendapatan = 0;
            int jumlahkerja = 0;
            for (int i = 0; i < totaldata; i++)
            {
                if (datapenghasilan[i] > 0)
                {
                    jumlahkerja++;
                    totalpendapatan += datapenghasilan[i];
                }
            }
            int ratarata = totalpendapatan / jumlahkerja;
            Console.WriteLine("========================================");
            Console.WriteLine("Rekap Pendapatan Penduduk");
            Console.WriteLine("\tPenduduk Bekerja : {0}", jumlahkerja);
            Console.WriteLine("\tRata-Rata Penghasilan Perbulan : {0}", ratarata);
            Console.WriteLine("========================================\n");
        }

        public void DataUmur()
        {
            int totaldata = dataumur.Count;
            int jumlahanak = 0;
            int jumlahremaja = 0;
            int jumlahdewasa = 0;
            for (int i = 0; i < totaldata; i++)
            {
                if (dataumur[i] < 10)
                {
                    jumlahanak++;
                }
                else if (dataumur[i] < 19)
                {
                    if (dataumur[i] > 10)
                    {
                        jumlahremaja++;
                    }
                }
                else
                {
                    jumlahdewasa++;
                }
            }
            Console.WriteLine("===========================================");
            Console.WriteLine("Rekap Data Umur Penduduk");
            Console.WriteLine("\tPenduduk Anak - Anak : {0}", jumlahanak);
            Console.WriteLine("\tPenduduk Remaja : {0}", jumlahremaja);
            Console.WriteLine("\tPenduduk Dewasa : {0}", jumlahdewasa);
            Console.WriteLine("===========================================\n");
        }
    }
}
