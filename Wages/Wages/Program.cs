using System;

namespace Wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double regularWages;        //The calculated regular wages
            double basePay = 25;        //The bvase pay rate           
            double regularHours = 40;   //The hours worked less overtime
            double overtimeWages;       //Overtime wages
            double overtimePay = 37.5;  //Overtime pay rate
            double overtimeHours = 10; //Overtime hours worked
            double totalWages;          //Total wages

            //calculate regularWages
            regularWages = basePay * regularHours;

            //calculate overtimeWages
            overtimeWages = overtimePay * overtimeHours;

            //calculate totalWages
            totalWages = regularWages + overtimeWages;
            Console.WriteLine($"Wages for this week is {totalWages:c1}");
        }
    }
}
