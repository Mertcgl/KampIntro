﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;

            int[] sayilar1 = new int[] { 10, 200, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1[0] = sayilar2[0];
            sayilar2[0] = 9990;
            Console.WriteLine(sayilar1[0]);
            Console.ReadLine();
        }
    }
}
