using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpsc1012
{
    public class Utilities
    {
        /// <summary>
        /// This method will prompt and check input for positive non - zero integer number.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>number</returns>
        static public int PromptForPositiveNumber(string message)
        {
            int number = 0;
            bool validNumber = false;

            while (validNumber == false)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                    {
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Must be a positive non-zero number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Input must be an integer number.");
                }
            }
            return number;
        }

        /// <summary>
        /// This method will prompt and check input for positive integer number that is between min and max.
        /// </summary>
        /// <param name="min">The minimum number allowed.</param>
        /// <param name="max">The maximum number allowed.</param>
        /// <param name="message"></param>
        /// <returns></returns>
        static public int PromptForPositiveNumber(int min, int max, string message)
        {
            int number = 0;
            bool validNumber = false;

            while (validNumber == false)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= min && number <= max)
                    {
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. Must enter a number between {min} and {max}.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Input must be an integer number.");
                }
            }
            return number;
        }
        static public double PromptForDoublePositiveOrZero(string message)
        {
            double number = 0;
            bool validNumber = false;

            while (validNumber == false)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 0)
                    {
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Must be a positive or zero number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Input must be an integer number.");
                }
            }
            return number;
        }
    }
}
