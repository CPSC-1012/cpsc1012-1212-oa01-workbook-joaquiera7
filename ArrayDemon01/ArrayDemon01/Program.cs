using System;

namespace ArrayDemon01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define a constant for array size
            const int StundentCount = 3;
            //Declare and create a new array of int of size StudenCount
            int [] markArray = new int [StundentCount];
            //Prompt and read the student marks into each element in the array
            for (int index = 0; index < StundentCount; index++)
            {
                Console.Write($"Enter the mark for student {index + 1}: ");
                markArray [index] = int.Parse (Console.ReadLine());
            }
            //Display each element in the array
            for (int index = 0; index < markArray.Length; index++)
            {
                Console.WriteLine($"Mark for the studen {index + 1} {markArray [index]}");
            }
            //Display each eleement in the array using foreach
            foreach (int currentMark in markArray)
            {
                Console.WriteLine($"Mark for student is {currentMark}"  );
            }


        }
    }
}
