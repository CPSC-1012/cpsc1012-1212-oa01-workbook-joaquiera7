using System;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 5");
            Console.WriteLine("Investment Calculator");
            //get user input
            Console.WriteLine("Enter investment amount:");
            double investmentAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter annual interest rate in percentage:");
            double interestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of years:");
            double numberOfYears = double.Parse(Console.ReadLine());

            //calculate
            double monthlyInterestRate = interestRate / 12 / 100;
            double futureInvestmentValue = investmentAmount * (Math.Pow(1 + monthlyInterestRate,numberOfYears*12));

            //display result
            Console.WriteLine($"The future value is {futureInvestmentValue:f2}.");
        }
    }
}
