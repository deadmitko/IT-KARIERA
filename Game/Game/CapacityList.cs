using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CapacityList
    {

        private const int InitialCapacity = 2;
        private Pair[] items;
        private int startIndex = 0;
        private int nextIndex = 0;
        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count { get; private set; }

        public Pair SumIntervalPairs()
        {
            Pair result = new Pair(0, 0);
            for (int i = startIndex; i < nextIndex; i++)
            {
                result.First = result.First + this.items[i].First;
                result.Last = result.Last + this.items[i].Last;
            }
            return result;
        }

        public Pair Sum()
        {
            Pair result = new Pair(0, 0);
            for (int i = 0; i < this.Count; i++)
            {
                result.First = result.First + this.items[i].First;
                result.Last = result.Last + this.items[i].Last;
            }
            return result;
        }

        public void Add(Pair item)
        {
            if (nextIndex == items.Length && Count < items.Length)
            {
                items[startIndex] = SumIntervalPairs();
                startIndex++;
                Count++;
                nextIndex = startIndex;
            }
            if (nextIndex < items.Length)
            {
                items[nextIndex++] = item;
            }
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }




    }
}
