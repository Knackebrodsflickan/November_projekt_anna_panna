using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt_anna_panna_te17a
{
    class Farquaad : Enemy //farquaad ärver av enemy
    {
        
        public Farquaad()
        {
            name = "Farquaad";
          
        }

        public int damageWihtoutWeaponFarquaad(int damageWithoutWeaponFarquaad) // eventuellt sätt ville jag lägga till så jag hade damage med och utan vapen,
            // men det blev lite för mycket plugg med annat och för lite tid här så det får gå till ett annat projekt 
        {
            return generator.Next(2, 5);

        }
       public int damageWithWeaponFarquaad(int damageWithWeaponFarquaad)
        {
            return generator.Next(10, 25);
        }



        //public string Name = "Farquaad"; 

        /* public int damageWithWeaponFarquaad(int damageWithWeaponFarquaad)
         {
             return generator.Next(10, 18);
         }*/





    }
}
