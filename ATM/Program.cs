using System;

namespace ATM
{
  class Program
  {
    private static readonly BankAccount userAccount = new BankAccount();

    public static void Main(string[] args)
    {
      BankAccount.ReadFromFile("Log.txt");
      ATM.WriteWelcome();

      while (ATM.PromptForContinue() == 1)
      {
        int userInput = ATM.PromptForAction();

        if (userInput == 1)
        {
          ATM.ViewBalance();
        }
        else if (userInput == 2)
        {
          Console.WriteLine(" ");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine("Please enter the amount you are depositing today.");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine(" ");

          string amount = Console.ReadLine();
          decimal depositMoney = Convert.ToDecimal(amount);
          userAccount.Deposit(depositMoney);

          Console.WriteLine(" ");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine($"Your deposit of ${depositMoney} is complete!");
          Console.WriteLine(" ");

          decimal newBalance = userAccount.GetBalance();

          Console.WriteLine(" ");
          Console.WriteLine($"Your new balance is ${newBalance}.");
          Console.WriteLine("---------------------------------------------------");
        }
        else if (userInput == 3)
        {
          Console.WriteLine(" ");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine("Please enter the amount you would like to withdraw.");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine(" ");

          string amount = Console.ReadLine();
          decimal amountToWithdraw = Convert.ToDecimal(amount);
          userAccount.Withdraw(amountToWithdraw);

          Console.WriteLine(" ");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine($"Your withdrawal of ${amountToWithdraw} is complete!");
          Console.WriteLine(" ");

          decimal newBalance = userAccount.GetBalance();

          Console.WriteLine(" ");

          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine($"Your new balance is ${newBalance}.");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine(" ");
        }
        else if (userInput == 4)
        {
          return;
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

        }
    }
}
