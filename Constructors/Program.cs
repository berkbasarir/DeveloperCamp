using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Anakra" }; // parantez varmış gibi. olsada olur olmasada olur

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }

    }


    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı1 blok çalıştı");

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Yapıcı2 blok çalıştı");

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City{ get; set; }
    }
}
