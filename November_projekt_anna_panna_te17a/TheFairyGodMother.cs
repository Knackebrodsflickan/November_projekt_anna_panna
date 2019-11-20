using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt_anna_panna_te17a
{
    class TheFairyGodMother : Enemy
    {
        
       

        public int damageWihtoutWeaponFairyG(int damageWithoutWeaponFairyG)
        {
            return generator.Next(2, 10);

        }
        public int damageWithWeaponFairyG(int damageWithWeaponFairyG)
        {
            return generator.Next(10, 20);
        }
    }
}
