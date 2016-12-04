using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******");
            Console.WriteLine("Welcome to my Bank");
            var choice ="-1";
            while(choice != "0")
            {
               Console.WriteLine("Please select from the list of choices below:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Have a great day!");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        var checkingAccount = new Account();
                        checkingAccount.EmailAddress = emailAddress;
                        checkingAccount.AccountType = TypeOfAccounts.Checkings;
                        Console.WriteLine($"Account Number: {checkingAccount.AccountNumber}, Balance: {checkingAccount.Balance:C}");
                        break;
                    default:
                        break;

                }
            }
            Console.WriteLine("Please select from the list of choices below:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
             choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    Console.WriteLine("Have a great day!");
                    return;
                case "1":
                    Console.Write("Email Address: ");
                    var emailAddress = Console.ReadLine();
                    var checkingAccount = new Account();
                    checkingAccount.EmailAddress = emailAddress;
                    checkingAccount.AccountType = TypeOfAccounts.Checkings;
                    Console.WriteLine($"Account Number: {checkingAccount.AccountNumber}, Balance: {checkingAccount.Balance:C}");
                    break;
                    default:
                    break;
                
            }
           
        }
    }
}
