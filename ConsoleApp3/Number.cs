using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Number
    {
        private int number;
        public void SetNumber(int number) { this.number = number; }
        public static Number operator +(Number obj1, Number obj2)
        {
            Number arr = new Number();
            arr.number = obj1.number + obj2.number;
            return arr;
        }
        public static bool operator ==(Number obj1, Number obj2)
        {
            if (obj1.number == obj2.number) return true;
            else return false;
        }

        public static bool operator !=(Number obj1, Number obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
