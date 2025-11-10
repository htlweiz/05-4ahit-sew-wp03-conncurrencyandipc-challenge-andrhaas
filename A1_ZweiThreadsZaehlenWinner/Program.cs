using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
    static int counterA = 0;
    static int counterB = 100;
    
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        Thread threadA = new Thread(() => CountUpThreadA());
        Thread threadB = new Thread(() => CountDownThreadB());
        threadA.Start();
        threadB.Start();
         
        threadA.Join();
        threadB.Join();
        if (counterA < 50)
        {
            Console.WriteLine("Gewonnen hat Thread B mit: " + counterB);
        }
        else if (counterA > 50)
        {
            Console.WriteLine("Gewonnen hat Thread A mit: " + counterA);
        }
        else if(counterA == 50)
        {
            Console.WriteLine("Unentschieden! Beide Zähler sind bei: " + counterA);
        }
        
    }
    
    private static void CountUpThreadA()
    {
        for (int i=0; i <= 100; i++)
        {
            counterA = i;
            Console.WriteLine($"Thread A: {i}");
            Thread.Sleep(100);
            if (counterA == counterB)
            {
                Console.WriteLine("ThreadA: " + counterA);
                Console.WriteLine("ThreadB: " + counterB);
                return;
            }
        
        }
        
    }
    
    private static void CountDownThreadB()
    {
        for (int i=100; i >= 1; i--)
        {
            counterB = i;
            Console.WriteLine($"Thread B: {counterB}");
            Thread.Sleep(100);
            if (counterA == counterB)
        {
            Console.WriteLine("ThreadA: "+counterA);
            Console.WriteLine("ThreadB: " + counterB);
                return;
        }
        }
       
    }
}
