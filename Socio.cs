using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Socio
    {
        private string nombre;
        private int idIdentificacion;
        public List<ActividadDeportiva> Actividades { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int IdIdentificacion
        {
            get { return idIdentificacion; }
            set { idIdentificacion = value; }
        }

        public Socio(string nombre, int idIdentificacion)
        {
            this.Nombre = nombre;
            this.IdIdentificacion = idIdentificacion;
            Actividades = new List<ActividadDeportiva>();
        }
    }
}
