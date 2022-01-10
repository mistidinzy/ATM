﻿using System;
using System.IO;

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

        public void Withdraw(decimal amountToWithdraw)
        {

            if (amountToWithdraw > balance)
            {
                throw new ArgumentException("Withdrawal amount cannot exceed balance.");
            }

            if (amountToWithdraw < 0)
            {
                throw new ArgumentOutOfRangeException("You cannot withdraw a negative amount. Please enter a valid amount to withdraw.");
            }

            decimal newBalance = balance - amountToWithdraw;

            balance -= amountToWithdraw;
        }

        public static void ReadFromFile(string fileName)
        {
            Console.WriteLine("Reading {0}...", fileName);
            File.ReadAllText(fileName);

        }


        //private string WriteToLog(int entry)
        //{

        //    string transaction;

        //    return transaction;
        //}
    }
}
