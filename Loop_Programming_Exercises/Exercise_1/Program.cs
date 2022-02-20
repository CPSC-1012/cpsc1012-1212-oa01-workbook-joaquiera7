/*Purpose:  Write a program that allows the user to answer a randomly generated math question.
 *          Program must be able to handle invalid inputs.
 * 
 *input:    userAnswer
 *
 *output:   result
 *
 *Algorithm:1)display randomly generated math question
 *          2)prompt user for answer (userAnswer)
 *          3)Check if userAnswer is a valid input. If not, prompt again for another answer.
 *          4)Check if userAnswer is correct. Display result
 */

using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userAnswer;
            bool validInput;
            Random randomNumber = new Random();
            string check;

            int firstNumber = randomNumber.Next(1, 100);
            int secondNumber = randomNumber.Next(1, 100);

            int sum = firstNumber + secondNumber;

            Console.Write($"{firstNumber} + {secondNumber} = ");
            validInput = int.TryParse(Console.ReadLine(), out userAnswer);

            while (validInput == false)
            {
                Console.WriteLine("Invalid Input. Try again.");
                Console.Write($"{firstNumber} + {secondNumber} = ");
                validInput = int.TryParse(Console.ReadLine(), out userAnswer);
            }

            if (userAnswer == sum)
            {
                Console.WriteLine("Correct.");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
        }
    }
}
