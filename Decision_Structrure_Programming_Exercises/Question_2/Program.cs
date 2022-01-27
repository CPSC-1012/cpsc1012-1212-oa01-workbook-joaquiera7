/*Purpose:  A program to determine if the input is a leap year.
 * 
 *input:    userInput
 * 
 *output:   result
 * 
 *Algorithm:1)prompt for user input/ year (userInput)
 *          2)calculate if user input is a leap year.
 *              >year is a leapyear if divisible by 4 but not 100
 *              >year is a leapyear if divisible by 4 and 400
 *          3)Display if userInput leap year or not
 */

using System;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tLeap Year Calculator");

            //prompt for a year (userInput)
            Console.Write("\nEnter a year > ");
            int userInput = int.Parse(Console.ReadLine());

            //check if leap year
            if (userInput % 4 == 0)
            {
                if (userInput % 400 == 0 || userInput == 1000)
                {
                    Console.WriteLine($"\nYear {userInput} is a leap year.");
                }
                else if (userInput % 100 == 0)
                {
                    Console.WriteLine($"\nYear {userInput} is NOT a leap year.");
                }
                else
                {
                    Console.WriteLine($"\nYear {userInput} is a leap year.");
                }
            }
            else
            {
                Console.WriteLine($"\nYear {userInput} is NOT a leap year.");
            }
            Console.ReadLine();
            /*if (userInput % 100 == 0 && userInput % 4 == 0)
            {
                Console.WriteLine($"{userInput} is a NOT a leap year.");
            }
            else
            {
                Console.WriteLine($"{userInput} is a leap year.");
            }*/
        }
    }
}
