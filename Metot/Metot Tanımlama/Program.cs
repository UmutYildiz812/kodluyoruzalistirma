using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_dönüç_tipi metot_adı(parametreListesi/arguman
            //{
            ////komutlar
            ////return;
            //}

            int a = 4;
            int b = 3;
            Console.WriteLine(a + b); // değer atamalarıyla toplama işlemi

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc); // yeni bir metot yazıp yerine koyarak toplama işlemi

            Metotlar ornek = new Metotlar();
            ornek.ekranaYazdir(Convert.ToString(sonuc)); // yeni bir class içerisinde açılan yeni bir metotla ekrama yazma işlemi

            int sonuc2 = ornek.arttirVeTopla(ref a, ref b); // burada ref detayı için patika c# metot 1 izle
            ornek.ekranaYazdir(Convert.ToString(sonuc2));
            ornek.ekranaYazdir(Convert.ToString(a + b));
            Console.ReadLine();
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }
    
    class Metotlar
    {
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int arttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 2;
            return deger1 + deger2;
        }
    }
}
