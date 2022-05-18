using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir sayı girin: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
               if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


            // Tek sayılar ve çift sayıların toplamları
            int tekToplam = 0;
            int ciftTopllam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i%2 == 1)
                {
                    tekToplam = tekToplam + i; // tekToplam += i; şeklinde de yazılabilir.
                }

                else
                {
                    ciftTopllam = ciftTopllam + i;
                }
            }

            Console.WriteLine("Tek sayılar toplamı: " + tekToplam);
            Console.WriteLine("Çift sayılar toplamı: " + ciftTopllam);

           
            // break ve continue komutlarının farkları

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break; //eğer iç içe for döngülerin varsa break sadece kullanıldığı döngüyü sonlandırır!
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
