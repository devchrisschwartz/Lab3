using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for and stores user name
            Console.Write("Please enter your name: ");
            string UserName = Console.ReadLine();

            // Asks for user to input a number and stores what they typed
            Console.Write($"Hi {UserName}, please enter a positive number between 1 and 100: ");
            string UserInput = Console.ReadLine();

            // Checks if user input is a valid positive integer between 1 and 100, and asks again if it is not.
            while (CheckInputValidity(UserInput) == false)
            {
                Console.WriteLine($"I'm sorry {UserName}, that was not a valid number.");
                Console.Write("Please enter a positive whole number: ");
                UserInput = Console.ReadLine();
            }
            // Changes user input into an integer for later use.
            int UserNumber = int.Parse(UserInput);

            CheckIfEven(UserNumber);
        }


        public static bool CheckInputValidity(string userInput)
        {

            if (int.TryParse(userInput, out int isNumber) == false)
            {
                return false;
            }
            else if (isNumber < 1 || isNumber > 100)
            {
                return false;
            }

            return true;
        }


        public static bool CheckIfEven(int userNumber)
        {
            if (userNumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
