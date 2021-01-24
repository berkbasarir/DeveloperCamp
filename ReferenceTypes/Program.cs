﻿using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean >>> value types/ değer tipler. Stack'de tutuluyor.
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayi 1 : " + sayi1);


            //arrays, class, interfaces >>> reference types/ referans tipler. heap'de tutuluyor. NEW yapınca stack'den heap'e referans atılıyor.
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;  // newlendiği için değer değil adres eşitleniyor.
            sayilar2[0] = 100;

            Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person1 = person2;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);

            Person customer = new Customer();
            Person employee = new Employee();

            employee.FirstName = "Berk";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


        }
    }

    //base class(ebeveyn) : Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
        
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
