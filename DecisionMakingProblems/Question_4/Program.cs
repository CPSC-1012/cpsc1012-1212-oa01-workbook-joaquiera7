/*Purpose:  Compute income tax based on taxable income
 * 
 * input:   userIncome
 * 
 * output:  userTax
 * 
 * Algorithm:   1)prompt for user's taxable income (userIncome)
 *              2)calculate tax due based on taxable income.
 *              Up to $50,000 = $0 + 5% of amount over 0$
 *              Up to $100,000 = $2,500 + 7% of amount over $50,000
 *              $100,000 and over = $6000 + 9% of amount over $100,000
 *              3)Display result (userTax)
 */

using System;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Income Tax Calculator");
            Console.ReadLine();

            //prompt for user's taxable income
            Console.Write("Taxable Income: ");
            double userIncome = double.Parse(Console.ReadLine());

            //calculate tax due then display result (userTax)

            //income up to $50,000
            if (userIncome <= 50000)
            {
                double userTax = 0 + (0.05 * userIncome);
                Console.WriteLine($"\nThe tax due is {userTax:C}");
            }
            //income up to $100,000
            else if (userIncome > 50000 && userIncome <= 100000)
            {
                double userTax = 2500 + (0.07 * userIncome);
                Console.WriteLine($"\nThe tax due is {userTax:C}");
            }
            //income over $100,000
            else if (userIncome >100000)
            {
                double userTax = 6000 + (0.09 * userIncome);
                Console.WriteLine($"\nThe tax due is {userTax:C}");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
            Console.ReadLine();

            Console.WriteLine("Exiting . . . .");
            Console.ReadLine();
        }
    }
}
