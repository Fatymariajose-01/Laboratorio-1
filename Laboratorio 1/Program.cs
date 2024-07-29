
namespace CompraProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int totalProductos = 0;
            int totalAcumulado = 0;
            int umbralDescuento = 10000;
            double descuento = 0.1;
          
            (totalProductos, totalAcumulado) = SolicitarProductos();

         
            double totalConDescuento = CalcularTotalConDescuento(totalAcumulado, umbralDescuento, descuento);

          
            Console.WriteLine($"Total de productos ingresados: {totalProductos}");
            Console.WriteLine($"Total de la compra: Q.{totalAcumulado / 100}.{totalAcumulado % 100:D2}");
            Console.WriteLine($"Total con descuento: Q.{totalConDescuento / 100}.{totalConDescuento % 100:D2}");
        }
        static (int, int) SolicitarProductos()
        {
            int totalProductos = 0;
            int totalAcumulado = 0;
            bool continuar = true;

            while (continuar)
            {
               
                Console.Write("Introduce el nombre del producto (o 'FIN' para terminar): ");
                string nombreProducto = Console.ReadLine();

                if (nombreProducto == "FIN")
                {
                    continuar = false;
                    break;
                }

               
                Console.Write("Introduce el precio del producto: ");
                string precioProductoStr = Console.ReadLine();

               
                int precioProducto;
                while (!int.TryParse(precioProductoStr, out precioProducto) || precioProducto < 0)
                {
                    Console.Write("Precio no válido. Introduce el precio del producto en centavos (número entero positivo): ");
                    precioProductoStr = Console.ReadLine();
                }

                
                totalAcumulado += precioProducto;
                totalProductos++;
            }

            return (totalProductos, totalAcumulado);
        }
        static double CalcularTotalConDescuento(int totalAcumulado, int umbralDescuento, double descuento)
        {
            double total = totalAcumulado / 100.0; 
            if (totalAcumulado > umbralDescuento)
            {
                total -= total * descuento;
            }
            return total;
        }
    }
}