using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObject
{
    /// <summary>
    /// This class models Circle shape.
    /// </summary>
    public class Circle
    {
        //define data fields to store data
        private double _radius;

        //define Radius properties to encapsulate access to the data feilds
        public double Radius
        {
            get { return _radius; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Radius must be a positive non-zero number.");
                }
                _radius = value; 
            }
        }

        //define constructos to assign meaningful vcaules to the data
        public Circle()
        {
            _radius = 1;
        }

        public Circle(double newRadius)
        {
            Radius = newRadius;
        }

        public double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
