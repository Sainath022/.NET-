using System;


namespace exceptionhandling
{
    class exceptionhandling

    {

        public static int power(int n, int p)

        {

            if (n < 0 || p < 0)

            {

                throw new Exception("n and p should be non-negative");

            }

            else

            {

                return (int)Math.Pow(n, p);

            }

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            string line;

            while ((line = Console.ReadLine()) != null)

            {

                string[] input = line.Split(' ');

                int n = int.Parse(input[0]);

                int p = int.Parse(input[1]);



                try

                {

                    int result = exceptionhandling.power(n, p);

                    Console.WriteLine(result);

                }

                catch (Exception e)

                {

                    Console.WriteLine(e.Message);

                }

            }

        }

    }
}

