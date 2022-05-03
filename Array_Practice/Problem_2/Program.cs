/*Purpose: Write a program to read n number of values in an array and display it in reverse order
 * 
 * input: userInput
 * 
 * output: result
 * 
 * resource: https://www.w3resource.com/csharp-exercises/array/index.php
 * 
 */

using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 3 elements in the array
            int[] userArray = new int[3];

            for (int index = 0; index < userArray.Length; index++)
            {
                Console.Write("Element {0}:  ", index);
                userArray[index] = int.Parse(Console.ReadLine());
            }
            //reverse the array
            Array.Reverse(userArray);

            //display elements in reverse order
            foreach (int element in userArray)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
