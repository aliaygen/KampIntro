using System;

namespace CustomerTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Id = 1;
            customer1.FirstName = "ahmet";
            customer1.LastName = "klınç";

            Customers customer2 = new Customers();
            customer2.Id = 2;
            customer2.FirstName = "selin";
            customer2.LastName = "ok";

            Customers customer3 = new Customers();
            customer3.Id = 3;
            customer3.FirstName = "mert";
            customer3.LastName = "taş";

            Customers customer4 = new Customers();
            customer4.Id = 4;
            customer4.FirstName = "leyla";
            customer4.LastName = "başak";

            CustomerManager customerManager = new CustomerManager();
            Customers[] customers = new Customers[]{customer1, customer2, customer3, customer4}; 

            customerManager.Add(customer1);
            customerManager.delete(customer2);
            customerManager.update(customer3);
            customerManager.list(customers);
        }
    }
}
