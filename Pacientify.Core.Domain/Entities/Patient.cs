using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientify.Core.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSmoker { get; set; }
        public string Allergies { get; set; }
        public string Photo { get; set; }
    }
}
