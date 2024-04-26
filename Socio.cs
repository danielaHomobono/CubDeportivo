using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Socio
    {
        public string Nombre { get; set; }
        public int IdIdentificacion { get; set; }
        public List<ActividadDeportiva> Actividades { get; set; }

        public Socio(string nombre, int idIdentificacion)
        {
            Nombre = nombre;
            IdIdentificacion = idIdentificacion;
            Actividades = new List<ActividadDeportiva>();

        }

    }
}
