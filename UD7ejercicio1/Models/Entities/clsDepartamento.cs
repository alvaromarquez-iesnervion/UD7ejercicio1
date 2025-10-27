namespace UD7ejercicio1.Models.Entities
{
    /// <summary>
    /// Representa un departamento dentro de la organización.
    /// </summary>
    public class Departamento
    {
        // Propiedad que identifica de forma única al departamento
        public int IdDepartamento { get; }

        // Nombre del departamento (por ejemplo, Recursos Humanos, Ventas, etc.)
        public string NombreDepartamento { get; set; }

        // Constructor vacío (útil para serialización o frameworks)
        public Departamento() { }

        // Constructor con parámetros para inicializar directamente
        public Departamento(int idDepartamento, string nombreDepartamento)
        {
            IdDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
        }

        // Método opcional: devuelve una descripción del departamento
        public override string ToString()
        {
            return $"{NombreDepartamento} (ID: {IdDepartamento})";
        }
    }
}
