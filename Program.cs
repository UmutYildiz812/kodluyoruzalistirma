using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("İsminizi Giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Soyadınızı Girin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname + ", ben Umut. Bu projeyi kolum kırık olduğu için tek elle yazdım :)");
            Console.ReadLine();

        }
    }
}
