using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class ActividadDeportiva
    {
        public string Nombre { get; set; }
        public int Cupos { get; set; }
        public ActividadDeportiva(string nombre, int cupos)
        {
            Nombre = nombre;
            Cupos = cupos;
        }
    }
}
