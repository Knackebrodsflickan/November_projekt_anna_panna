using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace November_projekt_anna_panna_te17a
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Budget Mortal Wombat! The game where you suprisingly dont fight wombats! ");
            Console.ReadKey();
            Console.WriteLine("What would you like to name your Hero?");  // this segment right here introduces the game and 
            string MainName = Console.ReadLine();  // this one allows you to write in your Hero´s name. 

            Console.WriteLine("Your Hero´s name is: " + MainName + "!"); // writes out what your heros name is
            Console.ReadKey();

            Hero MainHero = new Hero(); //creates a new hero

            Enemy Farquaad = new Enemy();  
            Enemy TheFairyGodMother = new Enemy(); // alla dessa tre skapar tre olika enemies kallade farquaad, thefairygodmother, princecharming
            Enemy PrinceCharming = new Enemy();

            Console.WriteLine("Which enemy would you like to battle first? Here are your options: ");
            Console.WriteLine("Farquuad");
            Console.WriteLine("The Fairy Godmother");
            Console.WriteLine("Prince Charming");
            string ReadEnemyName = Console.ReadLine(); // detta segment låter dig bestämma vilken av fienderna du vill möta och du väljer fiende genom att skriva in karaktärsnamnet
            if(ReadEnemyName != "Farquaad" && ReadEnemyName != "The Fairy Godmother" && ReadEnemyName != "Prince Charming") //den här säger i princip att om du inte skriver in någon av namnen utan skriver in fel eller försöker trolla får du en "oh no" thats wrong". 
            {
                Console.WriteLine("Uh oh! that is not one of your enemies - if you feel like fighting with someone not on this list try reddit :)");
                Console.ReadKey();
            }
            else if(ReadEnemyName == "Farquaad" || ReadEnemyName == "The Fairy Godmother" || ReadEnemyName == "Prince Charming") // men om det däremot är en av dessa karaktärer så kommer du får börjsa spela med viilken av karaktärerna du väljer.
            {
                Console.WriteLine("Good choice! You decided the Enemy: " + ReadEnemyName); // läser ut fiendens namn som du valt 
                Console.WriteLine("Time to start the show! Can we get a count down?");
                Console.ReadLine();

                Console.WriteLine("Three");
                Thread.Sleep(500); // sleep tilltåter den automatiskt räkna ner
                Console.WriteLine("Two");
                Thread.Sleep(500);
                Console.WriteLine("One!");
                Thread.Sleep(500);
                Console.WriteLine("Let the games begin!");
                Console.ReadLine();

                if(ReadEnemyName == "Farquaad") // nu så, om fienden du valde var farquaad så kommer detta segment spelas, och du kommer ingå i strid med han. 
                {
                

                    Console.WriteLine("Farquaad hp: " + Farquaad.getHpEnemy()); // här har vi två metoder som returnerar farquaads ( alltså fiendens ) samt din hjältes hp. 
                    Console.WriteLine(MainName + " hp: " + MainHero.getHpHero());
                    Console.ReadKey();

                    while (Farquaad.getHpEnemy() > 0 && MainHero.getHpHero() > 0) // den här loopen ( alltså att dom slåss ) körs så länge deras hp inte droppar below 0 
                    {
                        MainHero.HurtHero(Farquaad.Attack());
                        Farquaad.HurtEnemy(MainHero.Attack()); // kör metoden attack, vilket ger minus hp. 
                        Console.WriteLine("This is how its going so far");
                        Console.WriteLine("Farquaad hp: " + Farquaad.getHpEnemy());
                        Console.WriteLine(MainName + " hp: " + MainHero.getHpHero());
                        Console.ReadKey();
                        Console.WriteLine();
                    }

                    if (MainHero.getHpHero() <= 0)
                    {

                        Console.WriteLine("Uh oh! im sorry " + MainName + ", it looks like you lost! try again?"); // om hp är 0 för din hero karaktärer kommer du att dö och få meddelandet att du förlorat
                        Console.ReadKey();
                    }
                    else if (Farquaad.getHpEnemy() <= 0) // tvärtomhär, om din fiende i det här fallet farquaad har hp 0 kommer du att vinna. 
                    {
                        Console.WriteLine("Congratulations! You won!");
                        Console.ReadKey();
                    }
                    Console.ReadKey();


                    /*  if (MainHero.getHpHero() < 0)
                      {

                          Console.WriteLine("Uh oh! im sorry " + MainName + "it looks like you lost! try again?");
                          Console.ReadLine();
                      }
                      else if(Farquaad.getHpEnemy() < 0)
                      {
                          Console.WriteLine("Congratulations! You won!");
                          Console.ReadLine();
                      }
                          Console.WriteLine(MainName + " attacks Farquaad"); MainHero.HurtHero(Farquaad.Attack());
                      Console.WriteLine("Farquaad attacked " + MainName); Farquaad.HurtEnemy(MainHero.Attack());
                      Console.WriteLine(MainName + " attacks Farquaad"); MainHero.HurtHero(Farquaad.Attack());
                      Console.WriteLine("Farquaad attacked " + MainName); Farquaad.HurtEnemy(MainHero.Attack());
                      Console.WriteLine(MainName + " attacks Farquaad"); MainHero.HurtHero(Farquaad.Attack());
                      Console.WriteLine("Farquaad attacked " + MainName); Farquaad.HurtEnemy(MainHero.Attack());
                      Console.WriteLine(MainName + " attacks Farquaad"); MainHero.HurtHero(Farquaad.Attack());
                      Console.WriteLine("Farquaad attacked " + MainName); Farquaad.HurtEnemy(MainHero.Attack());
                      Console.ReadLine();*/




                }




            }




           









































            /*Hero h = new Hero();

            h.Xp = 100; // bestämma värdet av variabeln

            Console.WriteLine(h.Xp); // skriva ut variabeln men det är inte en variael då det körs i kod block
            Console.ReadLine();

            Console.WriteLine(h.Name);
            Console.ReadLine(); */

        }
    }
}
