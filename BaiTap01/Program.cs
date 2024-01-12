using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account SAccount = new SavingsAccount(6000);
            SAccount.Deposit(1000);
            SAccount.PrintBalance();

            SAccount.Withdraw(3000);
            SAccount.PrintBalance();

            Account CAccount = new CheckingAccount(5000);
            CAccount.Deposit(1000);
            CAccount.PrintBalance();

            CAccount.Withdraw(3000);
            CAccount.PrintBalance();

            Console.ReadLine();
        }
    }
}
