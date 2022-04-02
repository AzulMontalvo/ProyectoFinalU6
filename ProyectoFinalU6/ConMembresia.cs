using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalU6
{
    internal class ConMembresia : VentaBoletos
    {
        public ConMembresia()
        {
            this.IdCliente = IdCliente;
            this.Nombre = Nombre;
        }
        public double CostoBoleto = 60;

        public override void ComprarBoletos()
        {
            int Id = 0;
            Console.WriteLine("Introduce ID");
            int pIdCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre");
            string pNombre = Console.ReadLine();
            StreamWriter boleto;
            string IdVenta = $"C:\\Users\\monta\\Documents\\Programación Orientada a Objetos\\ProyectoFinalU6\\Boletos{Id}";
            boleto = File.CreateText(IdVenta);
            boleto.WriteLine("Id de venta " + Id);
            string Agregar = null;
            double totalprod;
            double total = 0;
                Console.WriteLine("¿Cuántos boletos comprarás?");
                double boletos = Convert.ToInt32(Console.ReadLine());
                VentaBoletos venta1 = new VentaBoletos();
                Console.WriteLine("Precio: $" + CostoBoleto);
                total = (boletos*CostoBoleto);
                Console.WriteLine("Total a pagar: $" + total);
                boleto.WriteLine("Número de boletos: " + boletos);
                boleto.WriteLine("Total a pagar: $" + total);
            boleto.WriteLine("---------------------------------------");
            boleto.Close();

        }

        public override void MostrarBoleto()
        {
            int Id = 0;
            StreamReader boleto;
            string IdVenta = $"C:\\Users\\monta\\Documents\\Programación Orientada a Objetos\\ProyectoFinalU6\\Boletos{Id}";

            string linea;
            boleto = File.OpenText(IdVenta);
            do
            {
                linea = boleto.ReadLine();
                Console.WriteLine(linea);
            } while (linea != null);
            Id = Id + 1;
            //return "¡Disfruta la función!";
        }
    }
}

    

