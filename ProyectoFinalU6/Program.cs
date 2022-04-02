using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalU6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pelicula;
            Console.WriteLine("--BIENVENIDO A CINEMA DORADO--");
            Console.WriteLine("Películas disponibles");
            Console.WriteLine("1. Morbius");
            Console.WriteLine("    Horarios: -16:50    -18:40    -20:30");
            Console.WriteLine("2. The Batman");
            Console.WriteLine("    Horarios: -15:00    -17:10    -21:45");
            Console.WriteLine("3. Los tipos malos");
            Console.WriteLine("    Horarios: -15:00    -17:00    -18:45     -20:30");
            Console.WriteLine("4. Ambulance: Plan de huida");
            Console.WriteLine("    Horarios: -15:50    -20:30");
            Console.WriteLine("Elige la opción que desees.");
            pelicula = Convert.ToInt32(Console.ReadLine());
            switch(pelicula)
            {
                case 1:
                    try
                    {
                        Horarios h = new Horarios();
                        Console.WriteLine("Elige un horario");
                        h.Hora1 = Console.ReadLine();

                    }
                    catch (HorarioNoDisponible1Exception)
                    {
                        Console.WriteLine("Elige un horario disponible.");
                        //exit(-1);
                    }
                    break;
                case 2:
                    try
                    {
                        Horarios h1 = new Horarios();
                        Console.WriteLine("Elige un horario");
                        h1.Hora2 = Console.ReadLine();

                    }
                    catch (HorarioNoDisponible1Exception)
                    {
                        Console.WriteLine("Elige un horario disponible.");
                    }
                    break;
                case 3:
                    try
                    {
                        Horarios h2 = new Horarios();
                        Console.WriteLine("Elige un horario");
                        h2.Hora3 = Console.ReadLine();

                    }
                    catch (HorarioNoDisponible1Exception)
                    {
                        Console.WriteLine("Elige un horario disponible.");
                    }
                    break;
                case 4:
                    try
                    {
                        Horarios h3 = new Horarios();
                        Console.WriteLine("Elige un horario");
                        h3.Hora4 = Console.ReadLine();

                    }
                    catch (HorarioNoDisponible1Exception)
                    {
                        Console.WriteLine("Elige un horario disponible.");
                    }
                    break;
                default:
                    Console.WriteLine("Debes escoger una opción del 1 al 4.");
                    break;
            }
            Console.WriteLine("¿Tienes membresía de Cinema Dorado?");
            string op = Console.ReadLine();
            switch (op)
            {

                case "Si"s:
                    ConMembresia con1 = new ConMembresia();
                    con1.ComprarBoletos();
                    Console.WriteLine("¡Disfruta la película!");
                    Console.WriteLine("Imprimir boleto. Si/No");
                    string imp = Console.ReadLine();
                    if (imp == "Si" || imp == "SI")
                    { con1.MostrarBoleto(); }
                    break;
                case "No":
                    SinMembresia sin1 = new SinMembresia();
                    sin1.ComprarBoletos();
                    Console.WriteLine("¡Disfruta la película!");
                    Console.WriteLine("Imprimir boleto. Si/No");
                    string imp1 = Console.ReadLine();
                    if (imp1 == "Si" || imp1 == "SI")
                    { sin1.MostrarBoleto(); }
                    break;
            }

            Console.WriteLine("¿Deseas comprar algo de comer?");
            string cafe = Console.ReadLine();
            if (cafe=="si" || cafe=="Si" || cafe=="SI")
            {
                Console.WriteLine("¿Qué tipo de membresía tienes?");
                Console.WriteLine("1. Membresía básica");
                Console.WriteLine("2. Membresía Compartida");
                Console.WriteLine("3. Membresía Premium");
                Console.WriteLine("4. No tengo membresía");
                int membresia = Convert.ToInt32(Console.ReadLine());
                switch (membresia)
                {
                    case 1:
                        MembBasica m1b=new MembBasica();
                        m1b.MostrarMenu();
                        Console.WriteLine(m1b.Venta());
                        Console.WriteLine("¿Quieres usar el cupón de 10% de descuento incluido en tu membresía en esta compra? Si/No");
                        string usarcupon = Console.ReadLine();  
                        if (usarcupon=="Si")
                        {
                            Console.WriteLine(m1b.Cupon());
                        }
                        Console.WriteLine(m1b.Puntos());
                        break;
                    case 2:
                        MembCompartida m1c = new MembCompartida();
                        m1c.MostrarMenu();
                        Console.WriteLine(m1c.Venta());
                        Console.WriteLine("¿Quieres usar el cupón de 10% de descuento incluido en tu membresía en esta compra? Si/No");
                        string usarcupon1 = Console.ReadLine();
                        if (usarcupon1 == "Si")
                        {
                            Console.WriteLine(m1c.Cupon());
                        }
                        Console.WriteLine(m1c.Puntos());
                        break;
                    case 3:
                        MembBasica m1p = new MembBasica();
                        m1p.MostrarMenu();
                        Console.WriteLine(m1p.Venta());
                        Console.WriteLine("¿Quieres usar el cupón de 10% de descuento incluido en tu membresía en esta compra? Si/No");
                        string usarcupon2 = Console.ReadLine();
                        if (usarcupon2 == "Si")
                        {
                            Console.WriteLine(m1p.Cupon());
                        }
                        Console.WriteLine(m1p.Puntos());
                        break;
                    case 4:
                        Console.WriteLine("¿Deseas adquirir una membresía?");
                        string nuevam = Console.ReadLine();
                        if (nuevam =="Si")
                        {
                            Console.WriteLine("¿Qué tipo de membresía quieres?");
                            Console.WriteLine("1. Membresía Básica");
                            Console.WriteLine("2. Membresía Compartida");
                            Console.WriteLine("3. Membresía Premium");
                            int tipo = Convert.ToInt32(Console.ReadLine());
                            switch (tipo)
                            {
                                case 1:
                                    Membresias mb=new Membresias();
                                    Console.WriteLine("Introduce el nombre del titular");
                                    string NombT = Console.ReadLine();
                                    Console.WriteLine("Introduce la edad");
                                    int edad = Convert.ToInt32(Console.ReadLine());
                                    mb.NuevaMembresia(NombT, edad);
                                    break;
                                case 2:
                                    Membresias mc = new Membresias();
                                    Console.WriteLine("Introduce el nombre del titular");
                                    string NombTc = Console.ReadLine();
                                    Console.WriteLine("Introduce la edad");
                                    int edad1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Introduce el nombre del titular");
                                    string NombA = Console.ReadLine();
                                    Console.WriteLine("Introduce la edad");
                                    int edad2 = Convert.ToInt32(Console.ReadLine());
                                    mc.NuevaMembresia(NombTc, NombA, edad1, edad2);
                                    break;
                                case 3:
                                    Membresias mp = new Membresias();
                                    Console.WriteLine("Introduce el nombre del titular");
                                    string NombTp = Console.ReadLine();
                                    Console.WriteLine("Introduce la edad");
                                    int edadp = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Número de acompañantes");
                                    int acomp = Convert.ToInt32(Console.ReadLine());
                                    mp.NuevaMembresia(NombTp, edadp, acomp);
                                    break;
                            }
                        }
                        break;
                }
            }
        }

        public class HorarioNoDisponible1Exception : Exception
        {
            public string Hora { get; private set; }

            public HorarioNoDisponible1Exception(string hora)
                : base ("Elige un horario disponible")
            {
                Hora = hora;
            }

        }
    }
}
