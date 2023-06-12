using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        class Animal

        {

            public void walk()

            {

                Console.WriteLine("I am walking");

            }

        }



        class Bird : Animal

        {

            public void fly()

            {

                Console.WriteLine("I am flying");

            }



            public void sing()

            {

                Console.WriteLine("I am singing");

            }

        }
        class Solution

        {

            public static void Main(string[] args)

            {

                Bird bird = new Bird();



                bird.walk();

                bird.fly();

                bird.sing();

            }

        }
    }
}
