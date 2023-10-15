using Pacientify.Core.Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Domain.Entities
{
    public class LabTestResult
    {
        public int Id { get; set; }
        public int LabTestId { get; set; }
        public int PatientId { get; set; }
        public string Result { get; set; }
        public ResultStatus Status { get; set; }
    }
}
