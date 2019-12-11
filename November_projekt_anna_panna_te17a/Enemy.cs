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

        public static int hpEnemy;
        static public string name;

        public Enemy() //enemy metod som innehåller hp och namn, gers sedan ut i arv 
        {
            hpEnemy = 99;
            name = " ";
        }

        public void HurtEnemy(int amount) //samma som hero, körs när enemy blir skadad
        {
            hpEnemy -= amount;
        }
        
        public int Attack() //åter igen, attacj metoden. 
        {
            return 5;
        }
        public int getHpEnemy() // här är för att få retunera hp 
        {
            if (hpEnemy < 0)
            {
                hpEnemy = 0;
            }
            return hpEnemy;
        }



        
        
    }
}
