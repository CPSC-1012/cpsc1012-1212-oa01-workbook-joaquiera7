﻿/*Purpose:  A)Provide solution using switch statement
 *          B)Write a program that can allow the user to perform some unit            conversion.
 *
 *input:    unitConverter (depending on which converter the user want use, 
            user can input the following; pounds, kilograms, liters, fluidOunces, inches, centimeter, fahrenheit, celsius), userNumber 
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
            Console.WriteLine("Unit Converter");
            Console.ReadLine();

            //prompt user input(unitConverter)
            Console.WriteLine("Converter A: Pounds <--> Kilograms");
            Console.WriteLine("Converter B: Fluid Ounces(U.S) <--> Liters");
            Console.WriteLine("Converter C: Inches <--> Centimeters");
            Console.WriteLine("Converter D: Fahrenheit <--> Celsius");
            Console.Write("Pick which converter you want to use" +
                            "(A, B, C, D): ");
            char unitConverter = char.Parse(Console.ReadLine());
            //Console.WriteLine(unitConverter);

            //user input
            double userNumber;

            //prompt user which unit to convert based on unitConverter picked
            switch (unitConverter)
            {
                //Pounds to kilogram vice versa
                case 'a':
                case 'A':
                    Console.WriteLine("Option 1: Pounds --> Kilogram");
                    Console.WriteLine("Option 2: Kilogram --> Pounds");

                    Console.Write("Option: ");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        //if user looking for kilogram
                        case 1:
                            //prompt user for value of pounds
                            Console.Write("Pounds: ");
                            userNumber = double.Parse(Console.ReadLine());
                            
                            //calculate
                            double kilogram = userNumber / 2.2046;
                            //result
                            Console.WriteLine($"{userNumber} pounds = {kilogram} " +
                                              $"kilograms.");
                            break;

                        //if user looking for pounds
                        case 2:
                            //prompt user for value of kilogram
                            Console.Write("Kilogram: ");
                            userNumber = double.Parse(Console.ReadLine());
                            
                            //calculate
                            double pounds = userNumber * 2.2046;

                            //result
                            Console.WriteLine($"{userNumber} kilograms = {pounds} " +
                                              $"pounds.");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;

            }
            

        }
    }
}
