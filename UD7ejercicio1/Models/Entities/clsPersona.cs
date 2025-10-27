namespace UD7ejercicio1.Models.Entities
{
    /// <summary>
    /// Representa a una persona con nombre, apellidos y departamento.
    /// </summary>
    public class Persona
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        // ID del departamento al que pertenece la persona
        public int IdDepartamento { get; set; }

        // Constructor vacío
        public Persona() { }

        // Constructor con parámetros sin departamento
        public Persona(int id, string nombre, string apellido, int edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }

        // Constructor con ID de departamento incluido
        public Persona(int id, string nombre, string apellido, int edad, int idDepartamento)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.IdDepartamento = idDepartamento;
        }
    }
}