using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ante_proyecto.Models
{
    public class Formulario
    {
        [DisplayName("Cedula")]
        [Required]
        public int Cedula { get; set; }
        [DisplayName("Nombre")]
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        [Required]
        [StringLength(30)]
        public string Apellido { get; set; }
        [DisplayName("Telefono")]
        [Required]
        [StringLength(12)]
        public string Telefono { get; set; }
        [DisplayName("Correo")]
        [Required]
        [StringLength(30)]
        [EmailAddress]
        public string Correo { get; set; }
        //(Validar el formato de un correo electrónico)
        [DisplayName("Edad")]
        [Required]
        [Range(15, 99, ErrorMessage = "Tiene que ser mayor de 15")]
        public int Edad { get; set; }
        //(validar que sea mayor que 15)
        [DisplayName("Genero")]
        [Required]
        public string Genero { get; set; }
        //(Masculino/Femenino) (DropDownList)
        [DisplayName("Estado civil")]
        [Required]
        public string Estado_civil { get; set; }
        //(Casado/Soltero/Viudo/Union Libre) (RadioButton)
        [DisplayName("Hobby")]
        public bool Hobby { get; set; }
        //(Checkbox, incluir 4 pasatiempos)
    }
}