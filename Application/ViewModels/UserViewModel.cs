using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Application.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre de Usuario es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo Correo Electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Dirección de correo electrónico no válida.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        [MaxLength(100, ErrorMessage = "La contraseña no puede tener más de 100 caracteres.")]
        public string PasswordHash { get; set; }

        [Display(Name = "Es Administrador")]
        public bool IsAdmin { get; set; }
    }

}
