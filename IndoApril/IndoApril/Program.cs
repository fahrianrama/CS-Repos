using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoApril
{
    class Program
    {
        static void Main(string[] args)
        {
            Produk productmanage = new Produk();
            int pilmenu = 0;
            while (pilmenu != 3)
            {
                int hasil = 0;
                Console.WriteLine("========================================\n");
                Console.WriteLine("Welcome To IndoApril Online Shopping\n");
                Console.WriteLine("========================================\n");
                Console.WriteLine("Silahkan Pilih Opsi Login : \n1. Admin\n2. Customer\n3. Exit\nPilih : ");
                pilmenu = int.Parse(Console.ReadLine());
                if (pilmenu == 1)
                {
                    Console.WriteLine("Masukkan Username : ");
                    string uname = Console.ReadLine();
                    Console.WriteLine("Masukkan Password : ");
                    string pass = Console.ReadLine();
                    Console.Clear();
                    Admin pegawaiku = new Admin(uname, pass);
                    hasil = pegawaiku.Verif();
                    if (hasil == 0)
                    {
                        Console.WriteLine("Status Login : Gagal\n");
                        Console.WriteLine("========================================\n");
                    }
                    else
                    {
                        Console.WriteLine("Status Login : Berhasil\n");
                        Console.WriteLine("========================================\n");
                        System.Console.ReadKey();
                        Console.Clear();
                        int menuadmin = 0;
                        while (menuadmin != 3)
                        {
                            Console.WriteLine("Silahkan Pilih Menu : \n1. Tampilkan Data Produk\n2. Tambah Data Produk\n3. Logout\nPilih : ");
                            menuadmin = int.Parse(Console.ReadLine());
                            if (menuadmin == 1)
                            {
                                Console.Clear();
                                productmanage.Tampil();
                            }
                            else if (menuadmin == 2)
                            {
                                Console.Clear();
                                productmanage.Tambah();
                            }
                            System.Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else if (pilmenu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Masukkan Username : ");
                    string uname = Console.ReadLine();
                    Console.WriteLine("Masukkan Password : ");
                    string pass = Console.ReadLine();
                    Console.Clear();
                    Customer cust = new Customer(uname, pass);
                    cust.Sign();
                    Console.Clear();
                    int menucust = 0;
                    int pengeluaran = 0;
                    while (menucust != 4)
                    {
                        Console.WriteLine("Silahkan Pilih Menu : \n1. Tampilkan Produk\n2. Beli Produk\n3. Cek Pengeluaran\n4. Logout\nPilih : ");
                        menucust = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (menucust == 1)
                        {
                            productmanage.Tampil();
                        }
                        else if (menucust == 2)
                        {
                            int pembelian = productmanage.Beli();
                            pengeluaran += pembelian;
                        }
                        else if (menucust == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Total pengeluaran Anda adalah : {0}", pengeluaran);
                        }
                        System.Console.ReadKey();
                        Console.Clear();
                    }
                }

                Console.Clear();
            }
        }
    }
}
