using Hospital_Management_System.Models;

namespace Hospital_Management_System.Models
{
    
    class Patient
    {
        public Patient(int id, string hospitalNumber, string firstName, string lastname, char gender, string address, int age, string phoneNumber, string email, string genotype, string bloodGroup, bool registrationStatus = false, List<Bill> bills, List<string> medicalConditions, List<string> drugs, Hospital hospital, List<Appointment> appointment)
        {
            Id = id;
            HospitalNumber = hospitalNumber;
            FirstName = firstName;
            Lastname = lastname;
            Gender = gender;
            Address = address;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            Genotype = genotype;
            BloodGroup = bloodGroup;
            RegistrationStatus = registrationStatus;
            Bills = bills;
            MedicalConditions = medicalConditions;
            Drugs = drugs;
            Hospital = hospital;
            Appointment = appointment;
        }

        public virtual int Id { get; set; }
        public virtual string HospitalNumber { get; set; } /* String variable is used because it is set to contain alphanumeric characters */
        public virtual string FirstName { get; set; }
        public virtual string Lastname { get; set; }
        public virtual char Gender { get; set; }
        public virtual string Address { get; set; }
        public virtual int Age { get; set; }
        public virtual string PhoneNumber { get; set; } /* Alphanumeric type is used here, reason ? adding non numeric code in country code : "";  */
        public virtual string Email { get; set; }
        public virtual string Genotype { get; set; }
        public virtual string BloodGroup { get; set; }
        public virtual bool RegistrationStatus { get; set; }
        public virtual List<Bill> Bills { get; set; }
        public virtual List<string> MedicalConditions { get; set; }
        public virtual List<string> Drugs { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Appointment> Appointment { get; set; }
        public void BookAppointment(Appointment appointment)
        {
            /* Revisit anddDo some cool stuff here later */
        }


    }
}