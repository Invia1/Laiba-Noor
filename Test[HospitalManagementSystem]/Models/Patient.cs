using System;


namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int PatientRegId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint PhoneNo { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public uint AadharNo { get; set; }
        public string SpecialityToBeConsulted { get; set; }

    }
}
