using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Purpose: Create a program that will allow the user to enter up to 25 numbers into an array.           Calculate and display the mean average of the numbers.
             * 
             * Input: userNumber
             * 
             * output: average
             * 
             * Algorithm:   1) Prompt user to enter a number up to 25 numbers (userNumber)
             *              2) Add the number to an array
             *              3) Get average of the number in the array
             *              4) display result
             */

            int userInput;
            bool repeat = false;
            bool isValid = false;
            char YesNo;

            while (repeat == false)
            {
                int[] userNumber = GenerateNumberArray(25, "Enter a number: ");
                Console.Write("Enter a new number (Y/N): ");
                isValid = char.TryParse(Console.ReadLine(), out YesNo);

                if (char.ToLower(YesNo) == 'y')
                {
                    repeat = false;
                }
                else
                {
                    repeat = true;
                }
            }

            //int meanAverage = AverageArray(userNumber);
            //Console.WriteLine($"The average is {meanAverage}");

        }

        //Prompt for user input
        static int[] GenerateNumberArray(int length, string message)
        {
            //Declare and create a new int array of size numberCount
            int[] numberArray = new int[length -1];
            bool isValid  = false;
            int number = 0;

            while (isValid == false)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    for (int index = 0; index < numberArray.Length; index++)
                    {
                        numberArray[index] = number;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            //add number to the array
            for (int index = 0; index < numberArray.Length; index++)
            {
                numberArray[index] = number;
            }

            return numberArray;
        }

        static int AverageArray(int[] array)
        {
            int sumOfArray = 0;
            int averageOfArray = 0;

            foreach (int number in array)
            {
                sumOfArray += number;
                averageOfArray =  sumOfArray / array.Length;
            }
            return averageOfArray;
        }


    }
}
