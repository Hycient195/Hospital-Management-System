// See https://aka.ms/new-console-template for more information

using Hospital_Database_Mapper;

namespace Hospital_Management_System.Models
{
    class Hospital
    {
        
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneLineNumber { get; set; }
        public virtual string Email { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Pharmacist> Pharmacists { get; set; }
        public List<Accountant> Accountants { get; set; }
        public Receptionist Receptionist { get; set; }
        public virtual List<Patient> Patients { get; set; }

    }


}