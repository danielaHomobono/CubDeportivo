using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClubDeportivo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubDeportivo club = new ClubDeportivo();

            // Agregar algunos socios
            club.AltaSocio("Juan", 12345, DateTime.Today.AddDays(30));
            club.AltaSocio("María", 67890, DateTime.Today.AddDays(-10));

            // Agregar algunas actividades deportivas
            club.AgregarActividad("Natación", 20);
            club.AgregarActividad("Fútbol", 30);

            // Mostrar información de los socios
            Console.WriteLine("Socios:");
            foreach (Socio socio in club.ObtenerSocios())
            {
                Console.WriteLine($"Nombre: {socio.GetNombre()}, Identificación: {socio.GetNumeroIdentificacion()}, Cuota vencida: {socio.CuotaVencida()}");
            }

            // Inscribir a un socio en una actividad deportiva
            int numeroIdentificacion = 12345; // Número de identificación del socio
            string nombreActividad = "Fútbol"; // Nombre de la actividad deportiva
            string resultado = club.InscribirActividad(nombreActividad, numeroIdentificacion);
            Console.WriteLine(resultado);

            // Mostrar información de las actividades deportivas
            Console.WriteLine("Actividades Deportivas:");
            foreach (ActividadDeportiva actividad in club.ObtenerActividades())
            {
                Console.WriteLine($"Nombre: {actividad.GetNombre()}, Cupos Disponibles: {actividad.GetCuposDisponibles()}");
            }
        }
    }
}





