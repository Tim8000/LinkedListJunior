﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;

namespace LinkedListJuniorTask
{
    /// <summary>
    /// Linked List.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable
    {
        private Item<T> Head { get; set; }       //First Element.
        private Item<T> Tail { get; set; }       //Last Element.
        public int Count { get; private set; }  //Elements Count.

        /// <summary>
        /// Linked List Initialization.
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Add an element to the end of the list.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {

            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Removes an element by its index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Remove(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                var toReturn = Head.Data;
                Head = Head.Next;
                Count--;
                return toReturn;
            }
            else
            {
                int counter = 0;
                Item<T> current = Head;
                while (counter != index - 1)
                {
                    current = current.Next;
                    counter++;
                }

                var toReturn = current.Next.Data;
                current.Next = current.Next;
                Count--;
                return toReturn;
            }
        }
        /// <summary>
        /// Gets Element from linked list by selected index.
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public T GetElementByIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                return Head.Data;
            }
            else
            {
                int counter = 0;
                Item<T> current = Head;
                while (counter != index - 1)
                {
                    current = current.Next;
                    counter++;
                }

                return current.Next.Data;
            }
        }
        /// <summary>
        /// Insert Data by selected index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        public void InsertElementByIndex(int index, T data)
        {
            Item<T> current = this.Head;
            var item = new Item<T>(data);

            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)  //If index equals zero, then append list from head.
            {
                item.Next = Head;
                Head = item;
            }
            else
            {
                for (int i = 0; i < index -1; i++)
                {
                    item.Next = current.Next;
                    current.Next = item;
                }

                Count++;
            }
        }
        /// <summary>
        /// Append List after selected value.
        /// </summary>
        /// <param name="targetValue"></param>
        /// <param name="data"></param>
        public void InsertAfter(T targetValue, T data)
        {
            if (Head != null)
            {
                var current = Head;

                while (current != null)
                {
                    if (current.Data.Equals(targetValue))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                        throw new Exception("Element not found.");
                    }
                }
            }
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Get all elements in list using foreach.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
