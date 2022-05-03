using System;

namespace Array_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define a constant for the array size
            const int StudentCount = 3;
            //declare and create a new array of int of size StudentCount
            int[] markArray = new int[StudentCount];
            //prompt and read the student marks into each element in the array
            for (int index = 0; index < StudentCount; index++)
            {
                Console.Write($"ENter the mark for student {index + 1}: ");
                markArray[index] = int.Parse(Console.ReadLine());
            }
            //Display each element in the array
            for (int index = 0; index < markArray.Length; index++)
            {
                Console.WriteLine($"Mark for student {index + 1} : {markArray[index]}");
            }
            //display each element in the array using foreach
            foreach (int currentMark in markArray)
            {
                Console.WriteLine($"Mark for student is {currentMark}");
            }
        }
    }
}
