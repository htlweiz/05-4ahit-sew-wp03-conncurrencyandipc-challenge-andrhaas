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
        ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
         for (int i = 0; i < 5; i++)
        {
            Producer p = new Producer(i, queue);
            
            producers.Add(p);
        }
       

        
       

        Console.WriteLine("Producer und Consumer gestartet...\n");

        while (true)
        {
            Console.WriteLine($"Aktuelle Queue-Größe: {queue.Count}");
            if (queue.Count > 50)
            {
                break;
            }
            Thread.Sleep(100);
        }         
       
       

      
       
       
    }
}
