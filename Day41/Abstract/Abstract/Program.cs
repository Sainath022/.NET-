using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Book

    {

        protected string title;

        public abstract void SetTitle(string s);

        public string GetTitle()

        {

            return title;

        }

    }

    class MyBook : Book

    {

        public override void SetTitle(string s)

        {

            title = s;

        }

    }

    class MainClass

    {

        public static void Main(string[] args)

        {

            Book new_novel = new MyBook();

            Console.Write("Enter the title: ");

            string title = Console.ReadLine();

            new_novel.SetTitle(title);

            Console.WriteLine("The title is: " + new_novel.GetTitle());

        }

    }
}
