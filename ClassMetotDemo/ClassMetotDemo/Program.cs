using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();

            customer1.FirstName = "Yunus Emre";
            customer1.LastName = "ÖZTÜRK";
            customer1.Balance = 600;

            Customer customer2 = new Customer();

            customer2.FirstName = "Engin";
            customer2.LastName = "Demirog";
            customer2.Balance = 6000;

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (Customer i in customers)//Customer veri tipi olarak kullanılıyor. var da yazsak olur
            {
                Console.WriteLine(i.FirstName);
                Console.WriteLine(i.LastName);
                Console.WriteLine(i.Balance);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------------Listeleme Metodu-------------------");

            CustomerManager customerManager = new CustomerManager();

            customerManager.customerList(customers);   






        }
    }
}
