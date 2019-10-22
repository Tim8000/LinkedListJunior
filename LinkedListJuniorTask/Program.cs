using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LinkedListJuniorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var valueList = new LinkedList<double>
            {
                1,2,3,4,5,8,2,1
            };

            foreach (var item in valueList)
            {
                Console.WriteLine(item);
            }

            var values = LinkedListExtensions.EnumerableNodes(valueList);

            var result = from element in values
                orderby element descending
                select element;

            Console.WriteLine(result.Count());
        }



        
    }
}
