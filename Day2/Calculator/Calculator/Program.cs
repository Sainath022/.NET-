using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r,Area;
            Console.WriteLine("Enter the radius of your circle:");
            r = double.Parse(Console.ReadLine());
            Area = CalArea(r);
            Console.WriteLine(Area);            
        }
        static double CalArea(double rad)
        {
            double Area;
            Area = 3.14 * rad * rad;
            return Area;
        }
    }
}
