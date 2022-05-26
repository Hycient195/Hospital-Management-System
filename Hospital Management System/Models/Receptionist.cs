// See https://aka.ms/new-console-template for more information

namespace Hospital_Management_System.Models
{
    class Receptionist
    {
        public Receptionist(string id, string firstName, string lastName, char gender, string phoneNumber, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public virtual string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual char Gender { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
    }
}