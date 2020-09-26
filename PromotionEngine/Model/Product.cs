using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Product
    {
        public string Id { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }

        public Product getProduct(string ProductId)
        {
            Product product = new Product();            
            switch (ProductId)
            {
                case "A":
                    product.Id = ProductId;
                    product.Price = 50;                    

                    break;
                case "B":
                    product.Id = ProductId;
                    product.Price = 30;                    

                    break;
                case "C":
                    product.Id = ProductId;
                    product.Price = 20;                    

                    break;
                case "D":
                    product.Id = ProductId;
                    product.Price = 15;                    
                    break;
            }
            return product;
        }

    }
}

