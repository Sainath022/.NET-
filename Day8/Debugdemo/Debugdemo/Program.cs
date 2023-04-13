using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second number");
            int j = int.Parse(Console.ReadLine());
            a(i, j);
            Console.WriteLine("Debugging is over");
        }
        public static void a(int x, int y)
        {
            int t = 100;
            for(int i= x; i <= y; i++)
            {
                Console.WriteLine("hello");
                t = t * 2;
            }
        }

    }
}
