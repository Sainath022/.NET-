
using System;

using System.Collections.Generic;

using System.Linq;

using Ganss.Excel;

using NPOI.SS.Formula.Functions;

namespace Excel

{

    class Program

    {

        static void Main(string[] args)

        {

            List<Student> str = new List<Student>()

             {

                 new Student{Id=101,Name="Alok"},
            
                 new Student{Id=102,Name="Ramesh"},

                 new Student{Id=103,Name="Shubha"}

              };

            ExcelMapper mapper = new ExcelMapper();
               

            var newfile = @"D:\Student.xlsx";

            mapper.Save(newfile, str, "StudData", true);

            List<Student> students = mapper.Fetch<Student>("StudData").ToList();

            Console.WriteLine("StudData List");

            foreach (Student student in students)

            {

                Console.WriteLine(student.Id + "\t" + student.Name);

            }

            Console.WriteLine();

        }

    }

}
