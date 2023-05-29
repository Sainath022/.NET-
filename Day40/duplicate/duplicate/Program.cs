using System;
using System.Text.RegularExpressions;

namespace duplicate
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Enter no of strings:");

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
               

                string sentence = Console.ReadLine();

                // Write a RegEx that matches any repeated word

                string regex = @"\b(\w+)(\s+\1\b)+";

                // Complete the second compile argument for case-insensitive matching

                // By using the IgnoreCase option

                Regex regexObj = new Regex(regex, RegexOptions.IgnoreCase);

                // Write the two necessary arguments for replaceAll to replace repeated words with the first occurrence

                string replaced = regexObj.Replace(sentence, "$1");

                Console.WriteLine(replaced);

            }

        }

    }


}
