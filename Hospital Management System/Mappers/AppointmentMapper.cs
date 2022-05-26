using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.Mappers
{
    internal class AppointmentMapper : ClassMap<Appointment>
    {
       public AppointmentMapper()
        {
            Id(x => x.Id);
            Map(x => x.ScheduleDateAndTime);
            Map(x => x.Reason);
            Map(x => x.PatientHospitalNumber);
            References(x => x.Doctor);
        }
    }
}
