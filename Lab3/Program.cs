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

            NumberCheck(UserName, UserInput);

            string ContinueInput;
            Console.Write("Would you like to check another number? (Y/N): ");
            ContinueInput = Console.ReadLine();

            while (Continue(ContinueInput) == true)
            {
                Console.Write($"Okay {UserName}, please enter another positive number: ");
                UserInput = Console.ReadLine();

                NumberCheck(UserName, UserInput);

                Console.Write("Would you like to check another number? (Y/N): ");
                ContinueInput = Console.ReadLine();
            }

            Console.WriteLine($"Bye {UserName}, thanks for playing!");
            Console.ReadKey();
        }

        public static void NumberCheck(string UserName, string UserInput)
        {

            // Checks if user input is a valid positive integer between 1 and 100, and asks again if it is not.
            while (CheckInputValidity(UserInput) == false)
            {
                Console.WriteLine($"I'm sorry {UserName}, that was not a valid number.");
                Console.Write("Please enter a positive whole number: ");
                UserInput = Console.ReadLine();
            }
            // Changes user input into an integer for later use.
            int UserNumber = int.Parse(UserInput);

            if (CheckIfEven(UserNumber) == false && CheckIfGreaterThan60(UserNumber) == true)
            {
                // Checks if number is odd and greater than 60, then prints number and Odd to console if so.
                Console.WriteLine($"{UserName}, your number is {UserNumber} which is odd and greater than 60.");
            }
            else if (CheckIfEven(UserNumber) == true && CheckIfLessThan25(UserNumber) == true)
            {
                // Checks if number is even AND between 2 and 25, then prints to console.
                Console.WriteLine($"{UserName}, your number is Even and less than 25.");
            }
            else if (CheckIfEven(UserNumber) == true && CheckIfBetween26And60(UserNumber) == true)
            {
                // Checks if number is even AND between 26 and 60, then prints to console.
                Console.WriteLine($"{UserName}, your number is even.");
            }
            else if (CheckIfEven(UserNumber) == true && CheckIfGreaterThan60(UserNumber) == true)
            {
                // Checks if number is even AND greater than 60, then prints to console.
                Console.WriteLine($"{UserName}, your number is {UserNumber} which is even and greater than 60.");
            }
            else
            {
                // Prints this as any valid number not caught by above statements is less than 60 and odd.
                Console.WriteLine($"{UserName}, your number is {UserNumber} which is Odd.");
            }
        }

        // Checks if number input by user is a number and if number is between 1 and 100.
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

        // Checks if number input by user is even or odd.
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

        // Checks if number is between the numbers 25 and 2.
        public static bool CheckIfLessThan25(int userNumber)
        {
            if (userNumber <= 25 && userNumber >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks if number is between 26 and 60.
        public static bool CheckIfBetween26And60(int userNumber)
        {
            if (userNumber >=26 && userNumber <=60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks if number is greater than 60.
        public static bool CheckIfGreaterThan60(int userNumber)
        {
            if (userNumber > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks if user input is correct when asking to continue.
        public static bool Continue(string userInput)
        {
            if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
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
