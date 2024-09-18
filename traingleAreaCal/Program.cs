using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traingleAreaCal
{
    internal class Program
    {
        // Area = √s(s - a)(s - b)(s - c)
        //where s = half the perimeter, or(a + b + c)/2

        public static double triangleArea(double a, double b, double c)
        {
            double s = (a + b + c)/2;

            double x = s*(s-a)*(s-b)*(s-c);

            double Area = Math.Sqrt(x);

            return Area;
            
        }
        static void Main(string[] args)
        {
            //test case
            double a = 5.0;
            double b = 6.0;
            double c = 7.0;

            double area = triangleArea(a, b, c);
            Console.WriteLine(area);
            //14.6969384566991
        }
    }
}
