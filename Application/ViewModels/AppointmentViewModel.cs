using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Application.ViewModels
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo DoctorId es obligatorio.")]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "El campo PatientId es obligatorio.")]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "El campo AppointmentDate es obligatorio.")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de fecha y hora inválido.")]
        public DateTime AppointmentDate { get; set; }

        [Required(ErrorMessage = "El campo Reason es obligatorio.")]
        [MaxLength(255, ErrorMessage = "La razón no puede tener más de 255 caracteres.")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "El campo Status es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El estado no puede tener más de 20 caracteres.")]
        public string Status { get; set; }
    }
}
