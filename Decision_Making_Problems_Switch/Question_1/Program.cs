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
            Console.WriteLine("\t\tWelcome to Internet Slowest Provider");
            Console.ReadLine();

            //prompt for user input(servicePackage, numberOfHours
            Console.Write("Pick your service package (A, B, C): ");
            char servicePackage = char.Parse(Console.ReadLine());

            Console.Write("Number of hours you have used: ");
            double numberOfHours = double.Parse(Console.ReadLine());

            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - -\n");
            //base price for packages (not including excess hours)
            double pricePackageA = 9.95;
            double pricePackageB = 13.95;
            double pricePackageC = 19.95;

            //identify which package to use for calculation then display result
            //use userBill for output
            double userBill;
            switch (servicePackage)
            {
                //Package A
                case 'A':
                case 'a':
                    switch (numberOfHours)
                    {
                        //less than or equal to 10 hrs
                        case <= 10:
                            userBill = pricePackageA;
                            Console.WriteLine($"Your monthly bill is {userBill:c2}.");
                            break;
                        //over 10 hours
                        case > 10:
                            userBill = pricePackageA + ((numberOfHours - 10) * 2);
                            Console.WriteLine($"Your monthly bill is {userBill:c2}.");
                            break;
                        default:
                            break;
                    }
                    break;
                
                //Package B
                case 'B':
                case 'b':
                    {
                        switch (numberOfHours)
                        {
                            //less than or equal 20hrs
                            case <= 20:
                                userBill = pricePackageB;
                                Console.WriteLine($"Your monthly bill is {userBill:c2}.");
                                break;
                            //over 20hrs
                            case > 20:
                                userBill = pricePackageB - ((numberOfHours - 20) * 1);
                                Console.WriteLine($"Your monthly bill is {userBill:c2}.");
                                break;
                        }
                        break;
                    }

                //Package C
                case 'C':
                case 'c':
                    userBill = pricePackageC;
                    Console.WriteLine($"Your monthly bill is {userBill:c2}.");
                    break;
                default:
                    Console.WriteLine("\nInvalid Input.");
                    break;
            }

            Console.WriteLine("\nPress any key to exit . . . .");
            Console.ReadKey(true);
            
        }
    }
}
