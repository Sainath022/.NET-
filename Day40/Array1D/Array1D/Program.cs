using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1D
{
    internal class Program
    {
        public static bool CanWinGame(int leap, int[] game)

        {

            return CanWin(0, leap, game);

        }

        private static bool CanWin(int currentIndex, int leap, int[] game)

        {

            // Base case: reached the end of the array

            if (currentIndex >= game.Length - 1)

                return true;

            // Check if the current index is valid and contains a zero

            if (currentIndex < 0 || game[currentIndex] == 1)

                return false;

            // Mark the current index as visited (set it to 1)

            game[currentIndex] = 1;

            // Recursive cases: try moving forward, backward, and jumping

            return CanWin(currentIndex + 1, leap, game) ||

                CanWin(currentIndex - 1, leap, game) ||

                CanWin(currentIndex + leap, leap, game);

        }

        public static void Main(string[] args)

        {
            Console.WriteLine("Enter the number of elements in the array:");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] game = new int[n];

            Console.WriteLine("Enter the elements of the array (0 or 1, separated by space):");

            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)

            {

                game[i] = Convert.ToInt32(elements[i]);

            }

            Console.WriteLine("Enter the leap value:");

            int leap = Convert.ToInt32(Console.ReadLine());



            bool canWin = CanWinGame(leap, game);

            Console.WriteLine(canWin); // Output: True

        }

    }

}

