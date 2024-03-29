﻿using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */
        static void Main()
        {
            //foreach (Product p in DataLoader.LoadProducts())
            //{
            //    Console.WriteLine(p.ProductName);
            //}

            //foreach (Customer c in DataLoader.LoadCustomers())
            //{
            //    Console.WriteLine(c.CompanyName);
            //}
            PrintOutOfStock_1();

            Console.ReadLine();
        }

        static void PrintOutOfStock_1()
        {
            var products = DataLoader.LoadProducts();

            var outOfStock = products.Where(p => p.UnitsInStock == 0);

            Console.WriteLine("Out of stock: ");
            foreach (var p in outOfStock)
            {
                Console.WriteLine(p.ProductName);
            }

            Console.Write("Press enter to continue");
            Console.ReadLine();
        }
    }
}
