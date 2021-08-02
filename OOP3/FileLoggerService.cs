using System;

namespace OOP3
{
    class FileLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı"); ;
        }
    }
}
