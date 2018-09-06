using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Buffer : IDisposable
    {
        private const int dulj = 10;
        
        public Buffer()
        {

            data = new char[dulj]; 


        }
        private char [] data;

        public char [] Data
        {

            set { data = value; }
        }


        public void dobavi(string text)
        {
            var gosho = text.ToList();
            int pos = 0;
            while (true)
            {
                if (text.Length - pos > dulj)
                {
                    for (int i = 0; i < dulj; i++)
                    {

                        data[i] = gosho[pos];
                        pos++;

                    }
                    Dispose();
                }
                else
                {
                    var pos2 = pos;
                    for (int i = 0; i < text.Length - pos; i++)
                    {

                        data[i] = gosho[pos2];

                        pos2++;
                    }
                    Dispose();
                    break;
                }
            }


        }


        public void Dispose()
        {
            Console.WriteLine(string.Join(" ",data));
            data = new char[dulj];
        }
    }
}
