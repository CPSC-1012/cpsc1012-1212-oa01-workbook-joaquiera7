/*Purpose:  Modify Exercise_1 (MathTutor01) that allows for multiple attempts to answer the question.
 *          When user answer the question correctly, display the number of atttempts made to answer the question.
 * 
 * input:    userAnswer
 *
 *output:   sum, numberOfAttempts
 *
 *
 *Algorithm:1)display randomly generated math question
 *          2)prompt user for answer (userAnswer)
 *          3)Check if userAnswer is a valid input. If not, prompt again for another answer.
 *          4)Check if userAnswer is correct. Display result
 *          5)Display number of attempts made
 * 
 */

using System;

namespace MathTutor02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userAnswer; //user input
            bool tryAgain = false;
            int numberOfAttempts = 0;   //count number of attempts

            //generate random number
            Random randomNumber = new Random();
            int firstNumber = randomNumber.Next(1, 100);
            int secondNumber = randomNumber.Next(1, 100);

            int sum = firstNumber + secondNumber;   //correct answer

            do
            {
                userAnswer = PromptForIntegerValue($"{firstNumber} + {secondNumber} = ");
                numberOfAttempts++;

                if (userAnswer == sum)
                {
                    Console.WriteLine($"Correct. {numberOfAttempts} attempts made.");
                    tryAgain = false;
                }
                else
                {
                    Console.Write("Incorrect. Try again (y/n)? ");
                    tryAgain = char.ToLower(Console.ReadKey().KeyChar) == 'y' ? true : false;
                    Console.WriteLine();

                    if(tryAgain == false)
                    {
                        Console.WriteLine($"The correct answer is {sum}.");
                    }
                }

            } while (tryAgain == true);
            

            static int PromptForIntegerValue(string message)
            {
                int integerValue = 0;
                Console.Write(message);

                while (int.TryParse(Console.ReadLine(), out integerValue) == false)
                {
                    //input value is not integer
                    Console.WriteLine("Invalid Input. Enter an integer value.");
                    Console.Write(message);      
                }

                return integerValue;   
            }
        }
    }
}
