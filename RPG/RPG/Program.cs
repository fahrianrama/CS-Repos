using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int nyawa = 0, karakter = 0, mana = 0, damage = 0;
            Console.WriteLine("Masukkan Nama Anda : ");
            string user = Console.ReadLine();
            Console.WriteLine("Pilih Karakter : \n1. Kesatria\n2. Pemanah\n3. Penyihir");
            int pilih = int.Parse(Console.ReadLine());
            if (pilih == 1)
            {
                nyawa = 150;
                karakter = 1;
                mana = 0;
            }
            else if (pilih == 2)
            {
                nyawa = 100;
                karakter = 2;
                mana = 20;
            }
            else
            {
                nyawa = 80;
                karakter = 3;
                mana = 100;
            }
            int tameng = 0;
            Player player1 = new Player(user, karakter, nyawa, mana);
            Console.WriteLine("Anda akan menghadapi Ogre dengan HP : 150 dan MP : 30");
            int hpmusuh = 150;
            int manamusuh = 30;
            int mdamage = 0;
            int mtameng = 0;
            int sembuhkan = 0;
            Enemy ogre = new Enemy(hpmusuh, manamusuh);
            int aksi = 0;
            while (aksi != 4)
            {
                tameng = 0;
                mtameng = 0;
                damage = 0;
                mdamage = 0;
                sembuhkan = 0;
                Console.WriteLine("Pilih Aksi : \n1. Serang\n2. Bertahan");
                if (karakter != 1)
                {
                    Console.WriteLine("3. Sembuhkan Nyawa");
                }
                Console.WriteLine("4. Kabur");
                aksi = int.Parse(Console.ReadLine());
                if (aksi == 1)
                {
                    damage = player1.Attack();
                    Console.WriteLine("Anda menyerang dan mengurangi {0} HP musuh", damage);
                    Console.WriteLine("Sisa HP Musuh : {0}", hpmusuh);
                }
                else if (aksi == 2)
                {
                    tameng = player1.Defense();
                    Console.WriteLine("Anda bertahan dan menahan {0} poin serangan musuh", tameng);
                }
                else if (aksi == 3)
                {
                    if (mana > 0)
                    {
                        Console.WriteLine("Anda mengembalikan 10 HP");
                        nyawa += 10;
                        mana -= 10;
                    }
                    else
                    {
                        Console.WriteLine("Mana Anda Habis");
                    }
                }
                Random aksimusuh = new Random();
                int serang = aksimusuh.Next(1, 3);
                if (serang == 1)
                {
                    mdamage = ogre.Attack();
                    mdamage -= tameng;
                    if (mdamage > 0)
                    {
                        Console.WriteLine("Musuh menyerang dan mengurangi {0} HP Anda", mdamage);
                    }
                    else
                    {
                        Console.WriteLine("Anda bertahan dari serangan musuh");
                    }
                }
                else if (serang == 2)
                {
                    mtameng = ogre.Defense();
                    Console.WriteLine("Musuh bertahan dan menahan {0} poin serangan Anda", mtameng);
                    if (damage > 0)
                    {
                        damage -= mtameng;
                    }
                }
                else
                {
                    sembuhkan = ogre.Heal();
                    Console.WriteLine("Musuh melakukan healing dan mengembalikan {0} HP", sembuhkan);
                }

                if (mdamage > 0)
                {
                    nyawa -= mdamage;
                }
                if (damage > 0)
                {
                    hpmusuh -= damage;
                }
                hpmusuh += sembuhkan;
                Console.WriteLine("Pahlawan : {0}\nNyawa Anda : {1}\nMana Anda : {3}\nOgre\nNyawa Musuh : {2}\nMana Musuh : {4}", user, nyawa, hpmusuh, mana, manamusuh);
                if (hpmusuh < 1)
                {
                    Console.WriteLine("Selamat Anda Menang!");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
