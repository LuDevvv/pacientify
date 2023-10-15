using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Application.ViewModels
{
    public class LabTestViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre de la Prueba es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre de la prueba no puede tener más de 100 caracteres.")]
        public string Name { get; set; }
    }
}
