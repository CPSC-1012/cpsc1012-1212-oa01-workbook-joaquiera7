/*Purpose:  Write a program that will prompt for a number and display positive
 *          if greater than zero, negative if less than zero and zero if equal
 *          to zero.
 *
 *input:    userNumber
 *
 *output:   positive, negative, zero
 *
 *Algorithm:1)prompt for user input
 *          2)check userNumber if positive, negative or zero.
 *          3)Display result
 * 
 * 
 */

using System;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Checker (- , 0 , +)");
            Console.ReadLine();

            //prompt for user input
            Console.Write("Input the the number you want to check: ");
            int userNumber = int.Parse(Console.ReadLine());

            //test userNumber if positive, negative or zero then display result
            if (userNumber > 0)
            {
                Console.WriteLine($"\n{userNumber} is POSITIVE.");
            }
            else  if (userNumber < 0)
            {
                Console.WriteLine($"\n{userNumber} is NEGATIVE.");
            }
            else if (userNumber == 0)
            {
                Console.WriteLine($"\n{userNumber} is EQUAL TO ZERO.");
            }
            else
            {
                Console.WriteLine($"Invalid input.");
            }
            Console.ReadLine();
            Console.WriteLine("Exiting . . . .");


        }
    }
}
