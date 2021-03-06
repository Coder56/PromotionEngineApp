﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Price priceCalc = new Price();
            List<Product> productList = new List<Product>();

            Console.WriteLine("Enter number of Orders");
            int numberOfUnits = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfUnits; i++)
            {
                Console.WriteLine(" Enter Product Type- A,B,C,D");
                string Type = Console.ReadLine();
                 product = product.getProduct(Type.ToUpper());
                productList.Add(product);                
            }

            int totalCost = priceCalc.GetTotalPrice(productList);
            Console.WriteLine("Total Cost For {0} Product's is {1}", numberOfUnits, totalCost);
            Console.ReadLine();
        }
    }
}
