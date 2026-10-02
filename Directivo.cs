using System;

namespace Trabajo_Evaluativo_Integrador
{
    // HERENCIA: La clase Directivo hereda directamente de la clase Empleado.
    public class Directivo : Empleado
    {
        private double bono;

        public double Bono { get { return bono; } set { bono = value; } }

        public Directivo(string nombre, string dni, double sueldoBase, double bono)
            : base(nombre, dni, sueldoBase)
        {
            this.bono = bono;
        }

        // POLIMORFISMO: Usamos "override" para adaptar el cálculo del sueldo sumando el bono.
        public override double CalcularSueldo()
        {
            return SueldoBase + Bono;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Tipo: Directivo");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Sueldo base: $" + SueldoBase);
            Console.WriteLine("Bono: $" + Bono);
            Console.WriteLine("Sueldo final: $" + CalcularSueldo());
        }
    }
}
