using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Application.ViewModels
{
    public class LabTestResultViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Id del Paciente es obligatorio.")]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "El campo Id de la Prueba de Laboratorio es obligatorio.")]
        public int LabTestId { get; set; }

        [Required(ErrorMessage = "El campo Resultado es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El resultado no puede tener más de 255 caracteres.")]
        public string Result { get; set; }

        [Required(ErrorMessage = "El campo Estado es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El estado no puede tener más de 20 caracteres.")]
        public string Status { get; set; }
    }
}
