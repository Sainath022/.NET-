using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endoffile
{
    internal class Program
    {

        static void Main(string[] args)

        {

            string line;

            int lineNumber = 1;



            while ((line = Console.ReadLine()) != null)

            {

                Console.WriteLine(lineNumber + " " + line);

                lineNumber++;

            }

        }

    }


}

