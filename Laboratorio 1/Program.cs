using System;

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
       
