using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonsiyonlar_II
{
    class Program
    {
        static int Topla(int s1, int s2)
        {
            //Console.WriteLine(s1+s2);//deger dondurme degil...
            return s1 + s2;
        }
        static double SilindirHacim(double r, double yukseklik)
        {
            return 3.14 * r * r * yukseklik;
        }

        static string Karsilastir(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
                return "sayi1 buyuk sayi2";
            else if (sayi1 < sayi2)
                return "sayi kucuk sayi2";

            return "Sayilar eşit...";
        }

        static string TerstenYaz(string str)
        {
            string yeni="";
            for (int i = str.Length - 1; i >= 0; i--)
                yeni += str[i];
            return yeni;
            
        }

        static long Faktoriyel(int sayi)
        {
            long sonuc = 1;
            for (int i = 1; i <= sayi; i++)
                sonuc *= i;
            return sonuc;
        }

        static int DiziTopla(int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
                toplam += sayi;
            return toplam;
        }
        static void Main(string[] args)
        {
            // Soru 5: iki tam sayiyi toplayan metodu yazınız...
            Console.WriteLine(Topla(12, 5));

            // Soru 6: Silindirin hacmini hesaplayan metodu yazınız...
            Console.WriteLine(SilindirHacim(5,10));
            // Soru 7: İki sayıyı karşılaştıran metodu yazınız (kucuk,buyuk,eşit)...

            Console.WriteLine(Karsilastir(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));

            // Soru 8: String ifadeyi tersten yazan metodu yazınız ...
            Console.WriteLine(TerstenYaz(Console.ReadLine()));

            // Soru 9: Faktoriyel hesaplayan metodu yazınız...
            Console.WriteLine(Faktoriyel(5));

            //Bir a tamsayi dizisini içrisindeki sayıların toplamını alıp sonucu döndüren metodu yazınız?

            int[] dizi1 = { 3, 45, 67, 8 };
            Console.WriteLine(DiziTopla(dizi1));
        }
    }
}
