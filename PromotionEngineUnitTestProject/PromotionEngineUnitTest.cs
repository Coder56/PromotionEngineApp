using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineUnitTestProject
{
    [TestClass]
    public class PromotionEngineUnitTest
    {
        Product product = new Product();
        Price priceCalc = new Price();


        [TestMethod]
        public void GetTotalCost_A()
        {
            List<Product> productList = new List<Product>();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                string skuType = string.Empty;
                if (count == 0)
                    skuType = "A";
                else if (count == 1)
                    skuType = "B";
                else if (count == 2)
                    skuType = "c";

                product = product.getProduct(skuType.ToUpper());
                productList.Add(product);
                count++;
            }

            int TotalCost = priceCalc.GetTotalPrice(productList);
            Assert.AreEqual(TotalCost, 100);
        }

        [TestMethod]
        public void GetTotalCost_B()
        {
            List<Product> productList = new List<Product>();
            int count = 0;
            for (int i = 0; i < 15; i++)
            {
                string skuType = string.Empty;
                if (count == 0 || count < 6)
                    skuType = "A";
                else if (count > 6 && count < 10)
                    skuType = "B";
                else if (count == 10)
                    skuType = "c";

                 product = product.getProduct(skuType.ToUpper());
                productList.Add(product);
                count++;
            }

            int TotalCost = priceCalc.GetTotalPrice(productList);
            Assert.AreEqual(TotalCost, 370);
        }

      

        [TestMethod]
        public void getProductPrice()
        {
            string Id = "a";
             product = product.getProduct(Id.ToUpper());
            Assert.AreEqual(50, product.Price);
        }

        [TestMethod]
        public void GetTotalCostWithCandDSKUPromotion()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product() { Id = "A", Price = 80 });
            productList.Add(new Product() { Id = "B", Price = 60 });
            productList.Add(new Product() { Id = "C", Price = 30 });
            productList.Add(new Product() { Id = "D", Price = 25 });

            int TotalCost = priceCalc.GetTotalPrice(productList);
            Assert.AreEqual(TotalCost, 195);
        }                   
    }
}
