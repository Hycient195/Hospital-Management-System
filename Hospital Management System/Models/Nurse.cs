// See https://aka.ms/new-console-template for more information


namespace Hospital_Management_System.Models
{
    class Nurse
    {
        public Nurse(int id, string firstName, string lastName, string role, char gender, Hospital hospital)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Gender = gender;
            Hospital = hospital;
        }

        public virtual int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public virtual char Gender { get; set; }
        public virtual Hospital Hospital { get; set; }

    }
}
