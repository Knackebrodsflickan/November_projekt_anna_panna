using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt_anna_panna_te17a
{
    class PrinceCharming : Enemy
    {
        public int PrinceCWithoutWeapon(int PrinceCWithoutWeapon)
        {
            return generator.Next(1, 10);
        }
        public int PrinceCWithWeapon(int PrinceCWithWeapon)
        {
            return generator.Next(10, 15);
        }
    }
}
