using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticandoPuntoNetCore.Models
{
    public class Libro
    {
        [Display(Name = "ID")]
        [Key]
        public int IdPlay { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="El {0} debe ser al menos {2} y maximo caracteres", MinimumLength =3)]
        [Display(Name ="Titulo del libro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "la categoria es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "la Fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]
        public DateTime fechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El autor es obligatoria")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El precio es obligatoria")]        
        public int Precio { get; set; }

        
    }
}
