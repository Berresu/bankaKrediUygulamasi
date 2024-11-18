using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programlamayaGirisVize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yaşınızı Giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aylık Gelirinizi Giriniz: ");
            int aylikGelir = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kredi Notunuzu Giriniz: ");
            int krediNotu = Convert.ToInt32(Console.ReadLine());

            if (yas < 18)
            {
                Console.WriteLine("Kredi Alamazsınız. (Sebep: Yaşınız 18'den Küçük.)");
            }
            else if (yas >= 65)
            {
                Console.WriteLine("Kredi Alamazsınız. (Sebep: Yaşınız 65'den Büyük.)");
            }
            else if (aylikGelir < 5000)
            {
                Console.WriteLine("Kredi Alamazsınız. (Sebep: Aylık Geliriniz 5.000 TL'den Düşüktür.)");
            }
            else
            {
                if (aylikGelir > 5000 && aylikGelir < 15000)
                {
                    if (krediNotu < 500)
                    {
                        Console.WriteLine("Kredi Alamazsınız. (Sebep: Kredi Notunuz 500'ün Altındadır.)");
                    }
                    else if (krediNotu > 500 && krediNotu < 1000)
                    {
                        Console.WriteLine("30.000 TL'ye Kadar Kredi Alabilirsiniz.");
                    }
                    else if (krediNotu > 1000)
                    {
                        Console.WriteLine("50.000 TL Kredi Alabilirsiniz.");
                    }
                }

                else if (aylikGelir > 15000)
                {
                    if (krediNotu < 500)
                    {
                        Console.WriteLine("Kredi Alamazsınız. (Sebep: Kredi Notunuz 500'ün Altındadır.)");
                    }
                    else if (krediNotu > 500 || krediNotu < 1000)
                    {
                        Console.WriteLine("50.000 TL Kredi Alabilirsiniz.");
                    }
                    else if (krediNotu > 1000)
                    {
                        Console.WriteLine("200.000 TL Kredi Alabilirsiniz.");
                    }
                }
            }
        }
    }
}
