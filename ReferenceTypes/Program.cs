using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);





            Customer customer = new Customer();
            customer.FirstName = "sıla";
            customer.CrecitCardNumber = "06513541625";


            Employee employee = new Employee();
            employee.FirstName = "veli";


            Person person3 = customer;
            customer.FirstName = "hale";


            Console.WriteLine(((Customer)person3).CrecitCardNumber);
            PersonMeneger personMeneger = new PersonMeneger();
            personMeneger.Add(employee);
            personMeneger.Add(customer);


        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base  class : person
    class Customer:Person
    {
        public string CrecitCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonMeneger
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
