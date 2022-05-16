using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Implicit Conversion***");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Umut";
            char f = 'e';
            object g = e + f + d;
            Console.WriteLine("g: " + g);


            // Explicit conversion
            Console.WriteLine("*** Explicit Conversion***");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString Metotu
            Console.WriteLine("***ToString Method***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 11.5f.ToString();
            Console.WriteLine("zz: " + zz);

            // System.Convert
            Console.WriteLine("***System.Convert Sinifi***");

            string s1 = "10"; string s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);
            
            Console.WriteLine("***Parse Metotu***"); // (Parse string ifadeleri donusturmek icin kullanılır bu yuzden yalnizca string kabul eder)

            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: " + rakam1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam2: " + double1);
            Console.ReadLine();
        }
    }
}
