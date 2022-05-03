using System;

namespace ParallelArrayDemo01
{
    internal class Program
    {
        //Create a method that is passed in the array of student names and array of student marks
        //and it will print the name of mark of each student
        static void DisplayResult(string[] nameArray, double[] markArray, int studentCount)
        {
            Console.WriteLine($"{"Student Name",-25} {"Mark",4}");
            Console.WriteLine($"{"------------",-25} {"----",4}");
            for (int index = 0; index < studentCount; index++)
            {
                Console.WriteLine($"{nameArray[index],-25} {markArray[index],4}");
            }

        }

        //TODO 1: Add a method to sort the array by name
        static void SortByName(string[] nameArray, double[] markArray, int studentCount)
        {
            //a bubble sort sorts the array in multiple passes
            //Each pass successfully swaps the neighbouring elements if the elements are not in order.

            for (int indexK = 1; indexK < studentCount; indexK++)
            {
                for (int indexI = 0; indexI < studentCount - indexK; indexI++)
                {
                    if (nameArray[indexI].CompareTo(nameArray[indexI + 1]) > 0)
                    {
                        string tempName = nameArray[indexI];
                        nameArray[indexI] = nameArray[indexI + 1];
                        nameArray[indexI + 1] = tempName;

                        double tempMark = markArray[indexI];
                        markArray[indexI] = markArray[indexI + 1];
                        markArray[indexI + 1] = tempMark;
                    }
                }
            }
        }

        //TODO 2: Add a method to sort the arrays by mark descending
        static void SortByMarksDesc(string[] nameArray, double[] markArray, int studentCount)
        {
            //a bubble sort sorts the array in multiple passes
            //Each pass successfully swaps the neighbouring elements if the elements are not in order.

            for (int indexK = 1; indexK < studentCount; indexK++)
            {
                for (int indexI = 0; indexI < studentCount - indexK; indexI++)
                {
                    if (markArray[indexI] < markArray[indexI + 1])
                    {
                        string tempName = nameArray[indexI];
                        nameArray[indexI] = nameArray[indexI + 1];
                        nameArray[indexI + 1] = tempName;

                        double tempMark = markArray[indexI];
                        markArray[indexI] = markArray[indexI + 1];
                        markArray[indexI + 1] = tempMark;
                    }
                }
            }
        }

        //TODO 3: Add a method to find the index of the student with the highest mark(if there is a tie, return the first)  
        static int IndexOfHighestMark(double[] markArray, int studentCount)
        {
            int highestIndex = 0;
            //assume the first element contains the highest mark
            double highestMark = markArray[0];

            for (int index = 0; index < studentCount; index++)
            {
                if (markArray[index] > highestIndex)
                {
                    //assign the current mark as the highest mark
                    highestMark = markArray[index];

                    //asign the current index as the highest index
                    highestIndex = index;
                } 
            }

            return highestIndex;
        }

        //TODO 4: Add a method to return the average mark in class
        static double AverageMark(double[] markArray, int studentCount)
        {
            double average = 0;
            double sum = 0;
            //Calculation
            //get sum of all marks
            for (int index = 0; index < studentCount; index++)
            {
                sum += markArray[index];
            }
            //get average
            average = sum / studentCount;

            return average;
        }

        //TODO 5: Add a method to display the name and mark of the student with the highest mark
        static void PrintStudentWithHighestMark(string[] nameArray, double[] markArray, int studentCount)
        {
            //find the highest mark
            int indexOfHighestMark = IndexOfHighestMark(markArray, studentCount);

            //print result
            Console.Write("The student with the highest mark: ");
            Console.WriteLine($"{nameArray[indexOfHighestMark]} with a mark of {markArray[indexOfHighestMark]}");
        }

        //TODO 6: Read from a file that contains a list of student nams and student marks

        static void Main(string[] args)
        {
            //Declare a constant for size of the arrays

            const int ArraySize = 5;

            //declare and create a new array of string of size ArraySize for student names
            string[] studentNameArray = new string[ArraySize];
            //declare and create a new array of double of size ArraySize for student marks
            double[] studentMarkArray = new double[ArraySize];

            //declare variable to count the number of students in the class
            int studentCount = 0;

            //Ask the user for number of students in the class
            Console.Write($"Number of students? (Limit of {ArraySize}):  ");
            studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (studentCount <= ArraySize)
            {
                //Ask the user to the name and mark for each student in the class
                for (int index = 0; index < studentCount; index++)
                {
                    //ask the user to enter student name
                    Console.Write("Student Name: ");
                    studentNameArray[index] = Console.ReadLine();
                    //prompt for student mark
                    Console.Write($"{studentNameArray[index]} mark: ");
                    studentMarkArray[index] = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine($"This program does not support more that {ArraySize} students.");
            }

            SortByName(studentNameArray, studentMarkArray, studentCount);
            SortByMarksDesc(studentNameArray, studentMarkArray, studentCount);

            //display result
            DisplayResult(studentNameArray, studentMarkArray, studentCount);
        }
    }
}
