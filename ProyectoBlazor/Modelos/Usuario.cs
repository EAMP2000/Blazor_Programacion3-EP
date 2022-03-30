using System.ComponentModel.DataAnnotations; //Using para las alertas REQUIERED 

namespace Modelos
{
    public class Usuario
    {
        //Required manda una alerta al usuario de la misma manera que lo hacia el errorProvider
        [Required(ErrorMessage ="El campo Codigo debe ser Obligatorio")]
        public string CodigoUsuario { get; set; }
        [Required(ErrorMessage = "El campo Nombre debe ser Obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Rol debe ser Obligatorio")]
        public string Rol { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }
    }
}