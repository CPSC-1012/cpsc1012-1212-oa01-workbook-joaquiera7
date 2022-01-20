/*Purpose:  A)Provide solution using switch statement
 *          B)Write a program that can allow the user to perform some unit            conversion.
 *
 *input:    unitConverter (depending on which converter the user want use, 
            user can input the following; pounds, kilograms, liters, fluidOunces, inches, centimeter, fahrenheit, celsius) 
 *
 *output:   result;
 *
 *Algorithm:1) prompt for user input(unitConverter)
 *          1.B) prompt which unit user want to convert.
 *          2)based on which unitConverter chosen, use the following                   conversion formula.
 *           - POUNDS TO KILOGRAMS kg = lb / 2.2046
 *           - FLUID OUNCES (U.S.) TO LITERS 1 liter = 33.8140226 ounces
 *           - INCHES TO CENTIMETERS cm = in / 0.39370
 *           - FAHRENHEIT TO CELSIUS C = (F - 32) / 1.800
 *          3) display result
 */
using System;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
