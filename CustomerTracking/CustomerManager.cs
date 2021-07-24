using System;
using System.Collections.Generic;
using System.Text;


namespace CustomerTracking
{
    class CustomerManager
    {
        public void Add(Customers customer )
        {
            
            Console.WriteLine("müşteri "+customer.FirstName+" "+customer.LastName+" "+"eklendi");
            Console.WriteLine("--------------------------------1--------------------------------------");
        }

        public void delete(Customers customers)
        {
            Console.WriteLine("müşteri "+ customers.FirstName+" "+customers.LastName+" "+"silindi");
            Console.WriteLine("-------------------------2---------------------------------------------");

        }
        public void update(Customers customers)
        {
            Console.WriteLine("müşteri "+ customers.FirstName+ " "+customers.LastName+" "+ "güncellendi");
            Console.WriteLine("------------------3----------------------------------------------------");
        }
        public void list(Customers[] customers )
        {
            foreach (Customers customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
