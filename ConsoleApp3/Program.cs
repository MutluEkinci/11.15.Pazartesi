using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 2: Kullanıcı tarafında girilen bir string ifadeyi her satıra bir karakter gelecek şekilde yazdırınız?
            string mesaj = Console.ReadLine();
            //for(int i=0;i<mesaj.Length;i++)
            //    Console.WriteLine(mesaj[i]);
            foreach (char c in mesaj)
            {
              //  c = 'A'; //sadece okur, yazamaz...
                Console.WriteLine(c);
            }

            Console.WriteLine( (byte)'a');
            Console.WriteLine((char)98);
        }
    }
}
