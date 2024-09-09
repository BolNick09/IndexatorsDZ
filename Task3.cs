using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorsDZ
{
    class IntegerDigits
    {
        private int value;
        public IntegerDigits(int initialValue)
        {
            Value = initialValue;
        }        

        public int Value
        {
            get { return value; }
            set
            {
                int lastDigit = value % 10;
                if (lastDigit >= 0)
                {
                    this.value = SetDigit(this.value, lastDigit);
                }
            }
        }

        public int this[int index]
        {
            set
            {
                if (index >= 0)
                {
                    int lastDigit = value % 10;
                    if (lastDigit >= 0)                    
                        this.value = SetDigit(this.value, lastDigit, index);                    
                }
            }
        }
        private static int SetDigit(int number, int digit, int index = 0)
        {
            int multiplier = (int)Math.Pow(10, index);
            return number - (number % multiplier) + digit * multiplier;
        }
    }
}
