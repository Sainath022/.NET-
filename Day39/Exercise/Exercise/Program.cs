using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student type:");
            string StudentType = Console.ReadLine();
            Console.WriteLine("Enter tuition fee:");
            float TuitionFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter bus fee:");
            float BusFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hostel fee:");
            float HostelFee = float.Parse(Console.ReadLine());
            float Fee = 0;
            if (StudentType == "MSDS")
            {
                Fee = TuitionFee + BusFee;
            }
            else if (StudentType == "MSH")
            {
                Fee = TuitionFee + HostelFee;
            }
            else if (StudentType == "MGSDS")
            {
                Fee = (150/100) * TuitionFee + BusFee;
            }
            else if (StudentType == "MGSH")
            {
                Fee = (150 / 100) * TuitionFee + HostelFee;
            }

            Console.WriteLine("The fees to be paid by the student is Rs.{0}",Fee);

        }

    }
}

