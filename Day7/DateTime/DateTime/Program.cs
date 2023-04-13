using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime moment = new DateTime(2023, 4, 8, 9, 9, 9, 45);

            Console.WriteLine("Year = " + moment.Year);

            Console.WriteLine("Month = " + moment.Month);

            Console.WriteLine("Day = " + moment.Day);

            Console.WriteLine("Hour = " + moment.Hour);

            Console.WriteLine("Minute = " + moment.Minute);

            Console.WriteLine("Second = " + moment.Second);

            Console.WriteLine("Millisecond = " + moment.Millisecond);

            Console.WriteLine(DateTime.Now);
        }
    }

    }

