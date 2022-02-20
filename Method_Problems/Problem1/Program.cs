/*Purpose: Create a program that will determine the cost of admission for a theatre using methods.
 * 
 * Input:  age
 * 
 * Output: admissionAmount
 * 
 * Algorithm:   1) Prompt for user age. (age)
 *              2)create method "GetTicketPrice(int age)" that will return the price of the ticket based on age
 *              3)Create method "DisplayMenu"
 * 
 */


using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Children 6 and under = Free ($0.00)");
            Console.WriteLine("Students 7 to 17 = $9.80");
            Console.WriteLine("Adults 18 to 54  = $11.35");
            Console.WriteLine("Seniors 55+ = $10.00");
        }
        static int Age()
        {
            int age;
            bool validInput = int.TryParse;

            Console.Write("What is your current age?: ");
            age = int.Parse(Console.ReadLine());

            
        }
    }
}
