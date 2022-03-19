using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoApril
{
    class Customer
    {
        public string username;
        public string password;

        public void Sign()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Selamat Datang {0}", username);
            Console.WriteLine("========================================\n");
            System.Console.ReadKey();
        }
        public Customer(string uname, string pass)
        {
            username = uname;
            password = pass;
        }
    }
}
