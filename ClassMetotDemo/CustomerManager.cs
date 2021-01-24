using System;
namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Günvellendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi.");
        }

    }
}
