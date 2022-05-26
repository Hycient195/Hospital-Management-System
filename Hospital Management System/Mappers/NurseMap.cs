using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.Mappers
{
    internal class NurseMap : ClassMap<Nurse>
    {
        public NurseMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Role);
            Map(x => x.Gender);
            HasOne(x => x.Hospital); 
        }
    }
}
