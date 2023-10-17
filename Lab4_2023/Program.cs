using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2023
{

    interface ISearchable
    {
        List<Product> SearchByPriceRange(List<Product> products, double minPrice, double maxPrice);
        List<Product> SearchByCategory(List<Product> products, string category);
        List<Product> SearchByRating(List<Product> products, int minRating);
    }


    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();


            store.AddProduct(new Product("Ліжко", 250, "Комфортне ліжко", "Меблі", 5));
            store.AddProduct(new Product("Телевізор", 500, "Великий телевізор", "Електроніка", 4));
            store.AddProduct(new Product("Книга", 20, "Цікава книга", "Книги", 4));


            User user = new User("user1", "password");
            store.RegisterUser(user);

            // Пошук товарів за категорією
            List<Product> furniture = store.SearchByCategory(store.Products, "Меблі");
            Console.WriteLine("Товари в категорії 'Меблі':");
            foreach (var product in furniture) ;



        }
    }
}
