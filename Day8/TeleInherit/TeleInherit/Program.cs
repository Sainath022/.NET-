/*Create a base class, Telephone, and derive a class ElectronicPhone from it.
In Telephone, create a protected string member phonetype and a public method Ring( )
which outputs a text message such as this: “Ringing the <phonetype>.”
In ElectronicPhone, the constructor should set the phonetype to “Digital.”
In the Run( ) method, call Ring( ) on the ElectronicPhone to test the inheritance.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleInherit
{
    internal class Program
    {
        class Telephone
        {
            protected string phonetype;
            public void Ring()
            { 
                Console.WriteLine($"Ringing the {phonetype}");
            }
        }
        class ElectronicPhone : Telephone 
        {

            public ElectronicPhone() 
            {
                phonetype = "Digital";
            }

            
            public void Run()
            {
                base.Ring();
            }
        
        }
        

        static void Main(string[] args)
        {
            ElectronicPhone tel=new ElectronicPhone();
            tel.Run();
        }
    }
}
