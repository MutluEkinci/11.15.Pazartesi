using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void BüyükHarf()
        {
            string mesaj = Console.ReadLine();
            Console.WriteLine(mesaj.ToUpper());
        }
        static void Main(string[] args)
        {
            //Soru 3: kucuk harfle yazılan bir ifadeyi BUYUK harfe ceviren kodu yazınız?

            string mesaj = Console.ReadLine();
            string buyukMesaj="";
          
            for (int i = 0; i < mesaj.Length; i++)
            {
                buyukMesaj += (char)((byte)mesaj[i] - 32);
            }

            Console.WriteLine(buyukMesaj);
            BüyükHarf();
        }
    }
}
