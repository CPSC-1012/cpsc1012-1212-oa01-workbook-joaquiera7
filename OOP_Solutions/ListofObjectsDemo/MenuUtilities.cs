using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofObjectsDemo
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
        public static int IsPositiveInteger()
        {
            bool isPositive = int.TryParse(Console.ReadLine(), out int number);
            if (isPositive == false || number < 0)
            {
                Console.Clear();
                Console.WriteLine("Input must be a positive non-zero integer.");
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
            bool IsValid = int.TryParse(Console.ReadLine(),out int number);
            if (IsValid == false)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Number must be an integer.");
                Console.WriteLine();
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

        public static int IsValidNumber(string prompt, int minNumber, int maxNumber)
        {
            Console.Write(prompt);
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
        /// Creates title for the menu. 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="menuOptions"></param>
        /// <returns></returns>

        public static void CreateMenuTitle(string menuTitle)
        {
            //creates title
            Console.WriteLine($"\t{menuTitle}");
            Console.Write($"\t");
            for (int count = 0; count < menuTitle.Length; count++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine();
        }



        /// <summary>
        /// Creates a menu option. Menu option start at 1.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="menuOptions"></param>
        /// <returns></returns>
        public static void CreateMenuOptions(params string[] menuOptions)
        {
            //menu options
            for (int index = 0; index < menuOptions.Length;)
            {
                Console.WriteLine($"{index + 1}) {menuOptions[index]}");
                index++;
            }
            Console.WriteLine();
            /*Console.Write("Make a selection []>> ");
            int choice = IsValidNumber(1, menuOptions.Length);
            return choice;*/
        }

        static public int GetMenuChoice(int minNumber, int maxNumber)
        {

            Console.Write($"Make a selection [{minNumber} - {maxNumber}]>> ");
            int choice = IsValidNumber(minNumber, maxNumber);
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

        /// <summary>
        /// Check whether the int is a positive integer.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        static public int GetSafeInt(string prompt)
        {
            bool isValid = false;
            int safeInt = 0;

            while (isValid == false)
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out safeInt);
                if (isValid == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Number must be an integer.");
                    Console.WriteLine();
                }
            }

            //safeInt = IsPositiveInteger();

            return safeInt;
        }
    }
}
