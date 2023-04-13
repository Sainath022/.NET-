using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    internal class Program
    {
            class Vehicle  
        {
            public string brand = "Toyota";  
            public void honk()             
            {
                Console.WriteLine("stuhtuhtutuhtuth");
            }
        }

        class Car : Vehicle  
        {
            public string modelName = "supra";  
        }

        
        
            static void Main(string[] args)
            {
                Car myCar = new Car();
                myCar.honk();
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
            }
        }
    }
    
