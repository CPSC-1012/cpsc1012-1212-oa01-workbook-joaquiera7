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
            Console.WriteLine("Hello World!");
        }
    }
}
