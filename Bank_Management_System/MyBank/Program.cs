using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UserFunctions userFunctions = new UserFunctions();
            Console.WriteLine("Welcome to the Banking Management System");
            Console.WriteLine("------------------------------------------------------");
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Deposit to an account");
                Console.WriteLine("3. Withdraw from an account");
                Console.WriteLine("4. Display account details");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        userFunctions.CreateAccount();
                        break;
                    case "2":
                        userFunctions.MakeTransaction(true);
                        break;
                    case "3":
                        userFunctions.MakeTransaction(false);
                        break;
                    case "4":
                        userFunctions.DisplayAccounts();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
