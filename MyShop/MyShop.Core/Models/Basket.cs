using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Basket
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Basket(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        
    }
}
