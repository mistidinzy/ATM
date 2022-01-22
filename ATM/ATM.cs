using System;
namespace ATM
{
    public class ATM
    {
        private static readonly BankAccount userAccount = new BankAccount();

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
    }
}
