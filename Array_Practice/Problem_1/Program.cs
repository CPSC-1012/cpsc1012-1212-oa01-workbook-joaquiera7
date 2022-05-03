/*Purpose: Write a program in C# to store elements in an array and print it.
 * 
 * input:  userNumber
 * 
 * output: result
 * 
 * resource: https://www.w3resource.com/csharp-exercises/array/index.php
 */

using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 10 elements in the array:
            int[] userArray = new int[10];

            //prompt for input
            for (int index = 0; index < userArray.Length; index++)
            {
                Console.Write("Element {0}: ", index);
                userArray[index] = int.Parse(Console.ReadLine());
            }

            foreach (int element in userArray)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
