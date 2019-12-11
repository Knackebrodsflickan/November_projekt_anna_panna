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

        public int damageWihtoutWeaponFarquaad(int damageWithoutWeaponFarquaad)
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
