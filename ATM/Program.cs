using System;

namespace ATM
{
  class Program
  {
    private static readonly BankAccount userAccount = new BankAccount();

    public static void Main(string[] args)
    {
      ATM.WriteWelcome();

      while (ATM.PromptForContinue() == 1)
      {
        int userInput = ATM.PromptForAction();

        if (userInput == 1)
        {
          Console.WriteLine(" ");
          Console.WriteLine("---------------------------------------------------");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine($"Your current balance is ${userAccount.GetBalance()}.");
          Console.ResetColor();
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine(" ");
        }
        else if (userInput == 2)
        {
          Console.WriteLine(" ");
          Console.WriteLine("---------------------------------------------------");
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("Please enter the amount you are depositing today.");
          Console.ResetColor();
          Console.WriteLine("---------------------------------------------------");
          decimal depositMoney = Convert.ToDecimal(Console.ReadLine());
          userAccount.Deposit(depositMoney);
          Console.WriteLine(" ");
          Console.WriteLine($"Your deposit of ${depositMoney} is complete!");
          Console.WriteLine(" ");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine($"Your new balance is ${userAccount.GetBalance()}.");
          Console.ResetColor();
          //Console.WriteLine("---------------------------------------------------");
        }
        else if (userInput == 3)
        {
          Console.WriteLine(" ");
          Console.WriteLine("---------------------------------------------------");
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("Please enter the amount you would like to withdraw.");
          Console.ResetColor();
          Console.WriteLine("---------------------------------------------------");
          decimal amountToWithdraw = Convert.ToDecimal(Console.ReadLine());
          userAccount.Withdraw(amountToWithdraw);
          Console.WriteLine(" ");
          Console.WriteLine($"Your withdrawal of ${amountToWithdraw} is complete!");
          Console.WriteLine(" ");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine($"Your new balance is ${userAccount.GetBalance()}.");
          Console.ResetColor();
          //Console.WriteLine("---------------------------------------------------");
          Console.WriteLine(" ");
        }
        else if (userInput == 4)
        {
          break;
        }

        else if(userInput == 5)
        {
          DisplayTransactionLog();
        }

        else if (ATM.PromptForContinue() == 2)
        {
          break;
        }
      }

      ATM.WriteGoodbye();
    }

    public static void DisplayTransactionLog()
    {
      BankAccount.GetLog("Log.txt");
    }
  }
}
