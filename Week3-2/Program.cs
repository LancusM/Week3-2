﻿using System;
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

        /* EDIT: For 3-1 and 3-3, I changed the static void to public static, and I've understood it so far. The void doesn't return a value, which is bad in these cases.
         * The public static parts make some sense to me. But, in trying to convert this one, it required the int[] array, which I don't know if I did some part wrong,
         * But none of the variables work with the return value, because the die1 and die2 values are int, which doesn't work with int[]? So I left it as is.
         * I don't understand what it particularly means, but I can get to asking on Monday. */
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
