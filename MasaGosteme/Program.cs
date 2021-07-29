using System;

namespace MasaGosteme
{
    class Program
    {
        static void Main(string[] args)
        {
            int masa1, masa2, masa3, masa4, masa5, masa6, masa7, masa8, masa9, masa10
              , masa11, masa12, masa13, masa14, masa15, masa16, masa17, masa18, masa19, masa20
              , masa21, masa22, masa23, masa24, masa25, masa26, masa27, masa28, masa29, masa30;

            masa1 = 1; masa2 = 2; masa3 = 3; masa4 = 4; masa5 = 5; masa6 = 6; masa7 = 7; masa8 = 8; masa9 = 9; masa10 = 10;
            masa11 = 11; masa12 = 12; masa13 = 13; masa14 = 14; masa15 = 15; masa16 = 16; masa17 = 17; masa18 = 18; masa19 = 19; masa20 = 20;
            masa21 = 21; masa22 = 22; masa23 = 23; masa24 = 24; masa25 = 25; masa26 = 26; masa27 = 27; masa28 = 28; masa29 = 29; masa30 = 30;


            int[] sabahMasalar = new int[] { masa1, masa2, masa3, masa4, masa5, masa6, masa7, masa8, masa9, masa10 };
            int[] ogleMasalar = new int[] { masa11, masa12, masa13, masa14, masa15, masa16, masa17, masa18, masa19, masa20 };
            int[] aksamMasalar = new int[] { masa21, masa22, masa23, masa24, masa25, masa26, masa27, masa28, masa29, masa30 };

            Console.WriteLine("-oturmak istediğiniz vakti giriniz-");
            Console.WriteLine("sabah için : 1");
            Console.WriteLine("öğle için : 2");
            Console.WriteLine("akşam için : 3");
            int vakit =  Int16.Parse(Console.ReadLine());
            Console.WriteLine("-oturmak istediğiniz masa numarasını  giriniz-");
            int masaNo = Int16.Parse(Console.ReadLine());


           
            
                foreach (int masa in sabahMasalar)
                {
                    if (masa ==  masaNo )
                    {
                        Console.WriteLine("-oturabilirsiniz-");
                        return;
                    }
                }
                foreach (int masa in ogleMasalar)
                {
                    if (masa == masaNo)
                    {
                        Console.WriteLine("-oturabilirsiniz-");
                        return;
                    }
                }
                foreach (int masa in aksamMasalar)
                {
                    if (masa == masaNo)
                    {
                        Console.WriteLine("-oturabilirsiniz-");
                        return;
                    }
                }



            
        }

    }
}
