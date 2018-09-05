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
            
            for (int i=0; i < dulj; i++)
            {
                data[i] = gosho[i];
                
                
            }
            Dispose();
            for (int i = 0; i < gosho.Count - dulj; i++)
            {
                gosho.RemoveAt(i);


            }



        }


        public void Dispose()
        {
            Console.WriteLine(string.Join(" ",data));
            data = new char[dulj];
        }
    }
}
