using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoApril
{
    class Admin
    {
        public string datuname = "admin";
        public string datpass = "123";
        public string username;
        public string password;
        public int status;

        public int Verif()
        {
            if (username == datuname)
            {
                if (password == datpass)
                {
                    status = 1;
                    Console.WriteLine("========================================\n");
                    Console.WriteLine("Selamat Datang\n");
                    Console.WriteLine("========================================\n");
                    return status;
                }
                else
                {
                    status = 0;
                    Console.WriteLine("========================================\n");
                    Console.WriteLine("Password yang Anda masukkan salah\n");
                    Console.WriteLine("========================================\n");
                    return status;
                }
            }
            else
            {
                status = 0;
                Console.WriteLine("========================================\n");
                Console.WriteLine("Username dan Password yang Anda masukkan salah\n");
                Console.WriteLine("========================================\n");
                return status;
            }
        }
        public Admin(string uname, string pass)
        {
            username = uname;
            password = pass;
        }
    }
}
