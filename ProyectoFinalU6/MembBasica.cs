using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalU6
{
    internal class MembBasica : IMembresia
    {
        public double Descuento = .10;
        public double ComboInd = 75;
        public double ComboPareja = 135;
        public double ComboFamiliar = 200;
        public double ComboNachos = 95;
        public double Refresco = 35;
        public int Opcion;
        public double Total = 0;

        public MembBasica()
        {
            this.Descuento = Descuento;
            this.ComboInd = ComboInd;
            this.ComboPareja = ComboPareja;
            this.ComboFamiliar = ComboFamiliar;
            this.ComboNachos = ComboNachos;
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Combos disponibles:");
            Console.WriteLine("1. Combo Individual (Palomitas chicas y refresco de 250 ml): $" + ComboInd);
            Console.WriteLine("2. Combo Pareja (Palomitas medianas y 2 refrescos de 250 ml): $" + ComboPareja);
            Console.WriteLine("3. Combo Familiar (Palomitas grandes y 4 refresco de 355 ml): $" + ComboFamiliar);
            Console.WriteLine("4. Combo Nachos (Palomitas chicas, nachos y refresco de 250 ml): $" + ComboNachos);
            Console.WriteLine("5. Refresco extra (500 ml): $" + Refresco);

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
                        Total = Total + ComboFamiliar;
                        break;
                    case 4:
                        Total = Total + ComboNachos;
                        break;
                    case 5:
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
            Console.WriteLine("Descuento de membresía Básica aplicado con éxito.");
            Console.WriteLine("Total a pagar: $");
            return Total - (Total * Descuento);
        }

        public double Puntos()
        {
            Console.WriteLine("Puntos ganados con tu compra: ");
            return Total*.1;
        }
    }
}
