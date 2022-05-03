/*Purpose:  Update your solution to the previous problem (make a copy and save as a new project) to use             two methods with the following signatures in your solution:

            Function GetUserNumbers(Integer[ ] Numbers) As Int
                The method will load user input numbers into the array and return the count of numbers entered.

            Function MeanAverageOfNumbers(Integer[ ] Numbers, Integer Count) As Integer
                The method will return the mean average of the numbers in the array.
 * 
 */

using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumber = new int[25];
            

            int count = GetUserNumbers(userNumber);
            Console.WriteLine(MeanAverageOfNumbers(userNumber, count));

        }

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

        static int MeanAverageOfNumbers(int[] numbers, int count)
        {
            int meanAverage = 0;
            int sum = 0;

            //Calculation
            foreach (int element in numbers)
            {
                sum += element;
            }
            meanAverage = sum / count;


            return meanAverage;
        }
    }
}
