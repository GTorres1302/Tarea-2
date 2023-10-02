using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_Productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introducir cuántos productos se desean
            Console.WriteLine("¡Bienvenido! \n¿Cuántos productos desea comprar?: ");
            int cantidadProductos = int.Parse(Console.ReadLine());

            // Asignación del precio según la cantidad de productos
            double precioPorProducto;

            if (cantidadProductos <= 10)
            {
                precioPorProducto = 20.0;
            }
            else
            {
                precioPorProducto = 15.0;
            }

            // Cálculo del precio según la cantidad de productos
            double precioTotal = cantidadProductos * precioPorProducto;

            Console.Clear();
            Console.WriteLine("Factura");
            Console.WriteLine("\nCantidad de productos adquiridos: " + cantidadProductos);
            Console.WriteLine("Precio total: $" + precioTotal.ToString("0.00"));
        }
    }
}