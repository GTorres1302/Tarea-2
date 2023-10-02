using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el carnet del estudiante:");
            string carnet = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();

            // Inicializar variables para las calificaciones
            double[] quices = new double[3];
            double[] tareas = new double[3];
            double[] examenes = new double[3];

            // Leer calificaciones de quices
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la calificación del Quiz {i + 1}:");
                quices[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Leer calificaciones de tareas
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la calificación de la Tarea {i + 1}:");
                tareas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Leer calificaciones de exámenes
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la calificación del Examen {i + 1}:");
                examenes[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calcular porcentaje de quices, tareas y exámenes
            double porcentajeQuices = (quices[0] + quices[1] + quices[2]) / 3 * 0.25;
            double porcentajeTareas = (tareas[0] + tareas[1] + tareas[2]) / 3 * 0.30;
            double porcentajeExamenes = (examenes[0] + examenes[1] + examenes[2]) / 3 * 0.45;

            // Calcular promedio final
            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;
            Console.Clear();

            // Determinar la condición del estudiante
            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            // Mostrar resultados
            Console.WriteLine("Resultados:");
            Console.WriteLine("\nCarnet del estudiante: " + carnet);
            Console.WriteLine("Nombre del estudiante: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices + ("%"));
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas + ("%"));
            Console.WriteLine("Porcentaje de Exámenes: " + porcentajeExamenes + ("%"));
            Console.WriteLine("Promedio Final: " + promedioFinal);
            Console.WriteLine("Condición del estudiante: " + condicion);
        }
    }
}