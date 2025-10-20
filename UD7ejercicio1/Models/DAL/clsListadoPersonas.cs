using System.Collections.Generic;
using UD7ejercicio1.Models.Entities;

namespace UD7ejercicio1.Models.DAL
{
    public class ListadoPersonas
    {
        // Lista privada donde almacenamos las personas
        private static List<Persona> lista = new List<Persona>()
        {
            new Persona(1, "Álvaro", "Márquez", 23),
            new Persona(2, "Lucía", "Serrano", 19),
            new Persona(3, "Carlos", "Jiménez", 28),
            new Persona(4, "María", "López", 22)
        };

        // Devuelve la lista completa
        public static List<Persona> GetListado()
        {
            return lista;
        }

        // Busca una persona por su Id
        public static Persona? GetPersonaById(int id)
        {
            return lista.FirstOrDefault(p => p.Id == id);
        }
    }
}
