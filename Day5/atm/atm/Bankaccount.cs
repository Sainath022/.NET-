using System;



namespace atm

{

    public class Bankaccount

    {

        public int AccountId;

        public string Name;

        public decimal Balance;

        public void Newaccount(int id, string name, decimal balance)

        {

            AccountId = id;

            Name = name;

            Balance = balance;

        }

        public void Displayinfo()

        {

            Console.WriteLine(" Account info ");

            Console.WriteLine("Name is " + Name);

            Console.WriteLine("AccountId is " + AccountId);

            Console.WriteLine("Balance is " + Balance);

        }

        public void Deposit(decimal a)

        {

            Balance += a;

            Console.WriteLine("Balance Amount after deposit is " + Balance);

        }

        public void withdraw(decimal a)

        {

            Balance -= a;

            Console.WriteLine($"Balance Amount after withdrawing {a} is " + Balance);

        }

    }

}