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
            club.AltaSocio("Juan", 1001, DateTime.Today.AddDays(30));
            // Agregar algunas actividades deportivas
            club.AgregarActividad("Natación", 20);
            club.AgregarActividad("Fútbol", 30);
            Console.WriteLine(club.InscribirActividad("Natación", 1001)); // Debería mostrar "INSCRIPCIÓN EXITOSA"

            // Intentar inscribir al socio en una actividad inexistente
            Console.WriteLine(club.InscribirActividad("Tenis", 1001)); // Debería mostrar "ACTIVIDAD INEXISTENTE"

            // Inscribir al socio en una segunda actividad
            Console.WriteLine(club.InscribirActividad("Fútbol", 1001)); // Debería mostrar "INSCRIPCIÓN EXITOSA"

            // Intentar inscribir al socio en una tercera actividad
            Console.WriteLine(club.InscribirActividad("Baloncesto", 1001)); // Debería mostrar "TOPE DE ACTIVIDADES ALCANZADO"

            // Intentar inscribir a un socio inexistente
            Console.WriteLine(club.InscribirActividad("Natación", 1002)); // Debería mostrar "SOCIO INEXISTENTE"

            // Mostrar la lista de socios del club
            Console.WriteLine("\nLista de Socios:");
            foreach (var socio in club.ObtenerSocios())
            {
                Console.WriteLine($"Nombre: {socio.GetNombre()}, ID: {socio.GetNumeroIdentificacion()}, Cuota Vencida: {socio.CuotaVencida()}");
            }

            // Mostrar la lista de actividades del club
            Console.WriteLine("\nLista de Actividades:");
            foreach (var actividad in club.ObtenerActividades())
            {
                Console.WriteLine($"Nombre: {actividad.GetNombre()}, Cupos Disponibles: {actividad.GetCuposDisponibles()}");
            }
        }
    }
}

            
    






