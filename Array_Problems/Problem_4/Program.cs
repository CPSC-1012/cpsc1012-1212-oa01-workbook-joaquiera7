/*Purpose:
 *  Create a program that will allow the user to enter marks for a quiz. The user will
 *  need the ability to enter the following:
 *  -The total for the quiz
 *  -Up to, but no more than, 25 quiz marks and corresponding student names
 *  
 *  Once the data has been entered, display a menu of options to the user to allow
 *  for the following:
 *  -View all marks
 *  -View the highest mark
 *  -View the lowest mark
 *  -Find the mean average of the marks
 *  -Quit the program
 *  
 */

using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quizTotal = QuizTotal();
            //arrays
            string[] studentName = new string[] { };
            int[] studentMark = new int[quizTotal] { };


            

            //assign names to array studentName
            for (int index = 0; index < quizTotal; index++)
            {
                studentName[index] = StudentName();
                studentMark[index] = StudentMark();
            }

            //Print
            Console.WriteLine($"Quiz Total: {quizTotal}");
            Console.WriteLine("{0, -20} {1,5}", "Student Name", "Mark");
             
        }

        static int QuizTotal()
        {
            //Quiz Total
            int quizTotal = 0;

            bool isValid = false;

            while (isValid == false || quizTotal < 0)
            {
                Console.Write("Enter the quiz total: ");
                isValid = int.TryParse(Console.ReadLine(), out quizTotal);
                if (isValid == false || quizTotal < 0)
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }
            }
            return quizTotal;
        }
       
        static string StudentName()
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            return studentName;
        }

        static int StudentMark()
        {
            int studentMark = 0;
            bool isValid = false;

            while (isValid == false || studentMark < 0)
            {
                Console.Write("Enter student mark: ");
                isValid = int.TryParse(Console.ReadLine(), out studentMark);
                if (isValid == false || studentMark < 0)
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }
            }

            return studentMark;

        }
    }
}
