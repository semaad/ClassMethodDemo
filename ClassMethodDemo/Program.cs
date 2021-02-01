using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.CustomerId = 1;
            customer1.CustomerName = "Ahmet";
            customer1.CustomerSurname = "Yılmaz";
            customer1.CustomerAge = 24;
            customer1.City = "Ankara";

            Customer customer2 = new Customer();

            customer2.CustomerId = 2;
            customer2.CustomerName = "Narin";
            customer2.CustomerSurname = "Kaya";
            customer2.CustomerAge = 45;
            customer2.City = "Bolu";

            Customer customer3 = new Customer();

            customer3.CustomerId = 3;
            customer3.CustomerName = "Kaya";
            customer3.CustomerSurname = "Davranoğlu";
            customer3.CustomerAge = 35;
            customer3.City = "Kayseri";

            Customer customer4 = new Customer();

            customer4.CustomerId = 4;
            customer4.CustomerName = "Zehra";
            customer4.CustomerSurname = "Sine";
            customer4.CustomerAge = 21;
            customer4.City = "İzmir";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);


            Console.WriteLine("--------------------------");




        }
    }
}
