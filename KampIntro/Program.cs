using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            //do not repeat yourself - kendini tekrar etme

            string katagoriEtiketi = "Katagori";
            int ogrenciSayisi = 32000 ;
            double faizOranı = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış oku");
            }
            else if (dolarBugun==dolarDun)
            {
                Console.WriteLine("değişmedi oku");
            }




            if (sistemeGirisYapmismi==true )
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }

            Console.WriteLine(katagoriEtiketi);

        }
    }
}
