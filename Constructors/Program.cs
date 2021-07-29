using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "aygen", LastName = "Turan", City = "Bursa" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Hale", "Tokgöz", "Antalya");

            Console.WriteLine(customer2.FirstName);

            Method(2, "skmkd", "şkşkk", "şlsmlö.");

        }
        static void Method(int id, string firstName, string lastName, string city)
        {

        }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
