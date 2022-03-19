using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Enemy
    {
        public int hp;
        public int mp;

        public int Attack()
        {
            Random atk = new Random();
            int serang = atk.Next(10, 20);
            return serang;
        }
        public int Defense()
        {
            Random def = new Random();
            int defense = def.Next(15, 30);
            return defense;
        }
        public int Heal()
        {
            Random heal = new Random();
            int healing = heal.Next(10, 30);
            return healing;
        }
        public Enemy(int nyawa, int mana)
        {
            hp = nyawa;
            mp = mana;
        }
    }
}
