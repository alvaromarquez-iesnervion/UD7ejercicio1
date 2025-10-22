using System.Collections.Generic;
using System.Linq;
using UD7ejercicio1.Models.Entities;

namespace UD7ejercicio1.Models.DAL
{
    /// <summary>
    /// Contiene un listado estático de personas.
    /// </summary>
    public static class ListadoPersonas
    {
        // 🔹 Obtenemos la lista de departamentos para asignarlos a las personas
        private static List<Departamento> departamentos = ListadoDepartamentos.GetListado();

        // Lista privada donde almacenamos las personas con su departamento asignado
        private static List<Persona> lista = new List<Persona>()
        {
            new Persona(1, "Álvaro", "Márquez", 23, departamentos[1]), // Desarrollo
            new Persona(2, "Lucía", "Serrano", 19, departamentos[2]),  // Marketing
            new Persona(3, "Carlos", "Jiménez", 28, departamentos[0]), // RRHH
            new Persona(4, "María", "López", 22, departamentos[3])     // Ventas
        };

        // Devuelve la lista completa
        public static List<Persona> GetListado()
        {
            return lista;
        }

  

        public static Persona GetPersonaByPosition(int position)
        {
            return lista[position-1];
        }

        public static Persona RandPersona()
        {
            Random random = new Random();
            return lista[random.Next(lista.Count)];
        }
             

    }
}
