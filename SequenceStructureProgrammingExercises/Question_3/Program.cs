using System;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 3\n");

            Console.WriteLine("Write a program that prompts the user to enter" +
                "the side of a hexagon and displays its area.");

            //get user input (side)
            Console.WriteLine("Area of Hexagon Calculator");
            Console.Write("\nEnter the length of the side: ");
            double side = double.Parse(Console.ReadLine());

            //calculate
            double areaHexagon = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(side, 2);

            //display result
            Console.WriteLine($"\nThe area of the hexagon is {areaHexagon:f4}.");

            Console.WriteLine("\n-----------------\n");
        }
    }
}
