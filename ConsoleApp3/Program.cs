using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Number object1 = new Number();
            Number object2 = new Number();
            object1.SetNumber(5);
            object2.SetNumber(17);
            Console.WriteLine(object1 == object2);
            Console.ReadKey();

        }
    }
}
