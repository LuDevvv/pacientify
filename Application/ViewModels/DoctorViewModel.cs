using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Application.ViewModels
{
    public class DoctorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo FirstName es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El primer nombre no puede tener más de 50 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo LastName es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Dirección de correo electrónico no válida.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo PhoneNumber es obligatorio.")]
        [Phone(ErrorMessage = "Número de teléfono no válido.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo LicenseNumber es obligatorio.")]
        public string LicenseNumber { get; set; }
    }
}
