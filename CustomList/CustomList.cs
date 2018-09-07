using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    public class CustomList<T>:IEnumerable where T : IComparable
    {
        
        private List<T> myVar;
       
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public List<T> MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
          public CustomList()
        {
            myVar = new List<T>();
        }

       public T iztrii(int index)
        {
            var temp = myVar[index];
            myVar.RemoveAt(index);
            return temp;
        }
       public void Add(T element)
        {
            myVar.Add(element);
            count++;
        }
        public bool Contains(T element)
        {
            var flag = false;
            if (myVar.Contains(element)) flag = true;
            
            return flag;
        }
        public void Swap(int element1, int element2)
        {
            var temp = myVar[element1];
            myVar[element1] = myVar[element2];
            myVar[element2] = temp;
        }
        public T Max()
        {
            return myVar.Max();
        }
        public T Min()
        {
            return myVar.Min();
        }
        public int CountGreaterThan(T element)
        {
            var count = 0;
            foreach (var item in myVar)
            {
                if (item.CompareTo(element) > 0) count++;
            }
            return count;
        }



        public override string ToString()
        {
            var result = "";
            foreach (var item in myVar)
            {
                result += item + "\n";
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return this.myVar.GetEnumerator();
        }
    }
}
