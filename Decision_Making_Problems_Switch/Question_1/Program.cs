/*Purpose:  a)Provide solution using "Switch" statement.
 *          b)Write a program for an Internet service provider so they can 
 *            calculate how much to bill their customers.
 *            
 *input:    numberOfHours, servicePackage
 *
 *output:   userbill
 *
 *Algorithm:1)prompt for user input(numberOfHours and servicePackage)
 *          2)based on servicePackage chosen by user, calculate user's bill
 *            (userBill) use;
 *              package A: $9.95 per month for up to 10 hours; additional hours
 *                          are billed at $2.00 per hour
 *              package B: $13.95 per month for up to 20 hours; additional hours 
 *                          are billed at $1.00 per hour
 *              package C: $19.95 per month for unlimited hours
 *          3)display result (userBill)
 * 
 */

using System;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISP");

            //prompt for user input(servicePackage, numberOfHours
            Console.Write("Your service package (A, B, C): ");
            char servicePackage = char.Parse(Console.ReadLine());

            //make the input(servicePackage) lowercase
            //string servicePackageLower = servicePackage.ToLower();

            Console.WriteLine(servicePackage);
            Console.Write("Number of hours you have used: ");
            double numberOfHours = double.Parse(Console.ReadLine());

            //basic formula for packages (not including excess hours)
            double formulaPackageA = 9.95 * numberOfHours;
            double formulaPackageB = 13.95 * numberOfHours;
            double formulaPackageC = 19.95 * numberOfHours;

            //identify which package to use for calculation
            double userBill;
            switch (servicePackage)
            {
                //Package A
                case 'A':
                case 'a':
                    switch (numberOfHours)
                    {
                        case <= 10:
                            userBill = formulaPackageA;
                            Console.WriteLine($"{userBill:c2}");
                            break;
                        case > 10:
                            userBill = formulaPackageA + ((numberOfHours - 10) * 2);
                            Console.WriteLine($"{userBill:c2}");
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }

            
        }
    }
}
