using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt_anna_panna_te17a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Budget Mortal Wombat! The game where you suprisingly dont fight wombats! ");
            Console.ReadLine();
            Console.WriteLine("What would you like to name your Hero?");
            string MainName = Console.ReadLine();

            Console.WriteLine("Your Hero´s name is: " + MainName + "!");
            Console.ReadLine();

            Hero MainHero = new Hero();









































            /*Hero h = new Hero();

            h.Xp = 100; // bestämma värdet av variabeln

            Console.WriteLine(h.Xp); // skriva ut variabeln men det är inte en variael då det körs i kod block
            Console.ReadLine();

            Console.WriteLine(h.Name);
            Console.ReadLine(); */
           
        }
    }
}
