using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Application.ViewModels
{
    public class PatientViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
        [Phone(ErrorMessage = "Número de teléfono no válido.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo Dirección es obligatorio.")]
        [MaxLength(255, ErrorMessage = "La dirección no puede tener más de 255 caracteres.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "El campo Número de Identificación es obligatorio.")]
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio.")]
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha inválido.")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Fumador")]
        public bool IsSmoker { get; set; }

        [Display(Name = "Tiene Alergias")]
        public bool HasAllergies { get; set; }
    }
}
