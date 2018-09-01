using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }

        public Pair(int first, int last)
        {
            this.First = first;
            this.Last = last;
        }

        public override string ToString()
        {
            return $"({this.First}, {this.Last})";
        }

        public int Difference()
        {
            return Math.Abs(this.First - this.Last);
        }



    }
}
