using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            //if else şu şekilde yazılabilir:
            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın!");
            else if (time < 17)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi akşamlar");

            //şu şekilde de yazabilirsin:
            string sonuc = time <= 18 ? "İyi Günler!" : "İyi Geceler!";
            Console.WriteLine(sonuc);

            // üsttekini biraz uzattık:
            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);

            Console.ReadLine();

        }
    }
}
