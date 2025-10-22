using System.Collections.Generic;
using UD7ejercicio1.Models.Entities;

namespace UD7ejercicio1.Models.DAL
{
    /// <summary>
    /// Contiene un listado estático de departamentos.
    /// </summary>
    public static class ListadoDepartamentos
    {
        // Lista privada con los departamentos disponibles
        private static List<Departamento> listaDepartamentos = new List<Departamento>()
        {
            new Departamento(1, "Recursos Humanos"),
            new Departamento(2, "Desarrollo"),
            new Departamento(3, "Marketing"),
            new Departamento(4, "Ventas")
        };

        // Devuelve la lista completa de departamentos
        public static List<Departamento> GetListado()
        {
            return listaDepartamentos;
        }

        // Devuelve un departamento concreto por su Id
        public static Departamento? GetDepartamentoById(int id)
        {
            return listaDepartamentos.FirstOrDefault(d => d.IdDepartamento == id);
        }
    }
}
