// See https://aka.ms/new-console-template for more information

namespace Hospital_Management_System.Models
{

    class Doctor
    {
        public Doctor(int id, string firstName, string lastName, string speciality, string qualification, char gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Speciality = speciality;
            Qualification = qualification;
            Gender = gender;
        }

        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Speciality { get; set; }
        public virtual string Qualification { get; set; }
        public virtual char Gender { get; set; }
    }
}