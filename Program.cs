using System;
using System.Collections.Generic;

namespace Trabajo_Evaluativo_Integrador
{
    class Program
    {
        static void Main(string[] args)
        {
            // POLIMORFISMO: Creamos una lista mixta que almacena diferentes tipos de 
            // trabajadores (Vendedor, Directivo) bajo el tipo común de la clase base (Empleado).
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new Empleado("Juan Perez", "30111222", 500000));
            empleados.Add(new Vendedor("Pedro Gomez", "32123456", 450000, 80000));
            empleados.Add(new Directivo("Maria Lopez", "28111222", 700000, 150000));
            empleados.Add(new Vendedor("Lucas Fernandez", "35123456", 400000, 60000));

            Console.WriteLine("===== LIQUIDACIÓN DE HABERES =====");
            Console.WriteLine();

            foreach (Empleado empleado in empleados)
            {
                // POLIMORFISMO: En tiempo de ejecución se decide automáticamente qué versión 
                // de los métodos ejecutar según el objeto real que esté dentro de la lista.
                empleado.MostrarDatos();
                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}