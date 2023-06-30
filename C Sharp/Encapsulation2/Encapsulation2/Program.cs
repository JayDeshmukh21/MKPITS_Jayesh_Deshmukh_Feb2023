using System;

class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        account.Withdraw(500);
        account.Withdraw(800);
        Console.ReadLine();
    }
}
