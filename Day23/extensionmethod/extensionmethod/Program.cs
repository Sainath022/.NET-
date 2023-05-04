using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod
{
    using System;
    namespace LINQDemo
    {
        class Program
        {
            static void Main(string[] args)
            {
                string sentence = "Toyota Supra and Nissan Skyline GTR are both designed by Smokey Nagata";

                int wordCount = ExtensionHelper.GetWordCount(sentence);

                Console.WriteLine($"Count : {wordCount}");
                Console.ReadKey();
            }
        }

        public static class ExtensionHelper
        {
            public static int GetWordCount(this string str)
            {
                if (!String.IsNullOrEmpty(str))
                    return str.Split(' ').Length;
                return 0;
            }
        }
    }
}
