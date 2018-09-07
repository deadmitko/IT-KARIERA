using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    public class Sorter<T> where T:IComparable
    {
        
        public static CustomList<T> Sort(CustomList<T> gosho)
        {
           
             gosho.MyProperty.Sort();

            return gosho;
        }




    }
}
