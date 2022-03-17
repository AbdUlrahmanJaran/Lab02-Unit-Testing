using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    public class ATM
    {
        static public decimal Balance = 0;
        public static void UserInterface()
        {
            String userInputA = "";
            Console.WriteLine("enter one of those words 'ViewBalance, Deposit, Withdraw' to Choose a Transaction or enter exit to close");
            userInputA = Console.ReadLine();
            while (userInputA != "exit")
            {
                if (userInputA == "ViewBalance")
                {
                    Console.WriteLine(ViewBalance());
                }
                else if (userInputA == "Deposit")
                {
                    Console.WriteLine("enter a number to deposit");
                    String userInputB = Console.ReadLine();
                    Deposit(userInputB);
                }
                else if (userInputA == "Withdraw")
                {
                    Console.WriteLine("enter a number to withdraw");
                    String userInputC = Console.ReadLine();
                    Withdraw(userInputC);
                }
                Console.WriteLine("enter one of those words 'ViewBalance, Deposit, Withdraw' to Choose a Transaction or enter exit to close");
                userInputA = Console.ReadLine();
            }

        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Deposit(String sUserInput)
        {
            decimal dUserInput = 0;
            try
            {
                dUserInput = decimal.Parse(sUserInput);
            }
            catch (FormatException e)
            {
                Console.WriteLine("You should enter a number " + e.Message);
            }
            if (dUserInput < 0)
            {
                Console.WriteLine("You should enter a positive number");
            }
            else
            {
                Balance += dUserInput;
            }
            return Balance;
        }

        public static decimal Withdraw(String sUserInput)
        {
            decimal dUserInput = 0;
            try
            {
                dUserInput = decimal.Parse(sUserInput);
            }
            catch (FormatException e)
            {
                Console.WriteLine("You should enter a number " + e.Message);
            }
            if (dUserInput < 0)
            {
                Console.WriteLine("You should enter a positive number");
            }
            else if (dUserInput > Balance)
            {
                Console.WriteLine("You can't withdraw more than what you have " + "'" + Balance + "'");
            }
            else
            {
                Balance -= dUserInput;
            }
            return Balance;
        }
    }
}
