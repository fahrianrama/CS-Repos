using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> FirstName = new List<string>() { "Yohan", "Briaan", "Billy", "Billy", "Billy", "Billy", "Cliffton" };
            List<string> LastName = new List<string>() { "Anthony", "Putrantio", "Anthony", "Jefferson", "Agustian", "Panjaitan", "Sunarto" };
            List<DateTime> BirthDate = new List<DateTime>() { Convert.ToDateTime("10/06/2001"), Convert.ToDateTime("09/08/1998"), Convert.ToDateTime("09/12/2002"), Convert.ToDateTime("11/02/1997"), Convert.ToDateTime("06/10/2003"), Convert.ToDateTime("06/08/2000"), Convert.ToDateTime("12/02/2003"), };
            List<int> YearExperience = new List<int>() { 2, 7, 3, 6, 5, 4, 4 };

            Console.WriteLine("Menu");
            Console.WriteLine("1. Urut berdasarkan Nama Belakang (Ascending)");
            Console.WriteLine("2. Urut berdasarkan Nama Depan (Ascending), Kemudian Experience Yearnya(Ascending)");
            Console.WriteLine("3. Munculkan Nama dengan tahun lahir dibawah input");
            int menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                List<string> sortLastname = new List<string>();
                for (int i=0; i < LastName.Count(); i++)
                {
                    sortLastname.Add(LastName[i]);
                }
                sortLastname.Sort();
                string temp = "";
                for (int i = 0; i < sortLastname.Count(); i++) 
                {
                    if (sortLastname[i] != temp)
                    {
                        for (int j = 0; j < LastName.Count(); j++)
                        {
                            if (sortLastname[i] == LastName[j])
                            {
                                Console.WriteLine("{0} {1} ~ {2} ~ Experience : {3}", FirstName[j], LastName[j], BirthDate[j], YearExperience[j]);
                            }
                        }
                    }
                    temp = sortLastname[i];
                }
            }
            else if (menu == 2)
            {
                List<string> sortFirstName = new List<string>();
                List<int> sortexp = new List<int>();
                
                for (int i = 0; i < FirstName.Count(); i++)
                {
                    sortFirstName.Add(FirstName[i]);
                }
                sortFirstName.Sort();
                string duplicate = sortFirstName[0];
                string temp = "";
                Console.WriteLine("Total {0}", sortexp.Count());
                for (int i = 0; i < sortexp.Count(); i++)
                {
                    Console.WriteLine("{0}", sortexp[i]);
                }
                for (int i = 0; i < sortFirstName.Count(); i++)
                {
                    if (sortFirstName[i] != temp)
                    {
                        for (int j = 0; j < FirstName.Count(); j++)
                        {
                            if (sortFirstName[i] == FirstName[j])
                            {
                                Console.WriteLine("{0} {1} ~ {2} ~ Experience : {3}", FirstName[j], LastName[j], BirthDate[j], YearExperience[j]);
                                if (sortFirstName[i] == duplicate)
                                {
                                    sortexp.Add(YearExperience[i]);
                                }
                            }
                        }
                    }
                    temp = sortFirstName[i];
                }
                sortexp.Sort();
                for (int i = 0; i < sortFirstName.Count(); i++)
                {
                    if (sortFirstName[i] == duplicate)
                    {
                        for (int j = 0; j < FirstName.Count(); j++)
                        {
                            if (sortexp[i] == YearExperience[j] )
                            {
                                Console.WriteLine("{0} {1} ~ {2} ~ Experience : {3}", FirstName[j], LastName[j], BirthDate[j], YearExperience[j]);
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < FirstName.Count(); j++)
                        {
                            if (sortFirstName[i] == FirstName[j])
                            {
                                Console.WriteLine("{0} {1} ~ {2} ~ Experience : {3}", FirstName[j], LastName[j], BirthDate[j], YearExperience[j]);
                            }
                        }
                    }
                    temp = sortFirstName[i];
                }
            }
            else
            {
                Console.WriteLine("Tahun Lahir dibawah tahun : ");
                int tahun = int.Parse(Console.ReadLine());
                DateTime tahunmasukan = new DateTime(tahun, 1, 1);
                bool found = false;
                for (int i = 0; i < BirthDate.Count(); i++)
                {
                    if (tahunmasukan > BirthDate[i])
                    {
                        Console.WriteLine("{0} {1} ~ {2} ~ Experience : {3}", FirstName[i], LastName[i], BirthDate[i], YearExperience[i]);
                        found = true;
                    }
                }
                if (found != true)
                {
                    Console.WriteLine("Tidak ada nama dengan tahun lahir dibawah {0}", tahun);
                }
            }
            Console.ReadKey();
        }

}
}
