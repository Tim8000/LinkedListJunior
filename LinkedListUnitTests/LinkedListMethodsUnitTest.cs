using System;
using LinkedListJuniorTask;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
       

        [TestCase( 9, ExpectedResult = new int[] { 1, 4, 7, 9 })] 
        [TestCase( 18, ExpectedResult = new int[] { 1, 4, 7, 18 })] 
        [TestCase( 21, ExpectedResult = new int[] { 1, 4, 7, 21 })] 
        public int[] InsertvalueIntoTheEndOfList(int data)
        {
            LinkedList<int> valueList = new LinkedList<int>();
            valueList.Add(1);
            valueList.Add(4);
            valueList.Add(7);
            valueList.Add(data);

            var resultArray = new int[valueList.Count];

            for (int i = 0; i < valueList.Count; i++)
            {
                resultArray[i] = valueList.GetElementByIndex(i);
            }

            return resultArray;
        }

        [TestCase(2, 21, ExpectedResult = new int[] { 1, 4, 21, 7 })]
        public int[] InsertValueByIndex(int index ,int data)
        {
            LinkedList<int> valueList = new LinkedList<int>();
            valueList.Add(1);
            valueList.Add(4);
            valueList.Add(7);
            valueList.InsertElementByIndex(index,data);

            var resultArray = new int[valueList.Count];

            for (int i = 0; i < valueList.Count; i++)
            {
                resultArray[i] = valueList.GetElementByIndex(i);
            }

            return resultArray;
        }

        [TestCase(2, ExpectedResult = new int[] { 24, 2, 4 })]
        [TestCase(1, ExpectedResult = new int[] { 24, 3, 4 })]
        [TestCase(3, ExpectedResult = new int[] { 24, 2, 3 })]
        [TestCase(0, ExpectedResult = new int[] { 2, 3, 4 })]
        public int[] DeleteValueByIndex(int index)
        {
            LinkedList<int> valueList = new LinkedList<int>();
            valueList.Add(24);
            valueList.Add(2);
            valueList.Add(3);
            valueList.Add(4);
            valueList.Remove(index);

            var resultArray = new int[valueList.Count];

            for (int i = 0; i < valueList.Count; i++)
            {
                resultArray[i] = valueList.GetElementByIndex(i);
            }

            return resultArray;
        }

        [TestCase(10, 12)]
        public void InsertElementByItsIndexO_OutOfRangeException(int index, int data)
        {
            LinkedList<int> valueList = new LinkedList<int>();
            valueList.Add(3);
            Assert.Throws<IndexOutOfRangeException>(() =>valueList.InsertElementByIndex(index,data));
        }

        [TestCase(1, ExpectedResult = 5)]
        public int GetElementByIndex(int index)
        {
            LinkedList<int> valueList = new LinkedList<int>();
            valueList.Add(1);
            valueList.Add(5);
            valueList.Add(8);
            valueList.Add(53);
            return valueList.GetElementByIndex(index);
        }

    }
}