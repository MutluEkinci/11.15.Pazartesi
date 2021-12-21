using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1:Kullanıcı tarafından girilen 5 tamsayının en kucuk olanını bulan programı yazınız(Dizi kullanarak )?
            int[] sayilar = new int[5];
            int kucukSayi;
            for(int i=0;i<sayilar.Length;i++)
            {
                Console.Write("{0}. sayiyi giriniz ",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            //kucukSayi = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (kucukSayi > sayilar[i])
            //        kucukSayi = sayilar[i];
            //}
            //Console.WriteLine("Dizinin en kucuk sayisi={0}", kucukSayi);
            
            Array.Sort(sayilar);
            Console.WriteLine("Dizinin en kucuk sayisi={0}", sayilar[0]);

            Console.WriteLine(sayilar.Min());
            
        }
    }
}
