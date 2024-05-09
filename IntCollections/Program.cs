using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 10, -30, 10, -5 };
            Stack<int> stack1 = new Stack<int>(new int[] { 1, 10, -30, 10, -5 });
            Queue<int> queue1 = new Queue<int>(new int[] { 1, 10, -30, 10, -5 });
            HashSet<int> hashSet1 = new HashSet<int> { 1, 10, -30, 10, -5 };

            IEnumerable<int>[] diflists = new IEnumerable<int>[] { list1, stack1, queue1, hashSet1 };

            foreach (var collection in diflists)
            {
                Console.Write($"\n{collection.ToString()}");
                foreach (int item in collection)
                {
                    Console.Write($" {item},");
                }
            }
        }
    }
}