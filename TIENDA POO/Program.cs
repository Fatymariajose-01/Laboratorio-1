using programaDos;

internal class Program
{
    static List<Product> products = new List<Product>();

    static void menu()
    {
        int option;
        try
        {

            Console.WriteLine("1. Consult product information");
            Console.WriteLine("2. Sell product");
            Console.WriteLine("3. Restock product");
            Console.WriteLine("4. Update product price");
            Console.WriteLine("5. Show product summary");
            Console.WriteLine("6. Create a new product");
            Console.WriteLine("7. List all products");
            Console.WriteLine("8. Exit");
            option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    ConsultProductInformation();
                    break;
                case 2:
                    SellProduct();
                    break;
                case 3:
                    RestockProduct();
                    break;
                case 4:
                    UpdateProductPrice();
                    break;
                case 5:
                    ShowProductSummary();
                    break;
                case 6:
                    CreateNewProduct();
                    break;
                case 7:
                    ListProducts();
                    break;
                case 8:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter the price as a number.");

        }

    }
    static void ConsultProductInformation()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            product.ConsultProductInformation();
        }
    }

    static void SellProduct()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            Console.WriteLine("Enter the quantity to sell:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            product.Sell(quantity);
        }
    }

    static void RestockProduct()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            Console.WriteLine("Enter the quantity to restock:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            product.Restock(quantity);
        }
    }

    static void UpdateProductPrice()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            Console.WriteLine("Enter the new price:");
            decimal newPrice = Convert.ToDecimal(Console.ReadLine());
            product.Update(newPrice);
        }
    }

    static void ShowProductSummary()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            product.ShowSummary();
        }
    }

    static void CreateNewProduct()
    {
        Product newProduct = Product.CreateProduct();
        products.Add(newProduct);
    }

    static void ListProducts()
    {
        if (products.Count > 0)
        {
            Console.WriteLine("List of products:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].name}");
            }
        }
        else
        {
            Console.WriteLine("No products registered.");
        }
    }

    static Product SelectProduct()
    {
        ListProducts();
        if (products.Count > 0)
        {
            Console.WriteLine("Select the product number:");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (index >= 0 && index < products.Count)
            {
                return products[index];
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }
        }
        else
        {
            return null;
        }
    }
}
