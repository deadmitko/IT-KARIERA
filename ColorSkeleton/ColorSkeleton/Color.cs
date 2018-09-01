using System;
using System.Collections.Generic;
using System.Text;

namespace ColorSkeleton
{
    class Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Color(int r, int g,int b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public override string ToString()
        {
            return $"({this.R}, {this.G}, {this.B})";
        }

        



    }
}
