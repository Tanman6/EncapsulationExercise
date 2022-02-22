using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine($"Your account Balance is ${account.GetBalance()}");
            Console.WriteLine();
            Console.WriteLine("How much money would you like to deposit?");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine();
            Console.WriteLine($"Your new balance is {account.GetBalance()}");

        }
    }
}
