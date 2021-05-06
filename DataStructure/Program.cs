using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //var linkedlist = new LinkedList();
            //linkedlist.Add(56);
            //linkedlist.Add(30);
            //linkedlist.Add(70);
            //linkedlist.Display();
            //linkedlist.Search(70);
            ////var stack = new LinkedListStack();
            ////stack.Push(56);
            ////stack.Push(30);
            ////stack.Push(70);
            ////Console.WriteLine("--------------------");
            ////stack.Display();
            ////Console.WriteLine("--------------------");
            ////stack.Peek();
            ////Console.WriteLine("--------------------");
            ////stack.Pop();
            ////Console.WriteLine("--------------------");
            ////stack.Display();
            ////Console.WriteLine("--------------------");
            ////stack.IsEmpty();
            ////Console.WriteLine("--------------------");
            var queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("-------------------------");
            queue.Display();
            Console.WriteLine("-------------------------");
            queue.Dequeue();
            Console.ReadKey();
        }
    }
}
