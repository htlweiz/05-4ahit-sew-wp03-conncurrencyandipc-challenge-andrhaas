using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace A3_ProducerConsumerQueue;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 3: Producer-Consumer");
        Console.WriteLine("==========================================\n");
        List<Producer> producers = new List<Producer>();
        Queue<Producer> queue = new Queue<Producer>();
         for (int i = 0; i < 5; i++)
        {
            Producer p = new Producer(i);
            
            producers.Add(p);
        }
        foreach (var p in producers)
        {
            queue.Enqueue(p);
        }

        
       

        Console.WriteLine("Producer und Consumer gestartet...\n");

       while (queue.Count < 50)
       {
            Thread.Sleep(1000);
            break;
       }
       

      
       
       
    }
}
