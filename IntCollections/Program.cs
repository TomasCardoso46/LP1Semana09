using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>(){1, 10, -30, 10, -5};
            Stack<int> stack1 = new Stack<int>(){1, 10, -30, 10, -5};
            Queue<int> queue1 = new Queue<int>(){1, 10, -30, 10, -5};
            HashSet<int> hashSet1 = new HashSet<int>(){1, 10, -30, 10, -5};
            var[] diflists = new var[] {list1, stack1, queue1, hashSet1};
            foreach (var dif in diflists)
            {
                Console.WriteLine("egege" + dif.ToString());
            }
        }
    }
}
