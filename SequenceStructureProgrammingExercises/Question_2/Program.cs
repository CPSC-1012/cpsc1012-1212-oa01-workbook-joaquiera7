using System;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 2\n");
            Console.WriteLine("Write a program that reads in the radius and " +
                "length of a cylinder and coutes the area and volume using " +
                "the formulas.");

            //prompt the user
            Console.WriteLine("This is an Area and Volume Calculator of a cylinder.\n");

            //get the radius
            Console.Write("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());

            //get the length
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());

            //calculate for the result
            //Area calculation
            double areaCylinder = (Math.Pow(radius, 2)) * (Math.PI);

            //Length calculation
            double volume = areaCylinder * length;

            //display result
            //------- ask how to display 4 decimal places without rounding off
            Console.WriteLine($"\nThe area is {areaCylinder:f4}");
            Console.WriteLine($"The volume is {volume:f1}");
        }
    }
}
