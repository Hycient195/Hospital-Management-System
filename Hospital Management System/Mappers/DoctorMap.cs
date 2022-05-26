using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.Mappers
{
    internal class DoctorMap : ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Speciality);
            Map(x => x.Qualification);
            Map(x => x.Gender);
        }
    }
}
