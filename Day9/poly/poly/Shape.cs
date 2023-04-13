using System;
using System.Security.Cryptography.X509Certificates;

namespace poly
{
     class Shape
    {
        public virtual void Drawshape()
        {
            
            Console.WriteLine("Drawing Shape");

        }
    }
        class Circle : Shape 
        {
        public override void Drawshape()
        {
            Console.WriteLine("Drawing Circle");
        }
           
        }

        class Rectangle : Shape
        {
        public override void Drawshape() { Console.WriteLine("Drawing Rectangle"); }
        }
    
}