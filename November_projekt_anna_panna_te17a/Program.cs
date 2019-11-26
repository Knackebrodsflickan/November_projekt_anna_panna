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
            Console.ReadLine();
            Console.WriteLine("What would you like to name your Hero?"); // change readline to readkey memmo! 
            string MainName = Console.ReadLine(); //keep

            Console.WriteLine("Your Hero´s name is: " + MainName + "!");
            Console.ReadLine();

            Hero MainHero = new Hero();

            Enemy Farquaad = new Enemy();
            Enemy TheFairyGodMother = new Enemy();
            Enemy PrinceCharming = new Enemy();

            Console.WriteLine("Which enemy would you like to battle first? Here are your options: ");
            Console.WriteLine("Farquuad");
            Console.WriteLine("The Fairy Godmother");
            Console.WriteLine("Prince Charming");
            string ReadEnemyName = Console.ReadLine();
            if(ReadEnemyName != "Farquaad" && ReadEnemyName != "The Fairy Godmother" && ReadEnemyName != "Prince Charming")
            {
                Console.WriteLine("Uh oh! that is not one of your enemies - if you feel like fighting with someone not on this list try reddit :)");
                Console.ReadLine();
            }
            else if(ReadEnemyName == "Farquaad" || ReadEnemyName == "The Fairy Godmother" || ReadEnemyName == "Prince Charming")
            {
                Console.WriteLine("Good choice! You decided the Enemy: " + ReadEnemyName);
                Console.WriteLine("Time to start the show! Can we get a count down?");
                Console.ReadLine();

                Console.WriteLine("Three");
                Thread.Sleep(500);
                Console.WriteLine("Two");
                Thread.Sleep(500);
                Console.WriteLine("One!");
                Thread.Sleep(500);
                Console.WriteLine("Let the games begin!");
                Console.ReadLine();

                if(ReadEnemyName == "Farquaad")
                {
                

                    Console.WriteLine("Farquaad hp: " + Farquaad.getHpEnemy());
                    Console.WriteLine(MainName + " hp: " + MainHero.getHpHero());
                    Console.ReadKey();

                    while (Farquaad.getHpEnemy() > 0 && MainHero.getHpHero() > 0)
                    {
                        MainHero.HurtHero(Farquaad.Attack());
                        Farquaad.HurtEnemy(MainHero.Attack());
                        Console.WriteLine("This is how its going so far");
                        Console.WriteLine("Farquaad hp: " + Farquaad.getHpEnemy());
                        Console.WriteLine(MainName + " hp: " + MainHero.getHpHero());
                        Console.ReadKey();
                        Console.WriteLine();
                    }

                    if (MainHero.getHpHero() <= 0)
                    {

                        Console.WriteLine("Uh oh! im sorry " + MainName + ", it looks like you lost! try again?");
                        Console.ReadKey();
                    }
                    else if (Farquaad.getHpEnemy() <= 0)
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
