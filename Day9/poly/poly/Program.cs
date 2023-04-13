using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Drawshape();
            Circle c1 = new Circle();
            c1.Drawshape();
            Rectangle r1 = new Rectangle();
            r1.Drawshape();

            Shape s2 = new Circle();
            s2.Drawshape();

            Shape s3 = new Rectangle();
            s3.Drawshape();
        }

        
    }

    
}
