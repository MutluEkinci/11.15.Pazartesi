using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = new int[10];
            double[] dizi2 = new double[10];
            int[] dizi3 = { 1, 3, 45, 65, 76 };

            int[,] dizi4 = new int[5, 5]; //matris
            int[,,] dizi5 = new int[3, 3, 3];

            int[][] jagged = new int[3][];

            jagged[0] = new int[10];
            jagged[1] = new int[3];
            jagged[2] = new int[5];

            //Bir dizide n elaman varsa en son indis? n-1

            //IndexOutOfRange ???

            //Eleman sayisi belli olan bir dizinin eleman sayisi run-time da değiştirilemez(!!!)

            int[] diz10;

            diz10 = new int[20];
        }
    }
}
