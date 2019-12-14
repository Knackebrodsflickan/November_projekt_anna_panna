using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt_anna_panna_te17a
{
    class PrinceCharming : Enemy // ärver av enemy

    {

        public PrinceCharming()
        {
            name = "PrinceCharming";
        }

        public int PrinceCWithoutWeapon(int PrinceCWithoutWeapon) // så dessa är ju fullt funktionella, bara det att jag inte haft tid att
            // lägga in dem ännu, bara för jag inte haft någon tid. 
        {
            return generator.Next(1, 10);
        }
        public int PrinceCWithWeapon(int PrinceCWithWeapon)
        {
            return generator.Next(10, 15);
        }
    }
}
