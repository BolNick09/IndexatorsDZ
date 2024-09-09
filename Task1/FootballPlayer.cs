using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorsDZ.Task1
{
    public class FootballPlayer
    {
        private string name;
        private int number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public FootballPlayer(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }
}
