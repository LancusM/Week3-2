using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_2
{
    internal class Program
    {
        /*In the details of the assignment, it has an example method as public static int[] RollDice()
         *I don't know if that is the necessary way to have it, as I am not sure what the int[] part does,
         *but I think I did good for being sick this week. :) */
        static void RollDice()
        {
            //Now I know Random exists! I understand it pretty well, so I hope it's good
            Random random = new Random();
            int die1 = random.Next(1, 6);
            int die2 = random.Next(1, 6);
            
            Console.WriteLine("You got a " + die1 + " and a " + die2);
            
            Console.ReadLine();
            return;
            //I'm not sure if the return is required or not. Maybe?
        }
        static void Main(string[] args)
        {
            //Prompts user, but pressing anything activates the first roll
            Console.WriteLine("Roll the dice!");
            Console.ReadLine();
            RollDice();
            //Function plays out minimum of once, user input to continue
            Console.WriteLine("Roll again? Y/N");
            string oneMore = Console.ReadLine();

            while (oneMore != "N")
            {
                //loop to continue rolling until oneMore = N
                RollDice();
                Console.WriteLine("Roll again? Y/N");
                oneMore = Console.ReadLine();
            }
            
        }
    }
}
