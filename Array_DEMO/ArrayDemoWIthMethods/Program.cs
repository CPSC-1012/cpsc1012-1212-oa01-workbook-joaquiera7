using System;
using System.IO;    //for streamWriter class

namespace ArrayDemoWIthMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modify the program to implement a menu-driven system where the user can:
            //1) Generate a lotto quick picks
            //2) Read lotto quick picks from a file
            //3) Quit program

            int menuSelected = 0;

            //1) Generate a looto quick picks
            //2) Read lotto quick picks from a file
            //3) Quit program

            bool notValid = false;

            //check if input is valid
            while (notValid == false ||menuSelected != 3)
            {
                Console.WriteLine("LOTTO NUMBER GENERATOR");
                Console.WriteLine();
                Console.WriteLine("1) Generate a lotto quick picks");
                Console.WriteLine("2) Read lotto quick picks from a file");
                Console.WriteLine("3) Quit Program");
                Console.WriteLine();
                Console.Write("Select one [1-3]: ");
                notValid = int.TryParse(Console.ReadLine(), out menuSelected);

                if (notValid == false || menuSelected < 1 || menuSelected > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Try again");
                    Console.WriteLine();
                }

                switch (menuSelected)
                {
                    case 1:
                        Console.Clear();
                        //Prompt the user for the number of quick picks
                        int quickPicks;

                        quickPicks = PromptForQuickPicks();

                        //Ask the user if they want to write the numbers to a file
                        //IF yes, then prompt for a filename and write the generated numbers
                        Console.Write("Would you like to write the numbers to a file? [y/n]: ");
                        bool writeToFile = char.ToLower(Console.ReadKey().KeyChar) == 'y' ? true : false;
                        if (writeToFile)
                        {
                            Console.WriteLine();
                            //ask the user for the file name
                            Console.Write(@"Enter the file path to write to (ex. D:\temp\mar09.txt): ");
                            string dataExportFilePath = Console.ReadLine();
                            try
                            {
                                StreamWriter writer = new StreamWriter(dataExportFilePath);
                                for (int counter = 0; counter < quickPicks; counter++)
                                {
                                    //generate random numbers
                                    int[] randomNumbers = GenerateNumbers(1, 50, 7);
                                    int index = 0;
                                    foreach (int lottoNumber in randomNumbers)
                                    {
                                        writer.Write(lottoNumber);

                                        if (index < (randomNumbers.Length - 1))
                                        {
                                            writer.Write(",");
                                        }
                                        index++;
                                    }
                                    writer.WriteLine();
                                }
                                writer.Close();
                                Console.WriteLine($"Successfully wrote numbers to {dataExportFilePath}");
                            }
                            catch (Exception ex)
                            {
                                //report the exception to the user
                                Console.WriteLine($"Error writing to a file to exception: {ex.Message}");
                            }
                        }
                        else
                        {
                            //For each quick pick, generate 7 random numbers between 1 and 50 by calling
                            //GenerateNumbers method
                            //Display all the numbers generated
                            Console.WriteLine();
                            for (int counter = 0; counter < quickPicks; counter++)
                            {
                                //generate random numbers
                                int[] randomNumbers = GenerateNumbers(1, 50, 7);
                                //dispay result
                                Console.Write($"QuickPick #{counter + 1} --> ");
                                DisplayNumber(randomNumbers);
                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press any key to go back to menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        ReadLottoQuickPicksFromFile();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to go back to menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Exiting . . . .");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }

        }
        //---------METHODS
        /// <summary>
        /// Prompt for number of quick picks.
        /// </summary>
        /// <returns></returns>
        static int PromptForQuickPicks()
        {
            int numberOfQuickPicks = 0;
            bool isValid = false;

            //prompt user for quick picks
            //check whether the input is valid
            while (isValid == false || numberOfQuickPicks < 0)
            {
                Console.Write("Number of quick picks: ");
                isValid = int.TryParse(Console.ReadLine(), out numberOfQuickPicks);
                if (isValid == false || numberOfQuickPicks < 0)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();
                }
            }

            return numberOfQuickPicks;
        }

        /// <summary>
        /// Check whether number is in the array.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numberArray"></param>
        /// <returns></returns>
        static bool IsDuplicateNumber(int number, int[] numberArray)
        {
            bool isDuplciate = false;

            //Set isDuplicate to true if number is in numberArray
            /*foreach (int element in numberArray)
            {
                if (element == number)
                {
                    isDuplciate = true;
                }
            }*/
            for (int index = 0; index < numberArray.Length; index++)
            {
                if (numberArray[index] == number)
                {
                    isDuplciate = true;
                    index = numberArray.Length; 
                }
            }

            return isDuplciate;
        }

        /// <summary>
        /// Generate random numbers and turn it into array.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="numberCount"></param>
        /// <returns></returns>
        static int[] GenerateNumbers(
            int minValue,
            int maxValue,
            int numberCount)
        {
            //Declare and create a new int array of size numberCount
            int[] numberArray= new int[numberCount];
            //create and create a new random object that we can use to generate numbers
            Random rand = new Random();
            //assign a random number between minValue and maxValue for each element in the array
            for (int index = 0; index < numberCount;)
            {
                //Geerate a random number between minValue and maxValue
                //Add the random number to the array ONLY IF it is not a duplicate
                //Hint: You can call the IsDuplicateNumber method
                int generatedNumber = rand.Next(minValue, maxValue + 1);
                if (IsDuplicateNumber(generatedNumber, numberArray) == false)
                {
                    numberArray[index] = generatedNumber;
                    index++;
                }

            }
            //Sort the numberArray ascending from smallest to largest
            //Hint: The Array class has a static class-level method for sorting
            Array.Sort(numberArray);

            return numberArray;
        }

        static void DisplayNumber(int[] numberArray)
        {
            //Display each element in numberArray separated by one empty space
            foreach (int element in numberArray)
            { 
                Console.Write($"{element} ");
            }
        }


        static void ReadLottoQuickPicksFromFile()
        {
            //ask the user for the file path
            Console.Write("Enter the location of the data file: ");
            string dataImportFilePath = Console.ReadLine();
            //Read from the file path one line at a time and write the screen each line tahat is read
            try
            {
                StreamReader reader = new StreamReader(dataImportFilePath);
                while (reader.EndOfStream == false)
                {
                    //read the current line and move the input cursor to the next line
                    string currentLine = reader.ReadLine();
                    //print the current line
                    Console.WriteLine(currentLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file {dataImportFilePath} with exception {ex.Message}");
            }
        }
    }

    
}
