using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSim
{
    public class BankAccount
    {
        private double balance;
        private double credit;

        public BankAccount(double balance, double credit)
        {
            this.balance = balance;
            this.credit = credit;
        }

        public void deposit(double amount)
        {
            balance += amount;
        }

        public void withdraw(double amount)
        {
            balance -= amount;
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Credit(double amount)
        {
            balance += amount;
            credit += amount * 1.3;
        }

        public double CreditBalance
        {
            get { return credit; }
        }

        public void SetCreditBalance(double amount)
        {
            credit += amount; 
        }


    }
}
