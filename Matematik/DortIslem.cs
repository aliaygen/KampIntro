﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayı1,int sayı2)
        {
            int toplam = sayı1 + sayı2;
            Console.WriteLine("sonuç : " + toplam);
        }

        public void Cikar(int sayı1, int sayı2)
        {
            int cikar = sayı1 * sayı2;
            Console.WriteLine("sonuç : " + cikar);
        }
    }
}
