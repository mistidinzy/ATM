using System;

namespace ATM
{
    class Program
    {
        //private static readonly BankAccount account field
        private static readonly BankAccount userAccount = new BankAccount();

        //void Main() method
        //Welcome the user, but only once
        //Use PromptForAction() to request the next action
        //For a valid action, exit or call the appropriate method and prompt again
        //For an invalid action, prompt again
        //Main should not try/catch

        public static void Main(string[] args)
        {
            WriteWelcome();

            while (PromptForContinue() == 1)
            {
                int userInput = PromptForAction();

                if (userInput == 1)
                {
                    ViewBalance();
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
                else if(userInput == 4)
                {
                    return;
                }

                else if (PromptForContinue() == 2)
                {
                    break;
                }
            }
            
            WriteGoodbye();
        }

        public static void WriteWelcome()
        {
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Hello! Welcome to The Bank!");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" ");
        }

        public static int PromptForAction()
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------");

                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Select a number from the options below:");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("1. Check My Balance");
                Console.WriteLine("2. Make a Deposit");
                Console.WriteLine("3. Make a Withdrawal");
                Console.WriteLine("4. Exit");
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(" ");

                string userInput = Console.ReadLine();
                int choice = Convert.ToInt32(userInput);

                return choice;
            }
            catch
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("I'm sorry. That input was not valid. Goodbye.");
                Console.WriteLine("---------------------------------------------------");
                return 0;
            }
        }

        public static int PromptForContinue()
        {
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Please select a number from the options below:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("1. Next");
            Console.WriteLine("2. Exit");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" ");

            string userResponse = Console.ReadLine();
            int userResponseB = Convert.ToInt32(userResponse);

            return userResponseB;
        }

        public static decimal ViewBalance()
        {
            decimal currentBalance = userAccount.GetBalance();
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Your current balance is ${currentBalance}.");
            Console.WriteLine("---------------------------------------------------");
            return currentBalance;
        }

        public static void Withdraw()
        {
            throw new NotImplementedException();
        }

        public static void WriteGoodbye()
        {
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Thank you for choosing The Bank. Goodbye!");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" ");
        }

        //Initialize with a new BankAccount()
        //This will hold the state of the account being accessed through the ATM

        //void WriteWelcome() method
        //Be friendly!

        //int PromptForAction() method
        //Show the action menu and ask for an action

        //Return the selected action(1-4)

        //If the user does not enter a valid number, return 0

        //void PromptAndDeposit() method

        //Prompt for a deposit amount
        //Deposit that amount into account

        //Handle any reasonably expected errors, and show a user-friendly message

        //void PromptAndWithdraw() method

        //Prompt for a withdraw amount

        //Withdraw that amount from account

        //Handle any reasonably expected errors, and show a user-friendly message

        //void ViewBalance() method

        //Show balance from account



        //Your program should not crash for reasonable inputs

    }
}
