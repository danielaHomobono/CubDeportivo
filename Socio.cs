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
        private int numeroIdentificacion;
        private DateTime fechaVencimientoCuota;
        private List<ActividadDeportiva> actividadesInscritas;

        public Socio(string nombre, int numeroIdentificacion, DateTime fechaVencimientoCuota)
        {
            this.nombre = nombre;
            this.numeroIdentificacion = numeroIdentificacion;
            this.fechaVencimientoCuota = fechaVencimientoCuota;
            this.actividadesInscritas = new List<ActividadDeportiva>();
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetNumeroIdentificacion()
        {
            return numeroIdentificacion;
        }

        public void SetNumeroIdentificacion(int numeroIdentificacion)
        {
            this.numeroIdentificacion = numeroIdentificacion;
        }

        public DateTime GetFechaVencimientoCuota()
        {
            return fechaVencimientoCuota;
        }

        public void SetFechaVencimientoCuota(DateTime fechaVencimientoCuota)
        {
            this.fechaVencimientoCuota = fechaVencimientoCuota;
        }

        public List<ActividadDeportiva> GetActividadesInscritas()
        {
            return actividadesInscritas;
        }

        public void InscribirActividad(ActividadDeportiva actividad)
        {
            actividadesInscritas.Add(actividad);
        }

        public bool CuotaVencida()
        {
            return DateTime.Today > fechaVencimientoCuota;
        }
    }
}
