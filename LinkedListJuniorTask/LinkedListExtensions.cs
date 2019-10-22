using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListJuniorTask
{
    public static class LinkedListExtensions
    {
        public static IEnumerable<Item<T>> EnumerableNodes<T>(LinkedList<T> list)
        {
            var node = list.Head;
            while (node != null)
            {
                yield return node;
                node = node.Next;
            }
        }
    }
}
