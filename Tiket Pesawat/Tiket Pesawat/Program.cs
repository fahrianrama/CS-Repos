using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiket_Pesawat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Maskapai = new string[,] { { "Garuda Indonesia", "2520" }, { "Citilink", "1428" }, { "Batik Air", "1620" }, { "Lion Air", "1440" } };
            string[,] Jadwal = new string[50, 6];
            string[,] Admin = new string[,] { { "admin", "123" }, { "admin", "admin" } };
            string[] Temp = new string[50];

        MenuUtama:
            Console.Clear();
            int pilih = Menu();
            if (pilih == 1)
            {
                string status = LoginAdmin(Admin);
                Console.WriteLine("Status Login : {0}", status);
                Console.WriteLine("=====================================");
                Console.ReadKey();
                Console.Clear();
                if (status == "Berhasil")
                {
                MenuAdmin:
                    Console.Clear();
                    int menu = MenuAdmin();
                    Console.Clear();
                    if (menu == 1)
                    {
                        ManageMaskapai(Maskapai);
                    }
                    else if (menu == 2)
                    {
                        ListPenerbangan(Jadwal);
                        Console.ReadKey();
                    }
                    else if (menu == 3)
                    {
                        CariPenerbangan(Jadwal);
                        Console.ReadKey();
                    }
                    else if (menu == 4)
                    {
                        SortPenerbangan(Temp, Jadwal);
                        Console.ReadKey();
                    }
                    else
                    {
                        goto MenuUtama;
                    }
                    goto MenuAdmin;
                }
                else
                {
                    Console.WriteLine("Status Login : Gagal");
                    Console.WriteLine("=====================================");
                    goto MenuUtama;
                }
            }
            else if (pilih == 2)
            {
                string username = LoginCust();
                Console.ReadKey();
                Console.Clear();
            MenuCustomer:
                Console.Clear();
                int menu = MenuCust();
                Console.Clear();
                if (menu == 1)
                {
                    PesanTiket(username, Jadwal, Maskapai);
                    Console.ReadKey();
                }
                else if (menu == 2)
                {
                    Jadwalku(username, Jadwal);
                    Console.ReadKey();
                }
                else
                {
                    goto MenuUtama;
                }
                goto MenuCustomer;
            }
        }

        static int Menu()
        {

            Console.WriteLine("-------- Selamat Datang di App Tiket Pesawat --------");
            Console.WriteLine("Opsi Login : \n\t1. Login Sebagai Admin\n\t2. Login Sebagai Customer\n\t3. Keluar");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Pilih : ");
            int pilih = int.Parse(Console.ReadLine());
            Console.Clear();
            return pilih;
        }

        static int MenuAdmin()
        {
            Console.WriteLine("=========== Menu Admin ===========");
            Console.WriteLine("  1. Maskapai");
            Console.WriteLine("  2. List Jadwal Penerbangan");
            Console.WriteLine("  3. Cari Jadwal Penerbangan");
            Console.WriteLine("  4. Urutkan List Penerbangan");
            Console.WriteLine("  5. Keluar");
            Console.WriteLine("==================================");
            Console.WriteLine("Pilih Menu : ");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }

        static int MenuCust()
        {
            Console.WriteLine("=========== Menu Customer ===========");
            Console.WriteLine("1. Booking Tiket");
            Console.WriteLine("2. Jadwal Penerbangan Anda");
            Console.WriteLine("3. Keluar");
            Console.WriteLine("=====================================");
            Console.WriteLine("Pilih Menu : ");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }

        static string LoginAdmin(string[,] Admin)
        {
            Console.WriteLine("-------- Login Sebagai Admin --------");
            Console.WriteLine("Username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Password : ");
            string password = Console.ReadLine();
            Console.WriteLine("=====================================");
            string status = "Gagal";
            for (int i = 0; i < Admin.Length / 2; i++)
            {
                if (username == Admin[i, 0])
                {
                    if (password == Admin[i, 1])
                    {
                        status = "Berhasil";
                        Console.WriteLine("Username dan Password Tepat");
                    }
                }
            }
            return status;
        }

        static string LoginCust()
        {
            Console.WriteLine("------ Login Sebagai Customer ------");
            Console.WriteLine("Nama Lengkap : ");
            string username = Console.ReadLine();
            Console.WriteLine("====================================");
            Console.WriteLine("Selamat datang {0}", username);
            Console.WriteLine("====================================");
            return username;
        }

        static void ListMaskapai(string[,] Maskapai)
        {
            Console.WriteLine("===== Maskapai Penerbangan =====");
            for (int i = 0; i < Maskapai.Length / 2; i++)
            {
                Console.WriteLine("Maskapai No-{0}", i + 1);
                Console.WriteLine("\t(-) {0}", Maskapai[i, 0]);
                Console.WriteLine("\tTarif : Rp.{0}/Km", Maskapai[i, 1]);
                Console.WriteLine("-------------------------------");
            }
        }

        static void ManageMaskapai(string[,] Maskapai)
        {
            ListMaskapai(Maskapai);
            Console.WriteLine("===============================");
            Console.WriteLine("Menu Management Maskapai : ");
            Console.WriteLine("1. Tambah Tarif Maskapai");
            Console.WriteLine("2. Ubah Tarif Maskapai");
            Console.WriteLine("===============================");
            Console.WriteLine("Pilih Menu : ");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine("Pilih Nomor Maskapai : ");
            int nomor = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < Maskapai.Length / 2; i++)
            {
                if (i + 1 == nomor)
                {
                    if (menu == 1)
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Menu Management Maskapai : ");
                        Console.WriteLine("===============================");
                        Console.WriteLine("Masukkan Jumlah Tambahan Biaya (Rp)");
                        int tambahan = int.Parse(Console.ReadLine());
                        Console.WriteLine("===============================");
                        int total = int.Parse(Maskapai[i, 1]) + tambahan;
                        Maskapai[i, 1] = total.ToString();
                        Console.WriteLine("Biaya ditambahkan");
                    }
                    else if (menu == 2)
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Menu Management Maskapai : ");
                        Console.WriteLine("===============================");
                        Console.WriteLine("Maskapai {0}", Maskapai[i, 0]);
                        Console.WriteLine("Tarif Awal : Rp.{0}", Maskapai[i, 1]);
                        Console.WriteLine("Tarif Baru : Rp.");
                        string tarif = Console.ReadLine();
                        Console.WriteLine("===============================");
                        Maskapai[i, 1] = tarif;
                        Console.WriteLine("Tarif Diperbarui");
                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void ListPenerbangan(string[,] Jadwal)
        {
            Console.WriteLine("======= List Jadwal Penerbangan =======");
            int nomor = 1;
            for (int i = 0; i < Jadwal.Length / 6; i++)
            {
                if (Jadwal[i, 0] != null)
                {
                    Console.WriteLine("Jadwal Ke-{0}", nomor);
                    Console.WriteLine("\tID Penerbangan : {0}", Jadwal[i, 0]);
                    Console.WriteLine("\tMaskapai : {0}", Jadwal[i, 1]);
                    Console.WriteLine("\tNama Penumpang : {0}", Jadwal[i, 2]);
                    Console.WriteLine("\tAsal : {0}", Jadwal[i, 3]);
                    Console.WriteLine("\tTujuan : {0}", Jadwal[i, 4]);
                    Console.WriteLine("\tTarif : Rp.{0}", Jadwal[i, 5]);
                    Console.WriteLine("=======================================");
                    nomor++;
                }
            }
        }

        static void CariPenerbangan(string[,] Jadwal)
        {
            Console.WriteLine("======= Cari Jadwal Penerbangan =======");
            Console.WriteLine("Cari Berdasarkan : ");
            Console.WriteLine("\t1. ID Jadwal Penerbangan");
            Console.WriteLine("\t2. Nama Penumpang");
            Console.WriteLine("=======================================");
            Console.WriteLine("Pilih : ");
            int indeks = Jadwal.Length / 6;
            int pilih = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================================");
            if (pilih == 1)
            {
                Console.WriteLine("Masukkan ID Penerbangan : ");
                string id = Console.ReadLine();
                indeks = CariID(id, Jadwal);
            }
            else if (pilih == 2)
            {
                Console.WriteLine("Masukkan Nama Penumpang : ");
                string nama = Console.ReadLine();
                indeks = CariNama(nama, Jadwal);
            }
            Console.Clear();
            if (indeks < Jadwal.Length / 6)
            {
                Console.WriteLine("======= Cari Jadwal Penerbangan =======");
                Console.WriteLine("Data Ditemukan !!");
                Console.WriteLine("ID Penerbangan : {0}", Jadwal[indeks, 0]);
                Console.WriteLine("\tMaskapai : {0}", Jadwal[indeks, 1]);
                Console.WriteLine("\tNama Penumpang : {0}", Jadwal[indeks, 2]);
                Console.WriteLine("\tAsal : {0}", Jadwal[indeks, 3]);
                Console.WriteLine("\tTujuan : {0}", Jadwal[indeks, 4]);
                Console.WriteLine("\tTarif : Rp.{0}", Jadwal[indeks, 5]);
                Console.WriteLine("=======================================");
            }
            else
            {
                Console.WriteLine("======= Cari Jadwal Penerbangan =======");
                Console.WriteLine("         Data Tidak Ditemukan          ");
                Console.WriteLine("=======================================");
            }
        }

        static int CariID(string id, string[,] Jadwal)
        {
            int indeks = Jadwal.Length / 6;
            for (int i = 0; i < Jadwal.Length / 6; i++)
            {
                if (Jadwal[i, 0] != null)
                {
                    if (Jadwal[i, 0] == id)
                    {
                        indeks = i;
                    }
                }
            }
            return indeks;
        }

        static int CariNama(string nama, string[,] Jadwal)
        {
            int indeks = Jadwal.Length / 6;
            for (int i = 0; i < Jadwal.Length / 6; i++)
            {
                if (Jadwal[i, 2] != null)
                {
                    if (Jadwal[i, 2] == nama)
                    {
                        indeks = i;
                    }
                }
            }
            return indeks;
        }

        static void SortPenerbangan(string[] Temp, string[,] Jadwal)
        {
            Console.Clear();
            Array.Clear(Temp, 0, Temp.Length);
            Console.WriteLine("===== Urutkan List Jadwal Penerbangan =====");
            Console.WriteLine("Urutkan Berdasarkan : ");
            Console.WriteLine("\t1. ID Penerbangan");
            Console.WriteLine("\t2. Maskapai");
            Console.WriteLine("===========================================");
            Console.WriteLine("Pilih : ");
            int urut = int.Parse(Console.ReadLine());
            Console.Clear();
            if (urut == 1)
            {
                int indeks = 0;
                for (int i = 0; i < Jadwal.Length / 6; i++)
                {
                    if (Jadwal[i, 0] != null)
                    {
                        Temp[indeks] = Jadwal[i, 0];
                        indeks++;
                    }
                }
                Array.Sort(Temp);
                Console.WriteLine("======= List Jadwal Penerbangan =======");
                for (int id = 0; id < Jadwal.Length / 6; id++)
                {
                    int nomor = 1;
                    if (Temp[id] != null)
                    {
                        for (int j = 0; j < Jadwal.Length / 6; j++)
                        {
                            if (Temp[id] == Jadwal[j, 0])
                            {
                                Console.WriteLine("Jadwal Ke-{0}", nomor);
                                Console.WriteLine("\tID Penerbangan : {0}", Jadwal[j, 0]);
                                Console.WriteLine("\tMaskapai : {0}", Jadwal[j, 1]);
                                Console.WriteLine("\tNama Penumpang : {0}", Jadwal[j, 2]);
                                Console.WriteLine("\tAsal : {0}", Jadwal[j, 3]);
                                Console.WriteLine("\tTujuan : {0}", Jadwal[j, 4]);
                                Console.WriteLine("\tTarif : Rp.{0}", Jadwal[j, 5]);
                                Console.WriteLine("=======================================");
                                nomor++;
                            }
                        }
                    }
                }
            }
            else if (urut == 2)
            {
                int indeks = 0;
                for (int i = 0; i < Jadwal.Length / 6; i++)
                {
                    if (Jadwal[i, 1] != null)
                    {
                        Temp[indeks] = Jadwal[i, 1];
                        indeks++;
                    }
                }
                Array.Sort(Temp);
                Console.WriteLine("======= List Jadwal Penerbangan =======");
                for (int id = 0; id < Jadwal.Length / 6; id++)
                {
                    int nomor = 1;
                    if (Temp[id] != null)
                    {
                        for (int j = 0; j < Jadwal.Length / 6; j++)
                        {
                            if (Temp[id] == Jadwal[j, 1])
                            {
                                Console.WriteLine("Jadwal Ke-{0}", nomor);
                                Console.WriteLine("\tID Penerbangan : {0}", Jadwal[j, 0]);
                                Console.WriteLine("\tMaskapai : {0}", Jadwal[j, 1]);
                                Console.WriteLine("\tNama Penumpang : {0}", Jadwal[j, 2]);
                                Console.WriteLine("\tAsal : {0}", Jadwal[j, 3]);
                                Console.WriteLine("\tTujuan : {0}", Jadwal[j, 4]);
                                Console.WriteLine("\tTarif : Rp.{0}", Jadwal[j, 5]);
                                Console.WriteLine("=======================================");
                                nomor++;
                            }
                        }
                    }
                }
            }
        }

        static void PesanTiket(string username, string[,] Jadwal, string[,] Maskapai)
        {
            Console.Clear();
            Random rnd = new Random();
            int idloc = 0;
            for (int indeks = 0; indeks < Jadwal.Length / 6; indeks++)
            {
                if (Jadwal[indeks, 0] != null)
                {
                    idloc++;
                }
            }
            int id = rnd.Next();
            Console.WriteLine("======= List Jadwal Penerbangan =======");
            Console.WriteLine("ID Pesanan : {0}", id);
            Console.WriteLine("Nama Customer : {0}", username);
            Console.WriteLine("Masukkan Kota Asal : ");
            string asal = Console.ReadLine();
            Console.WriteLine("Masukkan Kota Tujuan : ");
            string tujuan = Console.ReadLine();
            Console.WriteLine("Masukkan Jarak Penerbangan : ");
            int jarak = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Pilih Maskapai : ");
            Console.WriteLine("--------------------------");
            int tarif = 0;
            for (int i = 0; i < Maskapai.Length / 2; i++)
            {
                if (Maskapai[i, 0] != null)
                {
                    Console.WriteLine("Maskapai No-{0}", i + 1);
                    Console.WriteLine("\t{0}", Maskapai[i, 0]);
                    tarif = int.Parse(Maskapai[i, 1]) * jarak;
                    Console.WriteLine("\tTarif : Rp.{0}", tarif);
                    Console.WriteLine("--------------------------");
                }
            }
            Console.WriteLine("Pilih Nomor Maskapai : ");
            int nomor = int.Parse(Console.ReadLine());
            for (int j = 0; j < Maskapai.Length / 2; j++)
            {
                if (j + 1 == nomor)
                {
                    Console.WriteLine("Anda Yakin Memilih Maskapai {0} ? (y/t)", Maskapai[j, 0]);
                    string pilih = Console.ReadLine();
                    if (pilih == "y")
                    {
                        Jadwal[idloc, 0] = id.ToString();
                        Jadwal[idloc, 1] = Maskapai[j, 0];
                        Jadwal[idloc, 2] = username;
                        Jadwal[idloc, 3] = asal;
                        Jadwal[idloc, 4] = tujuan;
                        Jadwal[idloc, 5] = tarif.ToString();
                        Console.WriteLine("Tiket Dipesan");
                    }
                    else
                    {
                        Console.WriteLine("Tiket Batal Dipesan");
                    }
                }
            }

        }

        static void Jadwalku(string username, string[,] Jadwal)
        {
            Console.Clear();
            int ada = 0;
            Console.WriteLine("====== Jadwal Penerbangan User {0} ======", username);
            for (int i = 0; i < Jadwal.Length / 6; i++)
            {
                if (Jadwal[i, 0] != null)
                {
                    if (username == Jadwal[i, 2])
                    {
                        Console.WriteLine("\tID Penerbangan : {0}", Jadwal[i, 0]);
                        Console.WriteLine("\tMaskapai : {0}", Jadwal[i, 1]);
                        Console.WriteLine("\tNama Penumpang : {0}", Jadwal[i, 2]);
                        Console.WriteLine("\tAsal : {0}", Jadwal[i, 3]);
                        Console.WriteLine("\tTujuan : {0}", Jadwal[i, 4]);
                        Console.WriteLine("\tTarif : Rp.{0}", Jadwal[i, 5]);
                        Console.WriteLine("=================================================");
                        ada = 1;
                    }
                }
            }
            if (ada != 1)
            {
                Console.WriteLine("Tidak Ada Jadwal Penerbangan");
                Console.WriteLine("=================================================");
            }
        }
        
    }
    
}
