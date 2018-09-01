using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ColorSkeleton
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Color[] items;
        private int startIndex = 0;
        private int nextIndex = 0;
        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Color[capacity];
        }

        public int Count { get; private set; }

        public Color SumIntervalPairs()
        {
            Color result = new Color(0, 0, 0);
            for (int i = startIndex; i < nextIndex; i++)
            {
                result.R = result.R + this.items[i].R;
                result.G = result.G + this.items[i].G;
                result.B = result.B + this.items[i].B;

            }
            result.R = result.R % 256;
            result.G = result.G % 256;
            result.B = result.B % 256;
            return result;
        }

        public Color Sum()
        {
            Color result = new Color(0, 0, 0);
            for (int i = 0; i < this.Count; i++)
            {
                result.R = result.R + this.items[i].R;
                result.G = result.G + this.items[i].G;
                result.B = result.B + this.items[i].B;
            }
            result.R = result.R % 256;
            result.G = result.G % 256;
            result.B = result.B % 256;
            return result;
        }

        public void Add(Color item)
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
        public List<Color> Sort() {
            List<Color> gosho = new List<Color>();
            gosho = items.OrderByDescending(x => (x.R + x.G + x.B) / 3.0).ToList();
           
            return gosho;


        }

    }
}
