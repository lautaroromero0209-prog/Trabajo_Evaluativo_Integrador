using System;

namespace Trabajo_Evaluativo_Integrador
{
    // ENCAPSAMIENTO: Definimos los atributos como "private" para proteger los datos 
    // y exponemos propiedades públicas (get y set) para controlar su acceso seguro.
    public class Empleado
    {
        private string nombre;
        private string dni;
        private double sueldoBase;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string DNI { get { return dni; } set { dni = value; } }
        public double SueldoBase { get { return sueldoBase; } set { sueldoBase = value; } }

        public Empleado(string nombre, string dni, double sueldoBase)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.sueldoBase = sueldoBase;
        }

        // POLIMORFISMO: Declaramos el método como "virtual" para que las clases 
        // derivadas tengan la posibilidad de sobreescribir y cambiar su comportamiento.
        public virtual double CalcularSueldo()
        {
            return sueldoBase;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("Tipo: Empleado");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Sueldo base: $" + sueldoBase);
            Console.WriteLine("Sueldo final: $" + CalcularSueldo());
        }
    }
}
