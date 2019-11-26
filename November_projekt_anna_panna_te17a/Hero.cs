using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt_anna_panna_te17a
{
    class Hero
    {
        static Random generator = new Random();

        private int maxDamageHero;
        private int minDamageHero;
        public int HpHero { get; private set; }

        public Hero()
        {
            HpHero = 99;
            minDamageHero = 6;
            maxDamageHero = 20;
        }

        public void HurtHero(int amount)
        {
            HpHero -= amount;
        }

        public int Attack()
        {
            return generator.Next(minDamageHero, maxDamageHero);
            
        }
        public int getHpHero()
        {
            if(HpHero < 0)
            {
                HpHero = 0;
            }
            return HpHero;
        }




































        /* public string Name { get; set; } // automatiska implementerade proporties 


         public int Level
         {
             get
             {
                 return 1 + xp/10;
             }
             set
             {

             }
         }
         public int Xp
         {
             get
             {
                 return xp; // kan retunera allt från random gen 
             }
             set // Kan göra CW, can göra vad du vill
             {
                 xp = value;
                 Level = 1 + xp / 10;
             }
              public void Attack(Hero opponent)
        {
            opponent.HurtHero(5);
        }



        public void Attack(Hero opponent)
        {
            opponent.HurtHero(5);
        }
         }
         private int xp = 0; // om private, kan jag ändrau tan att det sör någon annan eller att någon annan märker 
         //private int level = 0;

         public void AddXp(int amount)
         {
             xp += amount;

         }
         public int GetXp()
         {
             return xp;
         }*/

    }
}
