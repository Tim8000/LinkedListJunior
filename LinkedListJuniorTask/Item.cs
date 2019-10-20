using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListJuniorTask
{
    /// <summary>
    /// List Node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T> 
    {
        private T data;     //Data.
        public Item<T> Next { get; set; }       //Next Node.

        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                {
                    data = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
