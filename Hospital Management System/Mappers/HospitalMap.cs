using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;

namespace Hospital_Management_System.Mappers
{
    internal class HospitalMap : ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            Map(x => x.PhoneLineNumber);
            Map(x => x.Email);
            HasMany(x => x.Doctors);
            HasMany(x => x.Nurses);
            HasMany(x => x.Pharmacists);
            HasMany(x => x.Accountants);
            HasOne(x => x.Receptionist);
            HasMany(x => x.Patients);
        }
    }
}
