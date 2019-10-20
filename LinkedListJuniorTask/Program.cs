using System;
using System.Linq;
namespace LinkedListJuniorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);
            ll.Add(5);
            ll.InsertElementByIndex(7,0);

       //     Console.WriteLine(ll.GetElementByIndex(2));

            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("count" + ll.Count);
        }
    }
}
