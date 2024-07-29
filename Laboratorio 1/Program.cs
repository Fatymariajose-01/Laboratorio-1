using System;

namespace SolicitarProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            SolicitarDatosProducto();
        }

        static void SolicitarDatosProducto()
        {
            
            Console.Write("Introduzaca el nombre del producto: ");
            int nombreProducto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el precio del producto: ");
            int precioProducto = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Nombre del producto: {nombreProducto}");
            Console.WriteLine($"Precio del producto: {precioProducto:}");
        }
    }
}
