using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengelolaan_Hasil_Panen
{
    class HasilPanen
    {
        List<string> listpetani = new List<string>();
        List<string> listkomoditas = new List<string>();
        List<int> liststok = new List<int>();
        List<int> listharga = new List<int>();
        List<string> liststatus = new List<string>();

        public void AjukanPermintaan(string pengaju, string komoditas)
        {
            string status;
            int berat, harga;
            listpetani.Add(pengaju);
            listkomoditas.Add(komoditas);
            Console.WriteLine("Masukkan Total Hasil Panen (kg) : ");
            berat = int.Parse(Console.ReadLine());
            liststok.Add(berat);
            Console.WriteLine("Masukkan Harga Per Kg : ");
            harga = int.Parse(Console.ReadLine());
            listharga.Add(harga);
            status = "Belum Disetujui";
            liststatus.Add(status);
            Console.WriteLine("========================================\n");
            Console.WriteLine("Data Hasil Panen Diajukan\n");
            Console.WriteLine("========================================\n");
        }

        public void CekPengajuan(string pengaju)
        {
            int a = 0;
            for (int i = 0; i < listpetani.Count; i++)
            {
                Console.WriteLine("Data Pengajuan");
                if (listpetani[i] == pengaju)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("ID Pengajuan {0}", i + 1);
                    Console.WriteLine("\tTotal Hasil : {0}Kg", liststok[i]);
                    Console.WriteLine("\tHarga : Rp. {0}/Kg", listharga[i]);
                    Console.WriteLine("\tTotal Harga : Rp. {0}", liststok[i] * listharga[i]);
                    Console.WriteLine("\tStatus Pengajuan : {0}", liststatus[i]);
                    Console.WriteLine("========================================\n");
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Data Pengajuan Kosong");
            }
        }
        public void HapusAjuan()
        {
            int a = 0;
            Console.WriteLine("Pilih ID Ajuan : ");
            int nomor = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < listpetani.Count; i++)
            {
                if (i + 1 == nomor)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("Pengajuan Nomor {0} dengan Nama Pengaju : {1} Telah Dihapus", i + 1, listpetani[i]);
                    Console.WriteLine("========================================\n");
                    listpetani.RemoveAt(i);
                    listkomoditas.RemoveAt(i);
                    liststok.RemoveAt(i);
                    listharga.RemoveAt(i);
                    liststatus.RemoveAt(i);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Data Pengajuan Tidak Ditemukan");
            }
        }

        public void AllData(string komoditas)
        {
            int a = 0;
            for (int i = 0; i < listpetani.Count; i++)
            {
                if (listkomoditas[i] == komoditas)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("ID Pengajuan {0}", i + 1);
                    Console.WriteLine("\tNama Pengaju : {0}", listpetani[i]);
                    Console.WriteLine("\tTotal Hasil : {0}Kg", liststok[i]);
                    Console.WriteLine("\tHarga : Rp. {0}/Kg", listharga[i]);
                    Console.WriteLine("\tTotal Harga : Rp. {0}", liststok[i] * listharga[i]);
                    Console.WriteLine("\tStatus Pengajuan : {0}", liststatus[i]);
                    Console.WriteLine("========================================\n");
                    a++;
                }

            }
            if (a == 0)
            {
                Console.WriteLine("Data Pengajuan Kosong");
            }
        }

        public void AksiAjuan(string komoditas)
        {
            int a = 0;
            Console.WriteLine("Pilih ID Ajuan : ");
            int nomor = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < listpetani.Count; i++)
            {
                if (i + 1 == nomor)
                {
                    Console.WriteLine("Pilih Aksi :\n\t1. Terima\n\t2. Tolak");
                    int aksi = int.Parse(Console.ReadLine());
                    if (aksi == 1)
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("Pengajuan Nomor {0} dengan Nama Pengaju : {1} Disetujui", i + 1, listpetani[i]);
                        Console.WriteLine("========================================\n");
                        liststatus[i] = "Disetujui";
                    }
                    else
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("Pengajuan Nomor {0} dengan Nama Pengaju : {1} Ditolak", i + 1, listpetani[i]);
                        Console.WriteLine("========================================\n");
                        liststatus[i] = "Ditolak";
                    }
                    a++;
                }

            }
            if (a == 0)
            {
                Console.WriteLine("Data Pengajuan yang Dipilih Tidak Tersedia");
            }
        }
    }
}
