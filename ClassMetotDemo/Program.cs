using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.TcNo = "12345678910";
            customer1.FirstName = "Berk";
            customer1.LastName = "Başarır";
            customer1.Phone = "05322132382";
            customer1.Email = "mail@berkbasarir.com.tr";


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);

        }
    }
}
