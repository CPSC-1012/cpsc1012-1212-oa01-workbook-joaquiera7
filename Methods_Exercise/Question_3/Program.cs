using System;
using Cpsc1012;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Purpose:  - Write a program to calculate pay.
             *          - Use a method called CalculatePay() which will passed in hours and pay rate
             *          and will return gross pay.
             *          - Validation for input required to be a non-negative value.
             *
             *Input:    hours, hourlyPayRate
             *
             *Output:   grossPay;
             * 
             */

            //user input
            double hours = 0;
            double hourlyPayRate = 0;

            //result
            double grossPay;

            //Prompt for user input
            Console.WriteLine("Gross Pay Calculator");
            Console.WriteLine();
            hours = Utilities.PromptForPositiveNumber("Hours worked: ");
            hourlyPayRate = Utilities.PromptForPositiveNumber("Hourly Pay Rate: ");

            //call CalculatePay() to return grossPay for the employee
            grossPay = CalculatePay(hours, hourlyPayRate);

            //display result
            Console.WriteLine();
            Console.WriteLine($"The total gross pay is {grossPay:c}.");
        }

        /// <summary>
        /// Calculates gross pay.
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="hourlyPayRate"></param>
        /// <returns></returns>
        static double CalculatePay(double hours, double hourlyPayRate)
        {
            double grossPay;

            if (hours <= 40)
            {
                grossPay = hours * hourlyPayRate;
            }
            else if (hours <= 50)
            {
                grossPay = (40 * hourlyPayRate) + (1.5 * hourlyPayRate * (hours - 40));
            }
            else
            {
                grossPay = (40 * hourlyPayRate) + (1.5 * hourlyPayRate * 10)
                    + (2 * hourlyPayRate * (hours - 50));
            }

            return grossPay;
        }

    }
}
