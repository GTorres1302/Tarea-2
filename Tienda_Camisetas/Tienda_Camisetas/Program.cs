using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Camisetas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a Blon Store!");

            // Solicitar la cantidad de camisetas y el precio de cada una
            Console.Write("\nIngrese la cantidad de camisetas que desea: ");
            int cantidadCamisetas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio de cada camiseta: ");
            double precioPorCamiseta = double.Parse(Console.ReadLine());

            // Calcular el precio total sin descuento
            double precioTotalSinDescuento = cantidadCamisetas * precioPorCamiseta;

            // Calcular el descuento según la cantidad de camisetas
            double descuento = 0.0;

            if (cantidadCamisetas >= 2 && cantidadCamisetas <= 5)
            {
                descuento = precioTotalSinDescuento * 0.15;
            }
            else if (cantidadCamisetas > 5)
            {
                descuento = precioTotalSinDescuento * 0.20;
            }

            // Calcular el precio total con descuento
            double precioTotalConDescuento = precioTotalSinDescuento - descuento;
            Console.Clear();

            // Mostrar el resultado
            Console.WriteLine("Factura");
            Console.WriteLine("\nPrecio total sin descuento: $" + precioTotalSinDescuento);
            Console.WriteLine("Descuento aplicado: $" + descuento);
            Console.WriteLine("Precio total con descuento: $" + precioTotalConDescuento);
        }
    }
}