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
        /// This method will prompt and check input for positive integer number.
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
    }
}
