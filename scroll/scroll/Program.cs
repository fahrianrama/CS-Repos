using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scroll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            Console.WriteLine("3. Search Scroll\n4. Delete Scroll\nChoose what to do: ");
            int menu = int.Parse(Console.ReadLine());
            int indeks = 0;
            bool found = false;
            
            if (menu == 3)
            {
                Console.WriteLine("Insert scroll name: ");
                string scroll = Console.ReadLine();
                for (int i = 0; i < scrolls.Count(); i++)
                {
                    if (scrolls[i].ToLower() == scroll.ToLower())
                    {
                        indeks = i;
                    }
                }
                Console.WriteLine("Book found. Queue number: {0}", indeks + 1);
            }
            else if (menu == 4)
            {
                Console.WriteLine("Remove from list by scroll name? Y/N:");
                char pilih = char.ToLower(Console.ReadLine()[0]);
                while (pilih != 'y' && pilih != 'n')
                {
                    Console.WriteLine("Wrong selection. Choose again: ");
                    Console.WriteLine("Remove from list by scroll name? Y/N:");
                    pilih = char.ToLower(Console.ReadLine()[0]);
                }
                if (pilih == 'y')
                {
                    Console.WriteLine("Insert scroll name: ");
                    string scroll = Console.ReadLine();
                    for (int i = 0; i < scrolls.Count(); i++)
                    {
                        if (scrolls[i].ToLower() == scroll.ToLower())
                        {
                            indeks = i;
                        }
                    }
                    scrolls.RemoveAt(indeks);
                    Console.WriteLine("Book removed!");
                }
                else if (pilih == 'n')
                {
                    Console.WriteLine("Input scroll queue: ");
                    int scroll = int.Parse(Console.ReadLine());
                    while (scroll > scrolls.Count())
                    {
                        Console.WriteLine("Queue not found. insert scroll queue: ");
                        scroll = int.Parse(Console.ReadLine());
                    }
                    scrolls.RemoveAt(scroll);
                    Console.WriteLine("Book removed!");
                }
                
            }
            Console.ReadKey();
        }
    }
}
