using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalU6
{
    internal class Membresias
    {
        public string IdCliente;

        public Membresias()
        {
            this.IdCliente = IdCliente;
        }


        public void NuevaMembresia(string NombreTit, int edad)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Membresía generada con éxito.");
            Console.WriteLine("Nombre del titular: " + NombreTit);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Tipo de membresía: Básica");
        }

        public void NuevaMembresia(string NombreTit, string NombreAcomp, int edadT, int edadA)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Membresía generada con éxito.");
            Console.WriteLine("Nombre del titular: " + NombreTit);
            Console.WriteLine("Edad: " + edadT);
            Console.WriteLine("Nombre del acompañante:" + NombreAcomp);
            Console.WriteLine("Edad: " + edadA);
            Console.WriteLine("Tipo de membresía: Compartida");
        }

        public void NuevaMembresia(string NombreTit, int edad, int acompañantes)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Membresía generada con éxito.");
            Console.WriteLine("Nombre del propietario: " + NombreTit);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Número de acompañantes permitidos: " + acompañantes);
            Console.WriteLine("Tipo de membresía: Premium");
        }
    }
}
