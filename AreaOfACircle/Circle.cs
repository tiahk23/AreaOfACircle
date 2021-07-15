using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfACircle
{
    public class Circle
    {
        public static double GetArea(double r)
        {
            double pi = Math.PI;
            double area = pi * r * r;
            return area;
        }

        public static double GetCircumference(double r)
        {
            double circumference = 2 * pi * r;
            return circumference;
        }

        public static double GetDiameter(double r)
        {

            double diameter = 2 * r;
            return diameter;
        }
    }
}
