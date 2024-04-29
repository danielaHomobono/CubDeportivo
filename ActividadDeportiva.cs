using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class ActividadDeportiva
    {
        private string nombre;
        private int cupos;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Cupos
        {
            get { return cupos; }
            set { cupos = value; }
        }

        public ActividadDeportiva(string nombre, int cupos)
        {
            this.Nombre = nombre;
            this.Cupos = cupos;
        }
    }
}
