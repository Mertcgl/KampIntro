using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDictonary<int, string> dict = new MyDictonary<int, string>();

            dict.Add(1, "Mert");
            dict.Add(2, "BARAN");
            dict.Add(3, "BULAK");

            Console.WriteLine(dict.Value);
            


            Console.ReadLine();
        }
    }
}
