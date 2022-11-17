using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point() { }
        public Point(double x, double y, double z = default)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double DistanceTo(Point point)
        {
            double distance = 0.0;
            distance = Math.Sqrt(Math.Pow((point.X - this.X), 2.0) + Math.Pow((point.Y - this.Y), 2.0) + Math.Pow((point.Z - this.Z), 2.0));
            return distance;
        }

        public override string ToString()
        {
            return string.Format($"x=>[{X}]; y=>[{Y}]; z=>[{Z}]");
        }
    }
}
