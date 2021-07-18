using System;

namespace SoruOdevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci
            {
                no = 1,
                adı = "orhan",
                soyAdı = "ok",
            };

            Ogrenci ogrenci2 = new Ogrenci
            {
                no = 2,
                adı = "leman",
                soyAdı = "sert",
            };

            Ogrenci ogrenci3 = new Ogrenci
            {
                no = 3,
                adı = "halit",
                soyAdı = "akar"
            };

            Ogrenci ogrenci4 = new Ogrenci
            {
                no =4,
                adı ="ayşe",
                soyAdı ="lüle"
            };

            Ogrenci ogrenci5 = new Ogrenci
            {
                no =5,
                adı ="semih",
                soyAdı ="can"
            };

            Ogrenci ogrenci6 = new Ogrenci
            {
                no =6,
                adı ="onur",
                soyAdı ="okan"
            };

            Ogrenci ogrenci7 = new Ogrenci
            {
                no =7,
                adı ="gaye",
                soyAdı ="sönmez"
            };

            Ogrenci ogrenci8 = new Ogrenci
            {
                no =8,
                adı ="gamze",
                soyAdı ="dağlı"
            };

            Ogrenci ogrenci9 = new Ogrenci
            {
                no =9,
                adı ="sıla",
                soyAdı ="çekiç"
            };

            Ogrenci ogrenci10 = new Ogrenci
            {
                no =10,
                adı ="murat",
                soyAdı ="keser"
            };

            Ogrenci[] ogrenciler = new Ogrenci[] {ogrenci1,ogrenci2,ogrenci3,ogrenci4,ogrenci5,ogrenci6,ogrenci7,ogrenci8,ogrenci9,ogrenci10 };

            Console.WriteLine("öğrenci no giriniz");
            int girilenNO = Int16.Parse(Console.ReadLine());

            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (ogrenci.no == girilenNO)
                {
                    Console.WriteLine("öğrenciniz  " +ogrenci.adı+" "+ogrenci.soyAdı );
                    return;
                }




            }
            Console.WriteLine("Üzgünüz öğrencinizi bulamadık");
            Console.WriteLine("hatalı no girmiş olabilirsiniz");











        }
    }


    class Ogrenci
    {
        public int no { get; set; }

        public string adı { get; set; }

        public string soyAdı { get; set; }

        
    }









}

