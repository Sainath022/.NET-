using System.Collections;
using System.Globalization;

namespace Bigdecimal
{
    internal class RealNumberStringComparer : System.Collections.Generic.IComparer<string>
    {
        public int Compare(string x, string y)

        {

            decimal decimalX = decimal.Parse(x, CultureInfo.InvariantCulture);

            decimal decimalY = decimal.Parse(y, CultureInfo.InvariantCulture);



            return decimalY.CompareTo(decimalX);

        }
    }
}