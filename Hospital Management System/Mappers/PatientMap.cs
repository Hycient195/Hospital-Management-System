using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hospital_Management_System.Models;


namespace Hospital_Management_System.Mappers
{
    internal class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            Id(x => x.Id);
            Map(x => x.HospitalNumber);
            Map(x => x.FirstName);
            Map(x => x.Lastname);
            Map(x => x.Gender);
            Map(x => x.Address);
            Map(x => x.Age);
            Map(x => x.PhoneNumber);
            Map(x => x.Email);
            Map(x => x.Genotype);
            Map(x => x.BloodGroup);
            Map(x => x.RegistrationStatus);
            References(x => x.Bills);
            Map(x => x.MedicalConditions);
            Map(x => x.Drugs);
            References(x => x.Hospital);
            References(x => x.Appointment);

        }
    }
}
