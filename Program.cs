using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            CircleArea(in radius, out double result);
            Console.WriteLine("Area of the circle is : " + result);

        }
        static void CircleArea(in int radius, out double area) { 
            double piValue = 3.142;
            area = piValue * radius * radius; 
        }

    }
}


