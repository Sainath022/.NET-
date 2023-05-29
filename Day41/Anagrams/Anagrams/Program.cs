using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    using System;

    using System.Collections.Generic;

    class Solution
    {

        static bool IsAnagram(string a, string b)
        {

            

            a = a.ToLower();

            b = b.ToLower();

            

            if (a.Length != b.Length)
            {

                return false;

            }

           

            Dictionary<char, int> freqA = new Dictionary<char, int>();

            Dictionary<char, int> freqB = new Dictionary<char, int>();

            

            foreach (char c in a)
            {

                if (freqA.ContainsKey(c))
                {

                    freqA[c]++;

                }
                else
                {

                    freqA[c] = 1;

                }

            }

            

            foreach (char c in b)
            {

                if (freqB.ContainsKey(c))
                {

                    freqB[c]++;

                }
                else
                {

                    freqB[c] = 1;

                }

            }

           

            foreach (KeyValuePair<char, int> kvp in freqA)
            {

                char c = kvp.Key;

                int countA = kvp.Value;

                // Check if the character exists in string b

                if (freqB.ContainsKey(c))
                {

                    int countB = freqB[c];

                    

                    if (countA != countB)
                    {

                        return false;

                    }

                    

                    freqB.Remove(c);

                }
                else
                {

                    

                    return false;

                }

            }

            

            return true;

        }

        static void Main(string[] args)
        {

            string a = Console.ReadLine();

            string b = Console.ReadLine();

            if (IsAnagram(a, b))
            {

                Console.WriteLine("Anagrams");

            }
            else
            {

                Console.WriteLine("Not Anagrams");

            }

        }

    }
}
