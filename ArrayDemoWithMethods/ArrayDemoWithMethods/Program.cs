using System;

namespace ArrayDemoWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuickPicks;
            //Prompt the user for the number of quick picks
            Console.Write("Number of quick picks: ");
            numberOfQuickPicks = int.Parse(Console.ReadLine());

            //for each quick pick generate 7 random numbers between 1-50 by calling GenerateNumbers method
            int[] lottoNumbers = GenerateNumbers(1, 50, 7);

            //Display all the numbers generated
            DisplayNumbers(lottoNumbers);
        }

        static int[] GenerateNumbers(int minValue, int maxValue, int numberCount)
        {
            //Declare and create a new int array of size numberCount
            int[] numberArray = new int[numberCount];
            //Create a new random object that we can use to generate random numbers
            Random rand = new Random();
            //Assign a random number between minValue and maxValue for each element in the array
            //maxValue is inclusive
            for (int index = 0; index < numberCount; index++)
            {
                //Generate a random number between minValue and maxValue
                //Add the random number to the array only if it is not a duplicate
                //Hint: You can call the isDuplicateNumber method
                int randomNumber = rand.Next(minValue, maxValue + 1);
                if (IsDuplicateNumber(randomNumber, numberArray))
                {
                    numberArray[index] = rand.Next(minValue,maxValue);
                }

                //numberArray[index] = rand.Next(minValue, maxValue + 1);
            }

            // sort the numberArray ascending from smallest to largest
            Array.Sort(numberArray);

            return numberArray;
        }

        static bool IsDuplicateNumber(int number, int[] numberArray)
        {
            bool isDuplicate = false;
            //Set isDuplicate to true if number is in numberArray
            for (int index = 0; index < numberArray.Length; index++)
            {
                if (numberArray[index] == number)
                {
                    isDuplicate = true;
                    index = numberArray.Length; //good technique to  exit for loop
                }
            }

            return isDuplicate;
        }

        static void DisplayNumbers(int[] numberArray)
        {
            //Display each element in the numberArray seperated by one emptyspace
            Console.Write("The winning lotto numbers are: ");
            /*for (int index = 0; index < numberArray.Length; index++)
            {
                Console.Write($"{numberArray[index]} ");
            }
            Console.WriteLine();*/

            foreach (int number in numberArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            
        }
    }
}
