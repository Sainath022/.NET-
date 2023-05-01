using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excpetionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int b=2; int[] a=new int[b];
            try
            {
                int i = 10 / b;
                a[10] = 9;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by Zero Error");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds");
            }
            finally {
                Console.WriteLine("Finally");
                    Console.WriteLine("Remaining program"); }
          
        }
    }
}
