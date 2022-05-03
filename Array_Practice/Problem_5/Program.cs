/*Purpose: Write a program to count a total number of duplicate elements in an array
 * 
 * input: userInput
 * 
 * output: duplicateCount
 * 
 */

using System;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 3 elements in the array
            int[] simpleArray = new int[3];

            //prompt for elements
            for (int index = 0; index < simpleArray.Length; index++)
            {
                Console.Write($"Element {index}: ");
                simpleArray[index] = int.Parse(Console.ReadLine());
            }
            
            //count duplicate elements
            int duplicateCount = 0;

            for (int index = 0; index < simpleArray.Length - 1; index++)
            {
                if (simpleArray.GetValue(index) == simpleArray.GetValue(index + 1))
                {
                    duplicateCount++;
                }
            }

            Console.WriteLine(duplicateCount);

        }
    }
}
