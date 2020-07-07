using System;
using System.Net;

namespace Lab02_UnitTests
{
    public class Program
    {
        public static decimal Balance = 0;
        
        /// <summary>
        /// Calling the user interface method to activate the application
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //UserInterface();
            Balance = 5.67M;
            ViewBalance();
        }

        /// <summary>
        /// Returns the value of the current balance
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your current balance is: {Balance}");
            return Balance;
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
            else if(amount < 0)
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
        //public static void UserInterface(){}

        //Testing the test
        public static string FizzBuzz(int number)
        {
            
             return "3";
            
        }
    }
}
