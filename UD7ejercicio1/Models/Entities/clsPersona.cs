namespace UD7ejercicio1.Models.Entities
{
    /// <summary>
    /// Representa a una persona con nombre, apellidos y fecha de nacimiento.
    /// </summary>
    public class Persona
    {
        
        public int Id { get; }
        public  string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }


        // Constructor vacío
        public Persona() { }

        // Constructor con parámetros
        public Persona(int id, string nombre, string apellido, int edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }

        // Método para mostrar información
        public void Presentarse()
        {
            Console.WriteLine($"Hola, me llamo {Nombre} {Apellido} y tengo {Edad} años.");
        }
    }
}