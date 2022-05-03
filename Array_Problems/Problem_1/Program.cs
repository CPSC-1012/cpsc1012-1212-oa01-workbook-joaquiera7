/*Purpose:  Create a program that will allow the user to enter up to 25 numbers into an array.
 *          Calculate and display the mean average of the numbers.
 *          
 *Input:    userNumber
 *
 *Output:   meanAverage
 * 
 */

using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] userArray = { };

            bool isValid = false;

            int elementCount = 0;

            int sum = 0;
            int meanAverage = 0;

            for (int index = 0; index < userArray.Length; index++)
            {
                Console.Write("Enter a number(Press 'x' to stop): ");
                isValid = int.TryParse(Console.ReadLine(), out userArray[index]);

                if (isValid == false)
                {
                    break;
                }
                else
                {
                    elementCount++;
                }
            }

            //Calculations
            //Calculate sum
            foreach (int element in userArray)
            {
                sum += element;
            }
            meanAverage = sum / elementCount;

            Console.WriteLine(elementCount);
            Console.WriteLine("Code is here.");
            Console.WriteLine(meanAverage);
            /*int element = 0;
            bool isValid = false;

            UserArray(25);*/




        }
    }
}
