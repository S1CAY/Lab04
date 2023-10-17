using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2023
{
    class Store : ISearchable
    {
        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
        public List<Order> Orders { get; set; }

        public Store()
        {
            Products = new List<Product>();
            Users = new List<User>();
            Orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RegisterUser(User user)
        {
            Users.Add(user);
        }

        public void PlaceOrder(User user, List<Product> products, int quantity)
        {
            if (Users.Contains(user) && products.Count > 0 && quantity > 0)
            {
                Order order = new Order(products, quantity);
                Orders.Add(order);
                user.PurchaseHistory.Add(order);
                Console.WriteLine("Замовлення успішно оформлене.");
            }
            else
            {
                Console.WriteLine("Недійсний користувач або товари.");
            }
        }

        public List<Product> SearchByPriceRange(List<Product> products, double minPrice, double maxPrice)
        {
            return products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(List<Product> products, string category)
        {
            return products.Where(p => p.Category == category).ToList();
        }

        public List<Product> SearchByRating(List<Product> products, int minRating)
        {
            return products.Where(p => p.Rating >= minRating).ToList();
        }
    }
}
