﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Yavuz";
            customer1.LastName = "Krokmaz";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer
            {
                City = "Diyarbakır",
                Id = 2,
                FirstName = "Mustafa",
                LastName = "Yıldız"
            };


            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }

    }

 
}
