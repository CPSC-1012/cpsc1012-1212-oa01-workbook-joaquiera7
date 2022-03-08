using System;
using Cpsc1012;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Purpose:  - Write a program to tally up total change from user's pocket.
             *          - The method GetTotal() will have number of pennies, nickels, dimes, quarters,
             *            loonies, toonies passed into it and will return the total amount.
             *          - All values entered must be integers and positive.
             *          
             *input:    pennies, nickels, dimes, quarters, loonies, toonies
             *
             *output:   coinTotal
             * 
             */

            //user inputs
            int pennies = 0;
            int nickels = 0;
            int dimes = 0;
            int quarters = 0;
            int loonies = 0;
            int toonies = 0;

            //result
            double coinTotal = 0;

            //Program Start here
            Console.WriteLine("Coin Calculator");
            Console.WriteLine();
            pennies = Utilities.PromptForPositiveNumber("How many pennies(1 cent): ");
            //Console.WriteLine(pennies);
            nickels = Utilities.PromptForPositiveNumber("How many nickels(5 cents): ");
            dimes = Utilities.PromptForPositiveNumber("How many dimes(10 cents): ");
            quarters = Utilities.PromptForPositiveNumber("How many quarters(25 cents): ");
            loonies = Utilities.PromptForPositiveNumber("How many loonies(1 dollar): ");
            toonies = Utilities.PromptForPositiveNumber("How many toonies(2 dollars): ");
            
            //calculate coin total using method GetTotal()
            coinTotal = GetTotal(pennies, nickels, dimes, quarters, loonies, toonies);

            //display result
            Console.WriteLine();
            Console.WriteLine($"Your total change is {coinTotal:c}");
        }

        /// <summary>
        /// Tally up total change.
        /// </summary>
        /// <param name="pennies"></param>
        /// <param name="nickels"></param>
        /// <param name="dimes"></param>
        /// <param name="quarters"></param>
        /// <param name="loonies"></param>
        /// <param name="toonies"></param>
        /// <returns></returns>
        static double GetTotal(
            int pennies,
            int nickels,
            int dimes,
            int quarters,
            int loonies,
            int toonies)
        {
            double totalAmount = 0;

            totalAmount = (pennies * 0.01) + (nickels * 0.05) + (dimes * 0.1) + (quarters * 0.25) + loonies + (toonies * 2);

            return totalAmount;
        }
    }
}