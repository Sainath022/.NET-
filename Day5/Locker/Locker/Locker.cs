using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locker
{
    public class Locker
    {
        private int _number;
        private string _locktype;
        private string _password;
        private double _amount;
        private DateTime _lastOpened;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Locktype
        {
            get { return _locktype; }
            set { _locktype = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public DateTime LastOpened
        {
            get { return _lastOpened; }
            set { _lastOpened = value; }
        }

        public Locker()
        {
            _number = 001;
            _locktype = "A";
            _password = "password";
            _amount = 1000;
            _lastOpened = DateTime.Now;

        }

        public Locker(int _number, string _locktype, string _password, double _amount, DateTime _lastOpened)
        {
            this._number = _number;
            this._locktype = _locktype;
            this._password = _password;
            this._amount = _amount;
            this._lastOpened = _lastOpened;

        }
    }
}

