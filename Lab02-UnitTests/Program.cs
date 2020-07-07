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
        }

        /// <summary>
        /// Returns the value of the current balance
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal ViewBalance(){}

        /// <summary>
        /// Subtracts money from the balance
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal Withdraw(){}

        /// <summary>
        /// Adds money to the balance
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal Deposit(){}

        /// <summary>
        /// Prompts the user for standard ATM operations that links to each of the external methods. 
        /// </summary>
        public static void UserInterface(){}

        //Testing the test
        public static string FizzBuzz(int number)
        {
            
             return "3";
            
        }
    }
}
