using System;

namespace Trabajo_Evaluativo_Integrador
{
    // HERENCIA: La clase Vendedor hereda de la clase base Empleado todos sus atributos y métodos.
    public class Vendedor : Empleado
    {
        private double comision;

        public double Comision { get { return comision; } set { comision = value; } }

        public Vendedor(string nombre, string dni, double sueldoBase, double comision)
            : base(nombre, dni, sueldoBase) // Reutiliza el constructor de la clase base
        {
            this.comision = comision;
        }

        // POLIMORFISMO: Usamos "override" para redefinir el cálculo del sueldo, 
        // sumándole la comisión correspondiente a los vendedores.
        public override double CalcularSueldo()
        {
            return SueldoBase + Comision;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Tipo: Vendedor");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Sueldo base: $" + SueldoBase);
            Console.WriteLine("Comisión: $" + Comision);
            Console.WriteLine("Sueldo final: $" + CalcularSueldo());
        }
    }
}
