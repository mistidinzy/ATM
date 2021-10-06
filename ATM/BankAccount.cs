using System;
namespace ATM
{
    public class BankAccount
    {
        private decimal balance;

       
        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal depositMoney)
        {
            if (depositMoney < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit amount cannot be negative.");
            }

            balance += depositMoney;
        }









    }
}
