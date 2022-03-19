using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoApril
{
    class Produk
    {
        List<int> arid = new List<int>();
        List<string> arname = new List<string>();
        List<int> arprice = new List<int>();
        List<int> arstock = new List<int>();

        public void Tambah()
        {
            Console.WriteLine("Masukkan ID Produk : ");
            int id = int.Parse(Console.ReadLine());
            arid.Add(id);
            Console.WriteLine("Masukkan Nama Produk : ");
            string nama = Console.ReadLine();
            arname.Add(nama);
            Console.WriteLine("Masukkan Harga Produk : ");
            int harga = int.Parse(Console.ReadLine());
            arprice.Add(harga);
            Console.WriteLine("Masukkan Stok : ");
            int stok = int.Parse(Console.ReadLine());
            arstock.Add(stok);
            Console.WriteLine("========================================\n");
            Console.WriteLine("Produk Ditambahkan\n");
            Console.WriteLine("========================================\n");
        }
        public void Tampil()
        {
            int total = arname.Count;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("ID Produk -{0}", arid[i]);
                Console.WriteLine("\tNama Produk : {0}", arname[i]);
                Console.WriteLine("\tHarga Produk : {0}", arprice[i]);
                Console.WriteLine("\tStok Produk : {0}", arstock[i]);
                Console.WriteLine("========================================\n");
            }
        }
        public int Beli()
        {
            int jumlah = arid.Count;
            Console.WriteLine("Masukkan ID Barang");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Jumlah Barang");
            int total = int.Parse(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                if (arid[i] == id)
                {
                    if (arstock[i] - total > 0)
                    {
                        Console.WriteLine("Anda akan Membeli {0} dengan harga Rp.{1} Sebanyak {2}? <y/t>", arname[i], arprice[i], total);
                        string verif = Console.ReadLine();
                        if (verif == "y")
                        {
                            Console.WriteLine("Total Biaya : Rp.{0}. Konfirmasi ? <y/t>", arprice[i] * total);
                            string beli = Console.ReadLine();
                            if (beli == "y")
                            {
                                Console.WriteLine("Terima kasih atas transaksinya");
                                arstock[i] = arstock[i] - total;
                                int pesanan = arprice[i] * total;
                                return pesanan;
                            }
                            else
                            {
                                Console.WriteLine("Transaksi dibatalkan");
                                return 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Transaksi dibatalkan");
                            return 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Stok Tidak Cukup");
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Produk tidak tersedia");
                    return 0;
                }
            }
            return 0;

        }
    }
}
