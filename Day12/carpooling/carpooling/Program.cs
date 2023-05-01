using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpooling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> list = new List<Member>();

            for (int i = 0; i < 2; i++)

            {

                Console.WriteLine($"Member{i + 1}");

                Console.WriteLine("Id:");

                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("first name: ");

                string firstname = Console.ReadLine();

                Console.WriteLine("Last name: ");

                string lastname = Console.ReadLine();

                Console.WriteLine("email: ");

                string email = Console.ReadLine();

                Console.WriteLine("contact number: ");

                string contactnumber = Console.ReadLine();

                Console.WriteLine("license number: ");

                string licensenumber = Console.ReadLine();

                Console.WriteLine("license start date: ");

                DateTime licensestart = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("license end date: ");

                DateTime licenseend = DateTime.Parse(Console.ReadLine());

                Member member = new Member(id, firstname, lastname, email, contactnumber, licensenumber,licensestart, licenseend);

                list.Add(member);

            }

            foreach (Member member1 in list)

            {

                if (list[0].Equals(list[1]))

                {

                    Console.WriteLine("Member1 is same as Member2");

                }

                else

                {

                    Console.WriteLine("Member1 and Member2 are differnt");

                }

            }

        }
    }
 }

