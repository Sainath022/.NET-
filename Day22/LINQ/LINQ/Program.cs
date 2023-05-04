using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string[] cars = { "Supra", "Skyline GTR", "Mazda", "Honda RX7","Mustang 69"};
              var cQuery =
              from car in cars
              let len=car.Length
              where len>4 && len<7
              //where (car.StartsWith("S"))
              select car;
            foreach (string c in cQuery)
            {
                Console.WriteLine(c);
            }
        }
    }
}
