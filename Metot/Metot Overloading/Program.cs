using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }

            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme -- Overloading

            int ifade = 999;
            instance.ekranaYazdir(ifade);
            instance.ekranaYazdir("Umut ", "Yıldız");
            Console.ReadLine();
            //metot imzası aynı olmazsa kabul etmez
            //metot imzası: metotAdı + parametreSayısı + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
