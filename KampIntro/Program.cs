using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if ( dolarDun > dolarBugun )
            {
                Console.WriteLine("Azalış butonu");
            }
            else if ( dolarDun < dolarBugun )
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("degişmedi butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
