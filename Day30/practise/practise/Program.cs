using System;



namespace practise

{

    public class Program

    {

        public static void Main(string[] args)

        {

            int i,n,sum=0;

            

            Console.WriteLine("Enter no of elements to be stored in array:");

            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("input {0} elements in the array:", n);

            for (i = 0; i < n; i++)

            {

                Console.WriteLine("Element {0} is:", i);

                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for(i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            Console.Write("\nThe Sum of the all the elements stored in the array is:{0} \n",sum);


           

        }

    }

}