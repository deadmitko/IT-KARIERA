using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledqvane
{
    class CustomList:ArrayList
    {

        public void RemoveAtIndex()
        {
            Random r = new Random();
            int randomindex = r.Next(0, this.Count);
            Console.WriteLine(this[randomindex]);
            this.RemoveAt(randomindex);




        }




    }
}
