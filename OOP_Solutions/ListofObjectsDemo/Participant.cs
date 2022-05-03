using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofObjectsDemo
{
    internal class Participant
    {
        //define property for the Name(string), Join Time(DateTime) and Leave Time(DateTime)
        private string _name;
        private DateTime _joinTime;
        private DateTime _leaveTime;

        //define constructor with a parameter for the name and write code to assign JoinTime to current date time
        public string Name
        {
            get { return _name; }
            set
            {
                /*if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name must not be null, empty or white spaces only.");
                }*/

                while (string.IsNullOrWhiteSpace(value))
                {
                    
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            _name = value;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.Write(ex.Message);
                    }

                }

            }
        }

        public DateTime JoinTime
        {
            get { return _joinTime; }
            set { _joinTime = value; }
        }

        public DateTime Leavetime
        {
            get { return _leaveTime; }
            set {_leaveTime = value; }
        }

        //DEfine a constructor with a parameter for the name and write code inside to assign jointime to current date time
        public Participant(/*string name)*/)
        {
            /*Name = name;
            JoinTime = DateTime.Now;*/

        }

        public override string ToString()
        {
            return $"Name: {Name}, Join Time: {JoinTime}, Leave Time: {Leavetime}";
        }

    }
}
