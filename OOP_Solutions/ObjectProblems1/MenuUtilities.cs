using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProblems1
{
    internal class MenuUtilities
    {
        /// <summary>
        /// Pause before exiting menu.
        /// </summary>
        public static void PauseAndExit()
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Checks if number is a positive non-zero integer.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int IsPositiveNumber()
        {
            bool isPositive = int.TryParse(Console.ReadLine(), out int number);
            if (isPositive == false || number < 0)
            {
                Console.Clear();
                Console.WriteLine("Number must be a positive non-zero digit.");
                Console.WriteLine();
            }
            return number;
        }

        /// <summary>
        /// Checks whether the number is valid.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int IsValidNumber()
        {
            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            if (isValid == false)
            {
                Console.WriteLine("Invalid Input. Number must be an integer.");
            }
            return number;
        }

        /// <summary>
        /// Checks whether the number is within minNumber and maxNumber
        /// </summary>
        /// <param name="number"></param>
        /// <param name="minNumber"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static int IsValidNumber(int minNumber, int maxNumber)
        {
            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            if (isValid == false || number < minNumber || number > maxNumber)
            {
                if (isValid == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Number must be an integer.");
                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Number must be between {minNumber} and {maxNumber}.");
                    Console.WriteLine();
                }
            }

            return number;
        }

        /// <summary>
        /// Creates a menu option. Menu option start at 1.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="menuOptions"></param>
        /// <returns></returns>
        public static int GetMenuChoice(params string[] menuOptions)
        {
            //menu options
            for (int index = 0; index < menuOptions.Length;)
            {
                Console.WriteLine($"{index + 1}) {menuOptions[index]}");
                index++;
            }
            Console.WriteLine();
            Console.Write("Make a selection >> ");
            int choice = IsValidNumber(1, menuOptions.Length);
            return choice;
        }

        /// <summary>
        /// Exits program.
        /// </summary>
        public static void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Exiting . . . .");
            Environment.Exit(0);
        }
    }
}
