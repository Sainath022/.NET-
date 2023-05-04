using LinqDemo2;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Linqlist
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Emp> list = new List<Emp>();

            list.Add(new Emp("ram", "hyd"));

            list.Add(new Emp("sita", "trv"));

            list.Add(new Emp("krishna", "hyd"));

            list.Add(new Emp("sai", "bombay"));

            list.Add(new Emp("nikhil", "chennai"));

            list.Add(new Emp("ravan", "Lanka"));

            var equery = 
                         
                        from Emp emp in list

                         orderby emp.City

                         group emp by emp.City;

            foreach (var e in equery)

            {   

                Console.WriteLine("Emp with " + e.Key + " city");

                foreach (var m in e)

                {

                    Console.WriteLine(" " + m.Name);

                }

            }
        }
    }
}

