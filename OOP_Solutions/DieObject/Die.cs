using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieObject
{
    /// <summary>
    /// This class models a 6-sided and a 12-sided die.
    /// </summary>
    public class Die
    {
        //define data field for die
        private int _sides;
        private int _value;

        //define properties to encapsulate access to the data fields
        public int Sides
        {
            get { return _sides; }
            set
            {
                if (value != 6 || value != 12)
                {
                    throw new Exception($"Die sides must either be 6 or 12.");
                }
                _sides = value;
            }
        }

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
            }
        }

        /// <summary>
        /// A 6 sided die.
        /// </summary>
        /*public Die()
        {
            _sides = 6;
        }*/

        /// <summary>
        /// Sides must be 6 or 12.
        /// </summary>
        /// <param name="numSides"></param>
        public Die(int numSides)
        {
            _sides = numSides;
            Roll();
        }

        public void Roll()
        {
            Random rand = new Random();
            _value = rand.Next(1, _sides + 1);
        }
    }
}
