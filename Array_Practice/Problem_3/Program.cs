/*Purpose: Write a program to find the sum of all elements in of the array
 * 
 * input: userInput
 * 
 * output: sum
 * 
 * resource: https://www.w3resource.com/csharp-exercises/array/index.php
 * 
 */

using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 3 elements in the array
            int[] userArray = new int[3];

            //prompt for numbers
            for (int index = 0; index < userArray.Length; index++)
            {
                Console.Write("Element {0}: ", index);
                userArray[index] = int.Parse(Console.ReadLine());
            }

            //declare sum variable
            int sum = 0;

            for (int index = 0; index < userArray.Length; index++)
            {
                sum += userArray[index];
            }

            //display result
            Console.WriteLine($"The sum of all elements in the array is: {sum}.");

            
        }
    }
}
