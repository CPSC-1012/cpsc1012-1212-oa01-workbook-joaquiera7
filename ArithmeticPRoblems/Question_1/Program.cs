//  Purpose:    Write a program that will prompt the user for three real numbers and computes 
//              their mean average. Display the average to the user.
//  input = firstNumber, secondNumber, thirdNumber
//  output = meanAverage
//Step 1) 

using System;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mean Average Calculator\n");
            //get user input
            Console.Write("Enter the first real number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter thge second real number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the third real number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            //calculate
            double meanAverage = (firstNumber + secondNumber + thirdNumber) / 3;

            //display result
            Console.WriteLine($"\nThe average is {meanAverage}");
            Console.ReadLine();

        }
    }
}
