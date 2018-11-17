using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public float SellingPrice { get; set; }
        public string SupId { get; set; }

        public Product(string id, string name, float sell, string sup)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.SellingPrice = sell;
            this.SupId = sup;
        }
    }
}
