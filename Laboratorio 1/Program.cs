namespace SolicitarProducto
{
    class Program
    {
   
        static void Main(string[] args)
        {
            SolicitarDatosProducto();
        }
        static void MostrarMenu()
        {
            Console.WriteLine("...Productos...");
            Console.WriteLine("1. Pelota...Q.80.000");
            Console.WriteLine("2. Carrito...Q.20.00");
            Console.WriteLine("3. Peluche...Q.15.00");
        }
        static void SolicitarDatosProducto()
        {

            Console.Write("Introduzaca el nombre del producto: ");
            int nombreProducto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el precio del producto: ");
            int precioProducto = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Nombre del producto: {nombreProducto}");
            Console.WriteLine($"Precio del producto: {precioProducto}");
        }
        static void AcumularPrecio()
        {
            
        }

    }
}
