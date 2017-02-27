using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipSim
{
    class CoinFlipSim
    {
        public static void Game()
        {
            int times;
            int heads = 0;
            int tails = 0;

            Console.WriteLine("\nLet's play coin flip. How many times do you want to flip?");

            if (int.TryParse(Console.ReadLine(), out times))
            {
                Console.WriteLine("So, let's flip {0} time(s)!", times);
                
                Random rnd = new Random();

                Console.WriteLine("\n*** 1 is head and 0 is tail ***");
                Console.WriteLine("The result is showing below:");
                for(int i = 1; i <= times; i++)
                {
                    int outcomes = rnd.Next(0, 2);
                    Console.Write("{0,3} ", outcomes);
                    if (i % 10 == 0)
                    { Console.WriteLine(); }
                    if(outcomes == 1)
                    {
                        heads++;
                    }
                    else
                    {
                        tails++;
                    }
                }
                Console.WriteLine("\nThere is/are total of {0} head(s) and {1} tail(s).", heads, tails);

            }
            else
            {
                Console.WriteLine("Please give me a number!");
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Game();

                Console.WriteLine("\nDo you want to play again (y/n)? ");
            } while (Console.ReadLine() != "n");

        }
    }
}
