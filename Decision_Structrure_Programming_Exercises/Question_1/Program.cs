/*Purpose:  to flip a coin and let the user guess whether it's HEAD or TAIL and report if they
 *          guess correctly.
 * 
 * Input:   userGuess
 * 
 * Output:  coinResult
 * 
 * Algorithm:1) prompt the user for their guess if HEAD or TAIL (userGuess)
 *           2) generate random number (0 or 1)
 *              > 0 = Head
 *              > 1 = Tail
 *           3) Display result as well as if the user guess correctly
 * 
 */
using System;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCOIN FLIP");

            //prompt user for their guess
            Console.WriteLine("Take your guess\n\n0 if Heads\n1 if Tails");
            Console.Write("\nYour pick (0 or 1): ");
            int userGuess = int.Parse(Console.ReadLine());
            Console.ReadLine();

            //generate random number
            Random rd = new Random();
            int coinToss = rd.Next(0,2);

            Console.WriteLine(coinToss);

            if  (coinToss == 0) //coin result = heads
            {
                if (userGuess == 0) //userGuess  = heads
                {
                    Console.WriteLine("Coin is Heads. You guess correctly.");
                }
                else
                {
                    Console.WriteLine("Coin is Tails. You guess wrong.");
                }
            }
            else
            {
                if (userGuess == 1) //userGuess = Tails
                {
                    Console.WriteLine("Coin is Tails. You guess correctly.");
                }
                else
                {
                    Console.WriteLine("Coin is Heads. You guess wrong.");
                }
            }

            Console.ReadLine();

        }
    }
}
