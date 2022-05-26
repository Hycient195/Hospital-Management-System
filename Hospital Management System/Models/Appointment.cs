using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    class Appointment
    {
        public virtual int Id { get; set; }
        public virtual DateTime ScheduleDateAndTime { get; set; }
        public virtual string Reason { get; set; }
        public virtual string PatientHospitalNumber { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
