using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProblems1
{
    internal class Student
    {
        //define data fields to store data
        private string _FirstName;
        private string _LastName;
        private int _IdNumber;

        //define properties to encapsulate access to the data fields
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                //make sure first name is not empty or just white spaces
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine();
                    throw new Exception("First name cannot be null or empty or whitespaces only.");
                }
                _FirstName = value;
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last name cannot be null or empty or whitespaces only.");
                }
                _LastName = value;
            }
        }

        public int IdNumber
        {
            get { return _IdNumber; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Id Number must be a non-negative number or greater than 1.");
                }
                _IdNumber = value;
            }
        }

        //default no-argument constructor
        public Student()
        {

        }

        //parameterized constructor
        public Student(string firstName, string lastName, int idNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdNumber = idNumber;
        }

        //display firstname
        public string GetFirstName()
        {
            return _FirstName;
        }

        //set first name
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }


        //display last name
        public string GetLastName()
        {
            return _LastName;
        }

        //set last name
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        //display Id number
        public int GetIdNumber()
        {
            return _IdNumber;
        }

        //set id number
        public void SetIdNumber(int idNumber)
        {
            IdNumber = idNumber;
        }

        //Returns student full name
        public string GetFullName()
        {
            string fullName = LastName + " " + FirstName;
            return fullName;
        }


    }
}
