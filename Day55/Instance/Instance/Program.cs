using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    internal class Program
    {
        class Student { }

        class Rockstar { }

        class Hacker { }

        class Solution

        {
            static void Main(string[] args)

            {

                List<object> mylist = new List<object>();

                int t = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < t; i++)

                {

                    string s = Console.ReadLine();

                    if (s.Equals("Student"))

                    {

                        mylist.Add(new Student());

                    }

                    else if (s.Equals("Rockstar"))

                    {

                        mylist.Add(new Rockstar());

                    }

                    else if (s.Equals("Hacker"))

                    {

                        mylist.Add(new Hacker());

                    }

                }
                int studentCount = 0;

                int rockstarCount = 0;

                int hackerCount = 0;

                foreach (var obj in mylist)

                {

                    if (obj is Student)

                    {

                        studentCount++;

                    }

                    else if (obj is Rockstar)

                    {

                        rockstarCount++;

                    }

                    else if (obj is Hacker)

                    {

                        hackerCount++;

                    }

                }

                Console.WriteLine(studentCount);

                Console.WriteLine(rockstarCount);

                Console.WriteLine(hackerCount);

            }

        }
    }
}
