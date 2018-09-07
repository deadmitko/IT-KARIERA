using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledqvane
{
    public class animal
    {
        public void Eat() { Console.WriteLine("eating"); }




    }
    public class dog:animal
    {
        public void bark() { Console.WriteLine("barking"); }

    }
    public class cat : animal
    {

        public void meow() { Console.WriteLine("meowing"); }


    }
    public class puppy : dog
    {
        public void weep() { Console.WriteLine("weeping"); }



    }
    class Program
    {
        static void Main(string[] args)
        {
            cat pesho = new cat();
            pesho.meow();
            dog pesho2 = new dog();
            pesho2.bark();
            puppy pesho3 = new puppy();
            pesho3.weep();


            CustomList gosho = new CustomList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            gosho.RemoveAtIndex();
        }
    }
}
