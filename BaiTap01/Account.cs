using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Account
    {
        private double _balance;
        public Account()
        {

        }
        public Account(double balance)
        {
            this._balance = balance;
        }
        protected double Balance
        {
            set { _balance = value; }
            get { return _balance; }
        }
        public virtual bool Withdraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public virtual void PrintBalance()
        {
            Console.WriteLine($"So du: {Balance}");
        }
    }
    class SavingsAccount : Account
    {
        private double _interesRate = 0.8;
        public double InteresRate
        {
            set { _interesRate = value; }
            get { return _interesRate; }
        }
        public SavingsAccount() : base()
        {

        }
        public SavingsAccount(double balance) : base(balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - (amount + amount * InteresRate);
                return true;
            }
            else
            {
                Console.WriteLine("Giao dich that bai");
                return false;
            }
        }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + (amount + amount * InteresRate);
                return true;
            }
            else
            {
                Console.WriteLine("Giao dich that bai");
                return false;
            }
        }
        public override void PrintBalance()
        {
            Console.WriteLine($"The saving account balance is: {Balance}");
        }
    }
    class CheckingAccount : Account
    {
        public CheckingAccount() : base()
        {

        }
        public CheckingAccount(double balance) : base(balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            else
            {
                Console.WriteLine("Giao dich that bai");
                return false;
            }
        }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                return true;
            }
            else
            {
                Console.WriteLine("Giao dich that bai");
                return false;
            }
        }
        public override void PrintBalance()
        {
            Console.WriteLine($"The saving account balance is: {Balance}");
        }
    }
}

