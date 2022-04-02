using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoFinalU6.Program;

namespace ProyectoFinalU6
{
    internal class Horarios
    {
        public Horarios()
        {
        }
        private string _hora;
        public string Hora1
        { 
            get { return _hora; }
            set
            {
                if (value != "16:50" && value != "18:40" && value != "20:30")
                    throw new HorarioNoDisponible1Exception (value);
                _hora = value;
            }
        }
        public string Hora2
        {
            get { return _hora; }
            set
            {
                if (value != "15:00" && value != "17:10" && value != "21:45")
                    throw new HorarioNoDisponible1Exception(value);
                _hora = value;
            }
        }

        public string Hora3
        {
            get { return _hora; }
            set
            {
                if (value != "15:00" && value != "17:00" && value != "18:45" && value!="20:30")
                    throw new HorarioNoDisponible1Exception(value);
                _hora = value;
            }
        }

        public string Hora4
        {
            get { return _hora; }
            set
            {
                if (value != "15:50" && value != "20:30")
                    throw new HorarioNoDisponible1Exception(value);
                _hora = value;
            }
        }


    }
}
