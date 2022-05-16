using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Atama ve Islemli Atama Operatorleri***");

            int x = 5;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);



            // Mantiksal operatorler
            // || (veya), && (ve), ! (degil)

            Console.WriteLine("***Mantiksal Operatorler***");

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // Iliskisel operatorler
            // == , != , < , > , <= , >=

            Console.WriteLine("***Iliskisel Operatorler***");

            int a = 1;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);


            // Aritmetik Operatorler

            Console.WriteLine("***Aritmetik Operatorler***");

            int sayi1 = 15;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % --> mod alir

            int sonuc2 = 16 % 3;
            Console.WriteLine(sonuc2);

        }
    }
}
