using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalU6
{
    internal class MembCompartida : IMembresia
    {
        public double Descuento = .12;
        public double ComboInd = 70;
        public double ComboPareja = 180;
        public double ComboNachos = 120;
        public double Refresco = 35;
        public int Opcion;
        public double Total = 0;

        public MembCompartida()
        {
            this.Descuento = Descuento;
            this.ComboInd = ComboInd;
            this.ComboPareja = ComboPareja;
            this.ComboNachos = ComboNachos;
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Combos disponibles:");
            Console.WriteLine("1. Combo Individual (Palomitas chicas y refresco de 250 ml): $" + ComboInd);
            Console.WriteLine("2. Combo Pareja (2 Palomitas chicas y 2 refrescos de 250 ml): $" + ComboPareja);
            Console.WriteLine("3. Combo Nachos (Palomitas medianas, nachos y 2 refrescos de 250 ml): $" + ComboNachos);
            Console.WriteLine("4. Refresco extra (500 ml): $" + Refresco);

        }

        public double Venta()
        {
            string Agregar;
            do
            {
                Console.WriteLine("Elige la opción que deseas.");
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Total = Total + ComboInd;
                        break;
                    case 2:
                        Total = Total + ComboPareja;
                        break;
                    case 3:
                        Total = Total + ComboNachos;
                        break;
                    case 4:
                        Total = Total + Refresco;
                        break;
                    default:
                        Console.WriteLine("Escoge una opción del menú.");
                        break;

                }
                Console.WriteLine("¿Deseas agregar algo más?    Si/No");
                Agregar = Console.ReadLine();
            } while (Agregar == "Si");
            Console.WriteLine("Total a pagar: $");
            return Total;
        }
        public double Cupon()
        {
            Console.WriteLine("Descuento de membresía Compartida aplicado con éxito.");
            Console.WriteLine("Total a pagar: $");
            return Total - (Total * Descuento);
        }

        public double Puntos()
        {
            Console.WriteLine("Puntos ganados con tu compra: ");
            return Total * .1;
        }
    }
}
