using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class ClubDeportivo
    {
        public List<Socio> Socios { get; set; }
        public List<ActividadDeportiva> Actividades { get; set; }

        public ClubDeportivo()
        {
            Socios = new List<Socio>();
            Actividades = new List<ActividadDeportiva>();
        }

        public string altaSocio(string nombre, int idIdentificacion)
        {
            if (Socios.Exists(s => s.IdIdentificacion == idIdentificacion))
            {
                return "El socio ya se encuentra registrado.";
            }
            else
            {
                // Agregamos un nuevo socio a nuestra lista de socios
                Socios.Add(new Socio(nombre, idIdentificacion));
                return "Socio registrado exitosamente.";
            }
        }
        public string inscribirActividad(string nombreActividad, int idSocio)
        {
            // Buscar al socio 
            Socio socio = Socios.Find(s => s.IdIdentificacion== idSocio);
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            // Ya se inscribió a 3 actividades?
            if (socio.Actividades.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }
            

            // Buscamos la actividad por nombre
            ActividadDeportiva actividad = Actividades.Find(a => a.Nombre == nombreActividad);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }
            if (actividad.Cupos <= 0)
            {
                return "No hay cupos disponibles para esta actividad.";
            }

            // Inscribimosal socio en la actividad y decrementamos los cupos disponibles con--
            socio.Actividades.Add(actividad);
            actividad.Cupos--;

            return "INSCRIPCIÓN EXITOSA";
        }

    }
}
