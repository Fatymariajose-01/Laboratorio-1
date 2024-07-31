using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace programaDos
{
    internal class Product
    {
        public string name;
        private decimal price;
        private int stockQuantity;

        public Product(string name, decimal price, int stockQuantity)
        {
            this.name = name;
            this.price = price;
            this.stockQuantity = stockQuantity;
        }

        public void ConsultProductInformation()
        {
            Console.WriteLine($"Name: " + name);
            Console.WriteLine($"Price: " + price);
            Console.WriteLine($"Stock Quantity: " + stockQuantity);
        }

        public void Sell(int quantity)
        {
            if (quantity <= stockQuantity)
            {
                stockQuantity -= quantity;
                Console.WriteLine($"Sold {quantity} units of {name}. Remaining stock: {stockQuantity}");
            }
            else
            {
                Console.WriteLine("Not enough units available.");
            }
        }

        public void Restock(int quantity)
        {
            stockQuantity += quantity;
            Console.WriteLine("The new stock quantity is: " + stockQuantity);
        }

        public void Update(decimal newPrice)
        {
            price = newPrice;
            Console.WriteLine("Updated price of " + name + ": " + price);
        }

        public static Product CreateProduct()
        {
            Console.WriteLine("Enter the product name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the product price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the stock quantity of the product:");
            int stockQuantity = Convert.ToInt32(Console.ReadLine());

            return new Product(name, price, stockQuantity);
        }

        public void ShowSummary()
        {
            Console.WriteLine($"Product Summary: {name}, Price: {price:C}, Stock: {stockQuantity}");
        }
    }
}
