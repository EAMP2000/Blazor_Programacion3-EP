using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos

{
    public class Producto
    {
        [Required(ErrorMessage = "El campo Codigo debe ser Obligatorio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Codigo debe ser Obligatorio")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public byte[] Imagen { get; set; }

        
    }
}
