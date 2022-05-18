using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayarak girilen sayıya kadar (dahil) olan sayıların aritmetik ortalaması

            Console.Write("Bir sayı giriniz: ");
            float sayi = float.Parse(Console.ReadLine()); //eğitim videosunda int olarak aldık ancak ortalama alırken sonuç küsuratlı çıkabilir diye float aldım
            float sayac = 1f;
            float toplam = 0f;


            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            float ortalama = toplam / sayi;
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadLine();

            //a'dan z'ye karakterleri yazdırmak

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(" " + character);
                character++;
            }

            Console.WriteLine("***Foreach***");
            string[] arabalar = { "BMW", "Ford", "Nissan", "Audi" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }

    }
}
