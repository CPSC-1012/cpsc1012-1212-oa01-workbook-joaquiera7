//Purpose : Calculate the sum of a three-digit whole number.
//input :   userNumber (three-digit whole number)
//output:   usernumber, sum of the userNumber
//Algorithm:Step 1)prompt for user input(userNumber)
//          Step 2)isolate numbers
//          Step 3)calculate for sum
//          Step 4)Display userNumber and sum

using System;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Three-Digit Sum\n");

            //promt user input
            Console.Write("Enter a three-digit whole number: ");
            int userNumber = int.Parse(Console.ReadLine());

            //isolate numbers
            int firstNumber = userNumber / 100;

            int secondNumber = (userNumber / 10) % 10;

            int thirdNumber = userNumber % 10;

            //calculate sum of the isolated numbers
            int sum = firstNumber + secondNumber + thirdNumber;

            //display user input and it's sum

            Console.WriteLine($"{userNumber} --> sum = {sum}");
            Console.ReadLine();


        }
    }
}
