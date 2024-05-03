using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class ClubDeportivo
    {
        private List<Socio> socios;
        private List<ActividadDeportiva> actividades;

        public ClubDeportivo()
        {
            socios = new List<Socio>();
            actividades = new List<ActividadDeportiva>();
        }

        // Agregamos una nueva actividad deportiva al club
        public void AgregarActividad(string nombre, int cuposDisponibles)
        {
            actividades.Add(new ActividadDeportiva(nombre, cuposDisponibles));
        }

        // Obtenemos lista de socios
        public List<Socio> ObtenerSocios()
        {
            return socios;
        }

        // Obtenemos la lista de actividades deportivas
        public List<ActividadDeportiva> ObtenerActividades()
        {
            return actividades;
        }

        // Buscamos un socio por su número de identificación
        private Socio BuscarSocio(int numeroIdentificacion)
        {
            foreach (Socio socio in socios)
            {
                if (socio.GetNumeroIdentificacion() == numeroIdentificacion)
                {
                    return socio;
                }
            }
            return null;
        }

        // Registramos a un nuevo socio 
        public bool AltaSocio(string nombre, int numeroIdentificacion, DateTime fechaVencimientoCuota)
        {
            if (BuscarSocio(numeroIdentificacion) != null)
            {
                return false; // El socio ya se encuentra registrado
            }
            else
            {
                socios.Add(new Socio(nombre, numeroIdentificacion, fechaVencimientoCuota));
                return true; // Socio registrado exitosamente
            }
        }

        // Inscribimos a un socio en una actividad deportiva
        // Inscribimos a un socio en una actividad deportiva
        public string InscribirActividad(string nombreActividad, int numeroIdentificacionSocio)
        {
            Socio socio = BuscarSocio(numeroIdentificacionSocio);
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            // Verificar si el socio ya está inscrito en la actividad
            foreach (ActividadDeportiva act in socio.GetActividadesInscritas())
            {
                if (act.GetNombre() == nombreActividad)
                {
                    return "El socio ya está inscrito en esta actividad.";
                }
            }

            if (socio.GetActividadesInscritas().Count >= 2)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            ActividadDeportiva actividad = actividades.Find(a => a.GetNombre() == nombreActividad);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            if (actividad.GetCuposDisponibles() <= 0)
            {
                return "No hay cupos disponibles para esta actividad.";
            }

            socio.InscribirActividad(actividad);
            actividad.SetCuposDisponibles(actividad.GetCuposDisponibles() - 1);
            return "INSCRIPCIÓN EXITOSA";
        }

    }
}