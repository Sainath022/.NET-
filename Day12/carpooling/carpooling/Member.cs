using System;

namespace carpooling
{
    internal class Member
    {
        

    private long _id;

        private string _firstName;

        private string _lastName;

        private string _email;

        private string _contactNumber;

        private string _licenseNumber;

        private DateTime _licenseStartDate;

        private DateTime _licenseExpiryDate;

        public long Id

        {

            get { return _id; }

            set { _id = value; }

        }

        public string FirstName

        {

            get { return _firstName; }

            set { _firstName = value; }

        }

        public string LastName

        {

            get { return _lastName; }

            set { _lastName = value; }

        }

        public string Email

        {

            get { return _email; }

            set { _email = value; }

        }

        public string ContactNumber

        {

            get { return _contactNumber; }

            set { _contactNumber = value; }

        }

        public string LicenseNumber

        {

            get { return _licenseNumber; }

            set { _licenseNumber = value; }

        }

        public DateTime LicenseStartDate

        {

            get { return _licenseStartDate; }

            set { _licenseStartDate = value; }

        }

        public DateTime LicenseExpiryDate

        {

            get { return _licenseExpiryDate; }

            set { _licenseExpiryDate = value; }

        }

        public Member()

        {



        }

        public Member(long id, string firstName, string lastName, string email, string contactNumber,

          string licenseNumber, DateTime licenseStartDate, DateTime licenseExpiryDate)

        {


            _id = id;

            _firstName = firstName;

            _lastName = lastName;

            _email = email;

            _contactNumber = contactNumber;

            _licenseNumber = licenseNumber;

            _licenseStartDate = licenseStartDate;

            _licenseExpiryDate = licenseExpiryDate;

        }

        public override string ToString()

        {

            return $"Member: {_firstName}, {_lastName}\nMember contact details: {_contactNumber}, {_email}";

        }

        public override bool Equals(object obj)

        {

            Member member = obj as Member;

            if (Email.ToLower() == member.Email.ToLower() && ContactNumber.ToLower() == member.ContactNumber)

            {

                return true;

            }

            else

            {

                return false;

            }

        }

        public override int GetHashCode()

        {

            return base.GetHashCode();

        }

    }



}
