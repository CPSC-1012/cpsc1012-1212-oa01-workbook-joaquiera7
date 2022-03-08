using System;
using Cpsc1012;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Purpose:  - Write a program that will return the number of seconds from hours, minutes, seconds.
             *          - use method CalculateSeconds()
             *          
             *Input:    userHours, userMinutes, userSeconds
             *
             *Output:   totalSeconds
             * 
             */

            //user inputs
            int userHours = 0;
            int userMinutes = 0;
            int userSeconds = 0;

            //result
            int totalSeconds = 0;

            Console.WriteLine("Seconds Calculator");
            Console.WriteLine();
            userHours = Utilities.PromptForPositiveNumber("How many hours?: ");
            userMinutes = Utilities.PromptForPositiveNumber("How many minutes?: ");
            userSeconds = Utilities.PromptForPositiveNumber("How many seconds?: ");

            //call method CalculateSeconds() to calculate total seconds.
            totalSeconds = CalculateSeconds(userHours, userMinutes, userSeconds);

            //display result (total seconds)
            Console.WriteLine();
            Console.WriteLine($"The total in seconds is {totalSeconds} seconds.");
        }

        static int CalculateSeconds(int hours, int minutes, int seconds)
        {
            int totalInSeconds = 0;

            //calculate
            totalInSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;

            return totalInSeconds;
        }
    }
}
