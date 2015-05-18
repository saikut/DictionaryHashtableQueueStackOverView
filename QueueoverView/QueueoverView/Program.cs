using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueoverView
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> aQueue = new Queue<string>();

            aQueue.Enqueue("Hello");
            aQueue.Enqueue("BITM");
            aQueue.Enqueue("SEIP");

            //Console.WriteLine(aQueue.Peek());
            aQueue.Dequeue();

            foreach (string s in aQueue)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
