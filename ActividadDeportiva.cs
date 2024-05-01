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
        private int cuposDisponibles;

        public ActividadDeportiva(string nombre, int cuposDisponibles)
        {
            this.nombre = nombre;
            this.cuposDisponibles = cuposDisponibles;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetCuposDisponibles()
        {
            return cuposDisponibles;
        }

        public void SetCuposDisponibles(int cuposDisponibles)
        {
            this.cuposDisponibles = cuposDisponibles;
        }
    }
}