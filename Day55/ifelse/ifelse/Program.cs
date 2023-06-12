using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program

    {
        static void Main(string[] args)

        {

            int n = Convert.ToInt32(Console.ReadLine());



            if (n % 2 == 1) // n is odd

            {

                Console.WriteLine("Weird");

            }

            else // n is even

            {

                if (n >= 2 && n <= 5)

                {

                    Console.WriteLine("Not Weird");

                }

                else if (n >= 6 && n <= 20)

                {

                    Console.WriteLine("Weird");

                }

                else

                {

                    Console.WriteLine("Not Weird");

                }

            }

        }

    }
}
