using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ali Aygen Turan
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "143535";
            customer1.FirstName = "ali aygen";
            customer1.LastName = "turan";
            customer1.TcNo = "3546854684";

            //Kodlama.io

            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNo = "5651343";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "5136566";

            //Gerçek Müşteri - Tüzel Müşteri
            //SO(L)ID

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Add(customer1);
            customerManeger.Add(customer2);



        }
    }
}
