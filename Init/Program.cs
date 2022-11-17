using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init
{
    internal class Program
    {
        static void Main()
        {
            Point p1 = new Point() { X= 5, Y = 5, Z = 5 };
            Point p2 = new Point() { X = 0, Y = 0, Z = 0 };

            Console.WriteLine(p1.DistanceTo(p2));

            Console.WriteLine(p1);
            Console.ReadKey();
        }
    }
}
