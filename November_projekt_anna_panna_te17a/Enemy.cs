using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt_anna_panna_te17a
{
    class Enemy
    {
       public static Random generator = new Random();

        public static int hp;
        static public string name;

        public Enemy()
        {
            hp = 99;
            name = " ";
        }

        public void HurtEnemy(int amount)
        {
            hp -= amount;
        }
        
        public int Attack()
        {
            return 5;
        }
        public int getHp()
        {
            return hp;
        }



        
        
    }
}
