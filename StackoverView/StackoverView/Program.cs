using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackoverView
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> aStack = new Stack<int>();

            aStack.Push(101);
            aStack.Push(251);
            aStack.Push(325);
            aStack.Push(542);

           // Console.WriteLine(aStack.Peek());
            aStack.Pop();
            foreach (int i in aStack)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

          
        }
    }
}
