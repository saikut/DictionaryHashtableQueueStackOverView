using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableoverview
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();

            aHashtable.Add(101, 10023);
            aHashtable.Add("key", 323);
            aHashtable.Add(105, "Hello");
            aHashtable.Add("Kew", "value");

            Console.WriteLine(aHashtable.ContainsKey("key"));
            Console.WriteLine(aHashtable.ContainsValue(323));
            Console.WriteLine(aHashtable[101]);
            Console.ReadKey();
        }
    }
}
