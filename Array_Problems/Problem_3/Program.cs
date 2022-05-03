/*Purpose:  
 *  Modify the previous program (make a copy and save as a new project) so that
 *  the program also displays the largest value, the smallest value, and the mode (if
 *  you don’t know what the mode is, look it up) of the numbers. Use a modular
 *  approach in your solution.
 *  
 *  Functions:
 *  LargestNumber(Integer[ ] Nums, Integer Count) As Integer
 *      The method will return the index of the largest number in the array.
 *      
 *  SmallestNumber(Integer[ ] Nums, Integer Count) As Integer
 *      The method will return the index of the smallest number in the array.
 *     
 *  Mode(Integer[ ] Nums, Integer Count) As Integer
 *      The method will return the mode of the numbers (if there is more than one, only
 *      one needs to be shown).
 *  
 * 
 */

using System;
using System.Linq;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumber = new int[25];

            int count = GetUserNumbers(userNumber);
            int meanAverage = MeanAverageOfNumbers(userNumber, count);
            int largestNumber = LargestNumber(userNumber, count);
            int smallestNumber = SmallestNumber(userNumber, count);
            Console.WriteLine($"Array Count = {count}");
            Console.WriteLine($"Mean average = {meanAverage}");
            Console.WriteLine($"Largest Number = {largestNumber}");
            Console.WriteLine($"Smallest Number = {smallestNumber}");

            foreach (int element in userNumber)
            {
                Console.WriteLine(element);
            }

        }

        /// <summary>
        /// The method will load user input numbers into the array and return the count of numbers entered.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static int GetUserNumbers(int[] numbers)
        {
            //counter
            int counter = 0;

            bool isValid = false;

            //prompt for user numbers
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write("Enter a number(Press 'x' to stop): ");
                isValid = int.TryParse(Console.ReadLine(), out numbers[index]);

                if (isValid == false)
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// The method will return the mean average of the numbers in the array.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        static int MeanAverageOfNumbers(int[] numbers, int count)
        {
            int meanAverage = 0;
            int sum = 0;

            //Calculation
            foreach (int element in numbers)
            {
                sum += element;
            }
            
            if (count != 0)
            {
                meanAverage = sum / count;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            return meanAverage;
        }

        /// <summary>
        /// Returns the largest number in the array.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        static int LargestNumber(int[] numbers, int count)
        {
            int largestNumber = numbers[0];
            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > largestNumber)
                {
                    largestNumber = numbers[index];
                }

                if (index == count)
                {
                    index = numbers.Length;
                }
            }

            return largestNumber;
        }

        static int SmallestNumber(int[] numbers, int count)
        {
            /*int smallestNumber = numbers[0];
            for (int index = 0; index < numbers.Length; index++)
            {
                int arrayNumber = numbers[index];

                if (arrayNumber < smallestNumber)
                {
                    smallestNumber = numbers[index];
                }

                if (index == count)
                {
                    index = numbers.Length;
                }
            }*/

            int smallestNumber = numbers.Min();

            return smallestNumber;
        }
    }
}

