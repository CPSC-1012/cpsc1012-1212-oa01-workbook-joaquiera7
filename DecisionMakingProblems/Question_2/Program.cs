/*Purpose:  Write a program that will determine the cost of admission for a 
 *          theatre. The price is based on the age of the customer.
 *
 *input:    userAge
 *
 *output:   costAdmission
 *
 *Algorithm:1) Prompt for user's age.
 *          2) Determine the price based on userAge.
 *             - Children 6 and under = FREE ($0.00)
 *             - Students 7 to 17 = $9.80
 *             - Adults 18 to 54 = $11.35
 *             - Seniors 55+ = $10.00
 *          3) Display admission amount.(costAdmission) 
 */

using System;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Theater Admission Price Checker");
            Console.ReadLine();

            //prompt for user's age
            Console.WriteLine("What is the age of the customer?");
            int userAge = int.Parse(Console.ReadLine());

            //Determine the price based on userAge then display result

            if (userAge <= 6)
            {
                Console.WriteLine($"The theatre price is FREE({0:c})");
            }
            else if (userAge > 6 && userAge < 18)
            {
                Console.WriteLine($"The theatre price is {9.80:c}.");
            }
            else if (userAge > 17 && userAge < 54)
            {
                Console.WriteLine($"The theatre price is {11.35:c}.");
            }
            else if (userAge >54)
            {
                Console.WriteLine($"The theatre price is {10:c}.");
            }

        }
    }
}
