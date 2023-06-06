using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptiontrycatch
{ 
    class Program

    {

        static void Main(string[] args)

        {

            try

            {

                string[] input = Console.ReadLine().Split(' ');

                int x = int.Parse(input[0]);

                int y = int.Parse(input[1]);



                int result = Divide(x, y);

                Console.WriteLine(result);

            }

            catch (FormatException)

            {

                Console.WriteLine("java.util.InputMismatchException");

            }

            catch (DivideByZeroException)

            {

                Console.WriteLine("java.lang.ArithmeticException: / by zero");

            }

            catch (Exception e)

            {

                Console.WriteLine(e.GetType().FullName);

            }

        }



        static int Divide(int x, int y)

        {

            return x / y;

        }

    }


}
