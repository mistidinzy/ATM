using System;
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

      WriteToLog(balance.ToString());
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

      balance -= amountToWithdraw;

      WriteToLog(balance.ToString());
    }

    //----------System IO--------------//

    public static void ReadFromFile(string fileName)
    {
      Console.WriteLine("Reading {0}...", fileName);

      string fileText = File.ReadAllText(fileName);

      Console.WriteLine(fileText);
    }

    public static void WriteToLog(string logEntry)
    {
      string transaction = $"{DateTime.Today:yyyy-MM-dd}: {logEntry}\n";

      string[] lines = new string[] { logEntry };

      File.AppendAllLines("Log.txt", lines);

      Console.WriteLine(" ");
      Console.WriteLine("Transaction Log has been updated.");
    }

    public static string[] GetLog(string fileName)
    {
      string[] lines = File.ReadAllLines(fileName);

      for (int i = 0; i < lines.Length; i++)
      {
        Console.WriteLine(lines[i]);
      }

      return lines;
    }

    public static void ClearLog(string fileName)
    {
      File.WriteAllText(fileName, "");
    }
  }
}
