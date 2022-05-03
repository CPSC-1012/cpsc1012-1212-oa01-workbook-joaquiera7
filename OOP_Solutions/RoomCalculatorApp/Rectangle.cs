using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculatorApp
{

    //internal visibility modifier means class is only accessible from within the current project
    //public visibility modifier means class is accessible outside of current project
    public class Rectangle
    {
        //define data fields to store data
        private double _length;
        private double _width;

        //define properties to encapsulate access to the data fields
        public double Length
        {
            get 
            { 
                return _length; 
            }
            set //inside the et block, you can use the 'value' is keyword to check new value being assigned
            { 
                //throw new exception if the new value is zero or negative
                if (value <= 0)
                {
                    throw new Exception("Length must be a positive non-zero number.");
                }
                _length = value; 
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Width must be a positive non-zero number.");
                }
                _width = value;
            }
        }

        //define zero or more constructors to set the data fields or properties to meaningful values
        
        //if the class does not incude any construtor, the compiler will generate a default no-argument constructor
        //a constructor has no return type and is name the same as the class name

        /*public Rectangle() //default no-argument constructor
        {

        }*/
        //define a parameterized(greedy) constructor thgat is passed in the length and width

        public Rectangle()
        {
            _length = 4;
            _width = 5;
        }
        public Rectangle(double newLength, double newWidth)
        {
            //if the properties include validation, always assign the parameter values to the properties instead of the data fields
            //_length = newLength;
            //_width = newWidth;

            Length = newLength;
            Width = newWidth;
        }

        //define instance-level methods that perfrom opertations using data fields or properties
        public double Area()
        {
            return _length * _width;
        }

        //define class-level methods that does not use data fields or properties
        /*public static double Area(double length, double width)
        {
            return length * width;
        }*/
    }
}
