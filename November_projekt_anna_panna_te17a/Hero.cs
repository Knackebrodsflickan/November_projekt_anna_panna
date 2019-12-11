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
        private int minDamageHero; // int min / naxdamage som skulle kunna se på hero
        public int HpHero { get; private set; } // här är hp till hero

        public Hero() // en metod som kör när man kör main program , säger att hero innehåller hp, min och max damage
        {
            HpHero = 99;
            minDamageHero = 6;
            maxDamageHero = 20;
        }

        public void HurtHero(int amount) //när man kör mainkoden där heron tar skada så kommer denna metod köras, vilket tar bort hp när hero blir attackerad
        {
            HpHero -= amount; 
        }

        public int Attack() //attack metod som används när hero slåss mot the enemy, själva damagen bestäms av en random generator jag gjort högst upp 
        {
            return generator.Next(minDamageHero, maxDamageHero);
            
        }
        public int getHpHero() //retunerar hp 
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
