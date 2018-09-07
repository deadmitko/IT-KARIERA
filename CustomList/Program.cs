using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> custom2 = new CustomList<string>();
                
            var gosho = Console.ReadLine();
            while (gosho != "END")
            {
                 var pesho = gosho.Split().ToList();
                switch (pesho[0])
                {
                    case "Add":
                        custom2.Add(pesho[1]);
                        break;
                    case "Remove":
                        var element = int.Parse(pesho[1]);
                        custom2.iztrii(element);
                        break;
                    case "Swap":
                        var element1 = int.Parse(pesho[1]);
                        var element2 = int.Parse(pesho[2]);
                        custom2.Swap(element1,element2);
                        break;
                    case "Cointains":

                        Console.WriteLine(custom2.Contains(pesho[1]));
                        break;
                    case "Max":

                        Console.WriteLine(  custom2.Max());
                        break;

                    case "Min":

                        Console.WriteLine(  custom2.Min());
                        break;

                    case "Greater":
                        Console.WriteLine(   custom2.CountGreaterThan(pesho[1]));
                        break;
                    case "Print":
                        Console.WriteLine(custom2);
                        break;
                   
                        
                }


                



                gosho = Console.ReadLine();
            }
            


        }
    }
}
