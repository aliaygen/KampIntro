using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBaseLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("veri tabanına loglandı"); ;
        }
    }
}
