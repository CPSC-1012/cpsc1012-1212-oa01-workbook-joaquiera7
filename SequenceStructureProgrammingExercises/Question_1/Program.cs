using System;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1\n");
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
                $"I hope to earn {annualPay:C} per year.");

        }
    }
}
