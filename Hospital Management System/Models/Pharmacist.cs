// See https://aka.ms/new-console-template for more information

namespace Hospital_Management_System.Models
{
    class Pharmacist
    {
        public Pharmacist(string id, string firstName, string lastName, char gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        public virtual string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual char Gender { get; set; }

    }
}