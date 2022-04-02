using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalU6
{
    internal class VentaBoletos
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public virtual void ComprarBoletos()
        {
        }
        public virtual void MostrarBoleto()
        {

        }
    }
}
