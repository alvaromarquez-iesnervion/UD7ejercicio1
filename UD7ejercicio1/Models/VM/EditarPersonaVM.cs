using UD7ejercicio1.Models.DAL;
using UD7ejercicio1.Models.Entities;

namespace UD7ejercicio1.Models.VM
{
    public class EditarPersonaVM
    {
        public Persona Persona { get; }
        private List<Departamento> Departamentos { get; }


        public EditarPersonaVM()
        {
            this.Persona= ListadoPersonas.RandPersona();
            this.Departamentos = ListadoDepartamentos.GetListado();
        }

        
    }
}
