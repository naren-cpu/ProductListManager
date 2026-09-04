using System;
using System.Collections.Generic;
using System.Text;

namespace ProductListManager
{
    internal class Functions
    {
        public static void AddProduct()
        {
            List<string> product = new List<string>(); //Creating Empty List


            while (true)
            {
                Console.Write("Enter Product: ");

                string? data = Console.ReadLine();

                if (data.Trim().ToLower() == "exit")
                {
                    break;
                }

                // Check if the data is already in the list
                if (product.Contains(data))
                {
                    Console.WriteLine("WARNING:Product already exists.");
                }
                else
                {
                    product.Add(data);
                    Console.WriteLine("Product added successfully.");
                }

            }
        }

        public static void ViewProduct()
        {
            //Console.WriteLine("Searching product...");
            // View product logic here
        }

        public static void SearchProduct()
        {
            //Console.WriteLine("Searching product...");
            // Search product logic here
        }

        public static void DeleteProduct()
        {
            //Console.WriteLine("Deleting product...");
            // Delete product logic here
        }

        public static void Statistics()
        {
            
            // Statistics logic here
        }
    }
}
