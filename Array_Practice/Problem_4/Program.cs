/*Purpose:  Write a program to copy the elements into another array
 * 
 * input: userNumber
 * 
 * output: otherArray
 * 
 * resource: https://www.w3resource.com/csharp-exercises/array/index.php
 * 
 */

using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 3 elements in the array
            int[] simpleArray = new int[3];

            for (int index = 0; index < simpleArray.Length; index++)
            {
                Console.Write($"Element {index}: ");
                simpleArray[index] = int.Parse(Console.ReadLine());
            }

            //copy the elements into new array
            int[] simpleArray2 = new int[3];

            Array.Copy(simpleArray, simpleArray2, simpleArray.Length);

            //display the new array
            Console.WriteLine("The elements stored in the first array are: ");
            foreach (int element in simpleArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            Console.WriteLine("The elements copied into the second array are: ");
            foreach (int element in simpleArray2)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
