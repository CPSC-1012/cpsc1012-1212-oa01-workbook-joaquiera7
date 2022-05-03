using System;

namespace ObjectProblems1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxStudentCount = 25;
            int menuSelected = 0;
            int currentStudentCount = 0;

            bool isValid = false;


            Student student = new();

            //arrays
            string[] firstName = new string[MaxStudentCount];
            string[] lastName = new string[MaxStudentCount];
            int[] idNumber = new int[MaxStudentCount];

            //program
            while (isValid == false || menuSelected > 1  || menuSelected < 4)
            {
                menuSelected = MenuUtilities.GetMenuChoice("Add Student", "Display student's full name", "Display class roster", "Exit");

                switch (menuSelected)
                {
                    case 1:
                        Console.Clear();
                        currentStudentCount++;
                        if (currentStudentCount > MaxStudentCount)
                        {
                            Console.WriteLine("Sorry. Limit exceeded.");
                            currentStudentCount--;
                        }
                        else
                        {
                            for (int index = currentStudentCount - 1; index < currentStudentCount; index++)
                            {
                                //get first name
                                try
                                {
                                    Console.Write("First Name: ");
                                    student.FirstName = Console.ReadLine();
                                    firstName[index] = student.FirstName;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    MenuUtilities.PauseAndExit();
                                    currentStudentCount--;
                                    break;
                                }

                                //get last name
                                try
                                {
                                    Console.Write("Last Name: ");
                                    student.LastName = Console.ReadLine();
                                    lastName[index] = student.LastName;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    MenuUtilities.PauseAndExit();
                                    currentStudentCount--;
                                    break;
                                }

                                student.IdNumber = currentStudentCount;
                                idNumber[index] = student.IdNumber;
                                MenuUtilities.PauseAndExit();
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Full Name");
                        Console.WriteLine(student.GetFullName());
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"{"ID",2} {" ", 2} {"Last Name",-25} {" ",2} {"First Name",-25}");
                        Console.WriteLine($"{"--",2} {" ",2} {"---------",-25} {" ",2} {"----------",-25}");
                        for (int index = 0; index < currentStudentCount; index++)
                        {
                            Console.WriteLine($"{idNumber[index],2} {" ",2} {lastName[index],-25} {" ",2} {firstName[index],-25}");
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Total students: {currentStudentCount}");
                        MenuUtilities.PauseAndExit();
                        break;
                    case 4:
                        MenuUtilities.ExitProgram();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
