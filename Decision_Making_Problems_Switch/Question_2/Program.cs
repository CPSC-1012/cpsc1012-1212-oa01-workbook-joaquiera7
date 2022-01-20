/*Purpose:  A)Provide solution using switch statement
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
            Console.WriteLine("\t\t\tUnit Converter\n");

            //prompt user input(unitConverter)
            Console.WriteLine("Converter A: Pounds <--> Kilograms");
            Console.WriteLine("Converter B: Fluid Ounces(U.S) <--> Liters");
            Console.WriteLine("Converter C: Inches <--> Centimeters");
            Console.WriteLine("Converter D: Fahrenheit <--> Celsius\n");
            Console.Write("Which converter you want to use" +
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
                    Console.WriteLine("\nOption 1: Pounds --> Kilogram");
                    Console.WriteLine("Option 2: Kilogram --> Pounds");

                    Console.Write("\nOption: ");
                    int optionA = int.Parse(Console.ReadLine());
                    switch (optionA)
                    {
                        //if user looking for kilogram
                        case 1:
                            //prompt user for value of pounds
                            Console.Write("\nPounds: ");
                            userNumber = double.Parse(Console.ReadLine());
                            
                            //calculate kilogram
                            double kilogram = userNumber / 2.2046;
                            //result
                            Console.WriteLine($"{userNumber} pounds = {kilogram} " +
                                              $"kilograms.");
                            break;

                        //if user looking for pounds
                        case 2:
                            //prompt user for value of kilogram
                            Console.Write("\nKilogram: ");
                            userNumber = double.Parse(Console.ReadLine());
                            
                            //calculate pounds
                            double pounds = userNumber * 2.2046;

                            //result
                            Console.WriteLine($"{userNumber} kilograms = {pounds} " +
                                              $"pounds.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid Input.");
                            break;
                    }
                    break;

                //fluid ounces to liter vice versa
                case 'b':
                case 'B':
                    Console.WriteLine("\nOption 1: Fluid Ounces(U.S) --> Liters");
                    Console.WriteLine("Option 2: Liters--> Fluid Ounces(U.S)");

                    Console.Write("\nOption: ");
                    int optionB = int.Parse(Console.ReadLine());
                    switch (optionB)
                    {
                        //if user looking for Fluid Ounces(U.S)
                        case 1:
                            //prompt user for value of Liters
                            Console.Write("\nLiters: ");
                            userNumber = double.Parse(Console.ReadLine());

                            //calculate fluid ounces
                            double fluidOunces = userNumber * 33.8140226;

                            //result
                            Console.WriteLine($"{userNumber} liters = {fluidOunces} "                           +$"fluid Ounces(U.S).");
                            break;

                        //if user looking for liters
                        case 2:
                            //prompt user for value of liters
                            Console.Write("\nFluid Ounces(U.S): ");
                            userNumber = double.Parse(Console.ReadLine());

                            //calculate liters
                            double liters =userNumber / 33.8140226;

                            //result
                            Console.WriteLine($"{userNumber} ounces = {liters}" +
                                                $"liters.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid Input.");
                            break;
                    }
                    break;

                //inches to centimeters
                case 'c':
                case 'C':
                    Console.WriteLine("\nOption 1: inches --> centimeter");
                    Console.WriteLine("Option 2: centimeter --> inches");

                    Console.Write("\nOption: ");
                    int optionC = int.Parse(Console.ReadLine());
                    switch (optionC)
                    {
                        //if user looking for centimeter
                        case 1:
                            //prompt user for value of inches
                            Console.Write("\ninches: ");
                            userNumber = double.Parse(Console.ReadLine());

                            //calculate inches
                            double centimeter = userNumber / 0.39370;
                            //result
                            Console.WriteLine($"{userNumber} inches = " +
                                                $"{centimeter} centimeters.");
                            break;

                        //if user looking for inches
                        case 2:
                            //prompt user for value of centimeter
                            Console.Write("\nCentimeter: ");
                            userNumber = double.Parse(Console.ReadLine());

                            //calculate inches
                            double inches = userNumber * 0.39370;

                            //result
                            Console.WriteLine($"{userNumber} kilograms = " +
                                            $"{inches} inches.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid Input.");
                            break;
                    }
                    break;

                //fahrenheit to celsius
                case 'd':
                case 'D':
                    Console.WriteLine("\nOption 1: fahrenheit --> celsius");
                    Console.WriteLine("Option 2: celsius --> fahrenheit");

                    Console.Write("\nOption: ");
                    int optionD = int.Parse(Console.ReadLine());
                    switch (optionD)
                    {
                        //if user looking for celsius
                        case 1:
                            //prompt user for value of fahrenheit
                            Console.Write("\nFahrenheit: ");
                            userNumber = double.Parse(Console.ReadLine());

                            //calculate celsius
                            double celsius = (userNumber - 32) / 1.800;
                            //result
                            Console.WriteLine($"{userNumber} fahrenheit= " +
                                                $"{celsius} celsius.");
                            break;

                        //if user looking for fahrenheit
                        case 2:
                            //prompt user for value of celsius
                            Console.Write("\nCelsius: ");
                            userNumber = double.Parse(Console.ReadLine());

                            //calculate fahrenheit
                            double fahrenheit = (userNumber * 1.800) + 32;

                            //result
                            Console.WriteLine($"{userNumber} celsius = " +
                                            $"{fahrenheit} fahrenheit.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid Input.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid Input.");
                    break;
            }

            Console.ReadLine();
            Console.WriteLine("Exiting . . . . ");
            Console.ReadKey(true);
            

        }
    }
}
