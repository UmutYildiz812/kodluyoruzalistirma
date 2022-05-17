using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month) //Expression (kontrol etmek istediğimiz koşul)
            {   
                case 1:
                   Console.WriteLine("Ocak");
                   break;

                case 2:
                    Console.WriteLine("Şubat");
                    break;

                case 4:
                    Console.WriteLine("Nisan");
                    break;

                case 3:
                    Console.WriteLine("Mart");
                    break;
                default:
                    Console.WriteLine("Yanlış veri");
                break;

                    //şeklinde kullanılır.

                    //ama asıl olayı birden fazla koşulda aynı veri girilecekse ortaya çıkar.

                    switch (month)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("Kış mevsimi");
                            break;

                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("İlkbahar mevsimi");
                            break;

                        default:
                            break;
                    }

            }
        }
    }
}
