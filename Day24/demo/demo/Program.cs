using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            HRSchemaEntities h1 = new HRSchemaEntities();

            foreach (var entity in h1.Orders)

            {

                Console.WriteLine(entity);

            }

            using (var context = new HRSchemaEntities())
            {
                var std = context.Orders.First<Order>();
                std.OrderID = 1;
                context.SaveChanges();
            }

            /*using (var context = new HRSchemaEntities())
            {
                var std = new Order()
                {
                    OrderID=1,
                    OrderNumber=101,
                };
                context.Orders.Add(std);

                context.SaveChanges();
            }*/

            /*using (var context = new HRSchemaEntities())
            {
                var std = context.Orders.First<Order>();
                context.Orders.Remove(std);

                context.SaveChanges();
            }*/
        }
    }
}
