using System;
using System.Net;

namespace Lab02_UnitTests
{
    public class Program
    {
        public static decimal Balance = 500;

        /// <summary>
        /// Calling the user interface method to activate the application
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            UserInterface();
        }

        /// <summary>
        /// Returns the value of the current balance
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal ViewBalance()
        {
            if (Balance < 0)
            {
                return 0;
            }
            else
            {
                return Balance;
            }

        }

        /// <summary>
        /// Subtracts money from the balance
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal Withdraw(decimal amount)
        {
            Balance = ViewBalance();

            if (Balance < amount)
            {
                return Balance;
            }
            else if (amount < 0)
            {
                return Balance;
            }
            else
            {
                Balance -= amount;
                return Balance;
            }
        }

        /// <summary>
        /// Adds money to the balance
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal Deposit(decimal amount)
        {
            Balance = ViewBalance();

            if (amount < 0)
            {
                return Balance;
            }
            else
            {
                Balance += amount;
                return Balance;
            }

        }

        /// <summary>
        /// Prompts the user for standard ATM operations that links to each of the external methods. 
        /// </summary>
        public static void UserInterface()
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = OptionsMenu();
            }
            
        }

        public static bool OptionsMenu()
        {
                Console.WriteLine("Please choose a transaction: ");
                Console.WriteLine("1) View Balance");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) Deposit");
                Console.WriteLine("4) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                decimal Balance = ViewBalance();
                Console.WriteLine($"Your current balance is: {Balance}");
                return true;
            }
            else if (result == "2")
            {
                Console.WriteLine("Please enter the amount you wish to withdraw: ");
                string userInput = Console.ReadLine();
                decimal amount = Convert.ToDecimal(userInput);
                Withdraw(amount);
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("Please enter the amount you with to deposit: ");
                string userInput = Console.ReadLine();
                decimal amount = Convert.ToDecimal(userInput);
                Deposit(amount);
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
