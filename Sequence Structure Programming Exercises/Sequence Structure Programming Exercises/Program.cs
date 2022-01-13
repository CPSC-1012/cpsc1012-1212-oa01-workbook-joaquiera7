using System;

namespace Sequence_Structure_Programming_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1\n");
            Console.WriteLine("Write a program that displays the message with " +
                "your name, yor age and your expected annual salary.");
            Console.WriteLine("My name is Don Iverson, my age is 45 and i hope to earn" +
                "$204,747.00 per year.");
            Console.WriteLine("\nSolution.......\n");

            //get user input;
            //get user's name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //get user's age
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            //get expected salary
            Console.WriteLine("What is your expected salary?");
            double annualPay = double.Parse(Console.ReadLine());

            Console.WriteLine("Result");
            Console.WriteLine($"My name is {name}, i'm {age} years old, and " +
                $"I hole to earn {annualPay:C} per year.");

            Console.WriteLine("\n-----------------\n");
            
            //Exercise 2
            Console.WriteLine("Exercise 2\n");
            Console.WriteLine("Write a program that reads in the radius and " +
                "length of a cylinder and coutes the area and volume using " +
                "the formulas.");
            
            //prompt the user
            Console.WriteLine("This is an Area and Volume Calculator of a cylinder.");
            
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
            Console.WriteLine($"The area is {areaCylinder:f4}");
            Console.WriteLine($"The volume is {volume:f1}");

            Console.WriteLine("\n-----------------\n");

            Console.WriteLine("Exercise 3\n");

            Console.WriteLine("Write a program that prompts the user to enter" +
                "the side of a hexagon and displays its area.");

            //get user input (side)
            Console.WriteLine("Area of Hexagon Calculator");
            Console.Write("Enter the length of the side: ");
            double side = double.Parse(Console.ReadLine());

            //calculate
            double areaHexagon = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(side, 2);

            //display result
            Console.WriteLine($"The area of the hexagon is {areaHexagon:f4}.");

            Console.WriteLine("\n-----------------\n");

            Console.WriteLine("Exercise 4\n");
            Console.WriteLine("Write a program that reads an integer between" +
                "0 and 1000 and adds all the digits in the integer. For example," +
                "if an integer is 932, the sum of all its digits is 14.");

            //get user input
            Console.WriteLine("Enter a number between 0 and 1000: ");
            int userNumber = int.Parse(Console.ReadLine());

            //calculate



        }
    }
}
