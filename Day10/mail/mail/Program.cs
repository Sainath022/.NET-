using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail
{
    internal class Program
    {
        public class Mail

        {

            private long _id;

            public long ID

            {

                get { return _id; }

                set { _id = value; }

            }

            private string _to;

            public string To

            {

                get { return _to; }

                set { _to = value; }

            }

            private string _from;

            public string From

            {

                get { return _from; }

                set { _from = value; }

            }

            private string _subject;

            public string Subject

            {

                get { return _subject; }

                set { _subject = value; }

            }

            private string _content;

            public string Content

            {

                get { return _content; }

                set { _content = value; }

            }

            private DateTime _receivedDate;

            public DateTime ReceivedDate

            {

                get { return _receivedDate; }

                set { _receivedDate = value; }

            }

            private double _size;

            public double Size

            {

                get { return _size; }

                set { _size = value; }

            }



            public Mail()

            {

            }

            public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)

            {

                this._id = _id;

                this._to = _to;

                this._from = _from;

                this._subject = _subject;

                this._content = _content;

                this._receivedDate = _receivedDate;

                this._size = _size;

            }
            public override string ToString()
            {
                return String.Format("Id:{0}\n To:{1}\n From:{2}\n Subject:{3}\nContent:{4}\n RecievedDate:{5}\n Size:{6}\n", _id, _to, _from, _subject, _content, _receivedDate.ToString("dd-MM-yyyy,null"), _size.ToString("0.0"));
            }


            static void Main(string[] args)
            {
                Console.WriteLine("Enter the mail 1: ");

                string s = Console.ReadLine();

                string[] arr = s.Split(',');

                int id = Convert.ToInt32(arr[0]);

                Console.WriteLine($"Id is:{id}");

                string _to = arr[1];

                Console.WriteLine($"To:{_to}");

                string _from = arr[2];

                Console.WriteLine($"From:{_from}");

                string _subject = arr[3];

                Console.WriteLine($"Subject:{_subject}");

                string _content = arr[4];

                Console.WriteLine($"content:{_content}");

                DateTime _receivedDate = Convert.ToDateTime(arr[5]);

                Console.WriteLine($"ReceivedDate:{_receivedDate}");

                double _size = Convert.ToDouble(arr[6]);
                Console.WriteLine($"Size : {_size}");



            }
        }
    }

}




