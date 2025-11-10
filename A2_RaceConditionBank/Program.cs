using System;
using System.Threading;

namespace A2_RaceConditionBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 2: Race Condition – Bankkonto");
        Console.WriteLine("==========================================\n");
        
        // Bankkonto mit Startwert 1000 EUR erstellen
        BankAccount account = new BankAccount(1000);
        Console.WriteLine($"Startkontostand: {account.GetBalance()} EUR\n");
        for (int i = 0; i < 10; i++)
        {
            var t = new Thread(() => PerformBankOperations(account));
            t.Start();
            t.Join();
        }
    }
    
    private static void PerformBankOperations(BankAccount account)
    {
        
            account.Deposit(100);
            Thread.Sleep(10);
            account.Withdraw(150);
        
        Console.WriteLine($"Endkontostand: {account.GetBalance()} EUR");
    }
}

