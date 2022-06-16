using System;
using System.Collections.Generic;

namespace WarehouseGoods
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(String.Join(" ",queue));
        }
    }
}
