using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class TipoInscripcion
    {
        // Esta clase contendrá todo el código común que será compartido entre todos los proyectos de la solución.
        // Aquí puedes agregar métodos, propiedades, utilidades y lógica que desees reutilizar en diferentes partes de la solución.
        // Ejemplo: métodos de validación, helpers para manejo de fechas, utilidades de configuración, etc.

        public int Id { get; set; }
        //data anotation que permite EF
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false; 
        public override string ToString()
        {
            return Nombre;
        }
    }
}
