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

                

                // Alta de socios
                Console.WriteLine(club.altaSocio("Juan Pérez", 1001)); // Agregar un socio nuevo
                Console.WriteLine(club.altaSocio("María López", 1002)); // Agregar otro socio nuevo
                Console.WriteLine(club.altaSocio("Juan Pérez", 1001)); // Intentar agregar el mismo socio nuevamente

                // Inscripción en actividades
                Console.WriteLine(club.inscribirActividad("Fútbol", 1001)); // Inscribir a Juan Pérez en una actividad
                Console.WriteLine(club.inscribirActividad("Natación", 1002)); // Inscribir a María López en otra actividad

                // Mostrar información
                Console.WriteLine("---- Lista de socios ----");
                foreach (Socio socio in club.Socios)
                {
                    Console.WriteLine($"Nombre: {socio.Nombre}, ID: {socio.IdIdentificacion}");
                }

                Console.WriteLine("---- Actividades deportivas ----");
                foreach (ActividadDeportiva actividad in club.Actividades)
                {
                    Console.WriteLine($"Nombre: {actividad.Nombre}, Cupos disponibles: {actividad.Cupos}");
                }

               
                Console.WriteLine("Presiona Enter para salir...");
                Console.ReadLine();
            }
        }
    }







