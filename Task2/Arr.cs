using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorsDZ.Task2
{
    public class Arr
    {
        private int size;
        private int currItem;
        private int[] array;

        public Arr(int[] t)
        {

            size = t.Length;
            array = t;
            currItem = 0;
        }
        public int code
        {
            get
            {
                int t = array[currItem];
                currItem = ++currItem % size;
                return t;
            }
            set { array[currItem] = value; }
        }

    }
}
