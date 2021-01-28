using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Ali";

            Customer customer = new Customer();
            customer.FirstName = "VEli";

            Employee employee = new Employee();
            Person person1 = customer;
            Console.WriteLine(person1);
           

        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer:Person
        {
            public int CustomerId { get; set; }
        }
        class Employee:Person
        {
            public int EmployeeId { get; set; }
        }
    }
}
