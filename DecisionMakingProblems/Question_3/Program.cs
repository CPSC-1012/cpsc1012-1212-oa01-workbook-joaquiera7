/*Purpose:  Program will display student's name along with a letter grade.
 * 
 * input:   studentName, studentMark
 * 
 * output:  studentName, studentGrade
 * 
 * Algorithm:1)prompt for userName and studentMark
 *           2)identify letter grade by studentMark:
 *              100 – 90 = A, 89 - 80 = B, 79-70 = C, 69-50 = D, 49-0 = F
 *           3)Display result (studentName and studentMark)
 */

using System;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Checker");
            Console.ReadLine();

            //prompt for userName
            Console.Write("Student's name: ");
            string userName = Console.ReadLine();

            //prompt for userMark
            Console.Write("\nStudent's mark: ");
            double userMark = double.Parse(Console.ReadLine());
            Console.ReadLine();

            //identify letter grade by studentMark then display result
            if (userMark <= 100 && userMark >= 90)
            {
                Console.WriteLine($"{userName}'s grade is A.");
            }
            else if (userMark < 90 && userMark > 79)
            {
                Console.WriteLine($"{userName}'s grade is B.");
            }
            else if (userMark < 80 && userMark > 69)
            {
                Console.WriteLine($"{userName}'s grade is C.");
            }
            else if (userMark < 70 && userMark > 49)
            {
                Console.WriteLine($"{userName}'s grade is D.");
            }
            else if (userMark < 50 && userMark >= 0 )
            {
                Console.WriteLine($"{userName}'s grade is F.");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
                Console.ReadLine();
            }

            Console.WriteLine("Exiting . . . . .");
            Console.ReadLine();
        }
    }
}
