using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizileri Tanımlama Şekilleri:
            string[] renkler = new string[6];

            string[] hayvanlar = { "Kuş", "Maymun", "Kedi", "Köpek", "Arı" };

            int[] dizi;
            dizi = new int[5];

            //Dizilerde Değer Atama ve Erişim
            renkler[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle Dizi Kullanımı

            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.WriteLine("Lütfen dizilerin uzunluğunu giriniz: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısını giriniz: ", i + 1);
                sayıDizisi[i] = int.Parse(Console.ReadLine()); 
            }

            int toplam = 0;
            foreach (var sayi in sayıDizisi)
                toplam += sayi;

            Console.WriteLine("Sayıların ortalaması: " + (toplam / diziUzunluğu));
            Console.ReadLine();

        }
    }
}
