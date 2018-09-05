using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EvenNumber
    {

        List<int> chisla;
        public List<int> Chisla
        {
            get { return chisla; }
            set { chisla = value; }
        }

        private int num;
        public int Num
        {

            get { return num; }
            set {
                if (num % 2 == 0)
                {
                    num = value;
                }
            }
        }
        public EvenNumber()
        {
            chisla = new List<int>();
        }


        public void dobavi(int chislo)
        {
            chisla.Add(chislo);



        }
        
        


    }
}
