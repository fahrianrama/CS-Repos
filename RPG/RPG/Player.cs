using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Player
    {
        public string nama;
        public int role;
        public int hp;
        public int mp;

        public int Attack()
        {
            if (role == 1)
            {
                Random atk = new Random();
                int serang = atk.Next(5, 10);
                return serang;
            }
            else if (role == 2)
            {
                Random atk = new Random();
                int serang = atk.Next(10, 15);
                return serang;
            }
            else
            {
                Random atk = new Random();
                int serang = atk.Next(10, 20);
                return serang;
            }
        }
        public int Defense()
        {
            if (role == 1)
            {
                Random def = new Random();
                int defense = def.Next(25, 50);
                return defense;
            }
            else if (role == 2)
            {
                Random def = new Random();
                int defense = def.Next(10, 15);
                return defense;
            }
            else
            {
                Random def = new Random();
                int defense = def.Next(5, 10);
                return defense;
            }
        }
        public Player(string user, int karakter, int nyawa, int mana)
        {
            nama = user;
            role = karakter;
            hp = nyawa;
            mp = mana;
        }
    }
}
