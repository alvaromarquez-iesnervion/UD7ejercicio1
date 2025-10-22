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

        // 🔹 Nueva propiedad: Departamento al que pertenece la persona
        public Departamento Departamento { get; set; }

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

        // 🔹 Constructor con departamento incluido
        public Persona(int id, string nombre, string apellido, int edad, Departamento departamento)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Departamento = departamento;
        }

        // Método para mostrar información
        public void Presentarse()
        {
            string depInfo = Departamento != null ? $"Trabajo en {Departamento.NombreDepartamento}." : "No tengo departamento asignado.";
            Console.WriteLine($"Hola, me llamo {Nombre} {Apellido}, tengo {Edad} años. {depInfo}");
        }
    }
}
