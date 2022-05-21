using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sınıfı_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort (Dizi içerisindeki elemanların sıralanmasını sağlar)
            int[] sayiDizisi = { 15, 84, 34, 75, 3, 24, 36, 11 };

            Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            Console.ReadLine();

            //Clear (Dizi içinde ilk söylediğimiz indexden sonra ikincisi kadar indexe 0 değerini atar

            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayiDizisi, 2, 3);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.ReadLine();

            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            Console.ReadLine();

            Console.WriteLine("*** Index Of ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 36));
            Console.ReadLine();

            Console.WriteLine("*** Resize ***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 1;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            Console.ReadLine();
        }
    }
}
