using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2023
{
    class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }
        public string Status { get; set; }

        public Order(List<Product> products, int quantity)
        {
            Products = products;
            Quantity = quantity;
            TotalCost = products.Sum(p => p.Price) * quantity;
            Status = "В обробці";
        }
    }


}
