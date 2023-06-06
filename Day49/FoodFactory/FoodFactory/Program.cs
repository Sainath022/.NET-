using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory
{
    interface Food

    {

        string getType();

    }

    class Pizza : Food

    {

        public string getType()

        {

            return "Someone ordered Fast Food!";

        }

    }
    class Cake : Food

    {

        public string getType()

        {

            return "Someone ordered a Dessert!";

        }

    }

    class FoodFactory

    {

        public Food getFood(string type)

        {

            if (type.Equals("pizza", StringComparison.OrdinalIgnoreCase))

            {

                return new Pizza();

            }

            else if (type.Equals("cake", StringComparison.OrdinalIgnoreCase))

            {

                return new Cake();

            }

            else

            {

                return null;

            }

        }

    }
    class MainClass

    {

        public static void Main(string[] args)

        {

            FoodFactory factory = new FoodFactory();



            string foodType = Console.ReadLine();



            Food food = factory.getFood(foodType);



            if (food != null)

            {

                Console.WriteLine("The factory returned class " + food.GetType().Name + " " + food.getType());

            }

            else

            {

                Console.WriteLine("Invalid food type!");

            }

        }

    }
}
