using Microsoft.SqlServer.Server;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Runtime;

using System.Text;

using System.Threading.Tasks;

namespace LinqDemo2

{

    class Emp

    {

        private string _name;

        public string Name

        {

            get { return _name; }

            set { _name = value; }

        }

        private string _city;

        public string City

        {

            get { return _city; }

            set { _city = value; }

        }

        public Emp(string name, string city)

        {

            _name = name;

            _city = city;

        }

    }

}