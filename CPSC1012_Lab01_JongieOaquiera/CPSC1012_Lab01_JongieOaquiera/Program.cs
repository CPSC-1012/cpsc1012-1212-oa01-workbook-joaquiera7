/*Purpose:  To calculate the subtotal and tax total as well as  provincial and federal sales 
 *          tax of items.
 * 
 * input:   itemPrice, itemQuantity
 * 
 * output:  subTotal, priceTotal, taxTotal, taxProvincial, taxFederal 
 * 
 * Section 0A1
 */

using System;

namespace CPSC1012_Lab01_JongieOaquiera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to \"You're-Taxed-For-Everything\" Store\n");

            //get user input (itemPrice)
            Console.Write("Enter the price of an item: ");
            double itemPrice = double.Parse(Console.ReadLine());

            //get user input (itemQuantity)
            Console.Write("Enter the quantity being purchased: ");
            double itemQuantity = double.Parse(Console.ReadLine());
            Console.ReadLine();

            //calculate(subTotal)
            double subTotal = itemPrice * itemQuantity;

            //Tax rates
            //taxRateProvincial
            double taxRateProvincial = 0.06;

            //taxRateFederal
            double taxRateFederal = 0.05;

            //calculate(taxProvincial)
            double taxProvincial = subTotal * taxRateProvincial;

            //calculate(taxFederal)
            double taxFederal = subTotal * taxRateFederal;

            //calculate(taxTotal)
            double taxTotal = taxProvincial + taxFederal;

            //calculate(priceTotal)
            double priceTotal = subTotal + taxProvincial + taxFederal;

            //display result
            Console.WriteLine("Invoice Summary");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Sub Total: \t\t{subTotal:C2}\n");
            Console.WriteLine($"Provincial Tax: \t{taxProvincial:C2}");
            Console.WriteLine($"Federal Tax: \t\t{taxFederal:C2}");
            Console.WriteLine($"Total Tax: \t\t{taxTotal:C2}\n");

            Console.WriteLine($"Price total: \t\t{priceTotal:C2}");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\nThank you for your purchase, come again.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
