using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 4:Kullanıcı tarafında girilen 10 tam sayiyi dizi uzerinde sıralayan programı yazınız?(Array.Sort() kullanmadan... )
            int[] sayilar = {99, 99, 345, 33, 6, 8, 1, 55, 22, 13, 44 };
            int temp;
            for (int i = 0; i < sayilar.Length; i++)
            { 
              for(int j=0;j<sayilar.Length;j++)
                {
                    if (sayilar[i] < sayilar[j])
                    {
                        temp = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = temp;
                    }
                }
            }
            foreach(int sayi in sayilar)
                Console.Write(sayi + " ");
            Console.WriteLine();
        }
    }
}
