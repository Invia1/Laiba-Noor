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
        public int SpecialityToBeConsulted { get; set; }

        //readonly int PatientRegId;
        //string FirstName;
        //string LastName;
        //uint PhoneNo;
        //string Gender;
        //int Age;
        //string Address;
        //readonly uint AadharNo;
        //string SpecialityToBeConsulted;
        //const string Speciality1 = "General medicine";
        //const string Speciality2 = "Orthopaedics";
        //const string Speciality3 = "Dental";

        //public Patient(int patientRegId, string firstName, string lastName, uint phoneNo, string gender, int age, string address, uint aadharNo, string specialityToBeConsulted)
        //{
        //    PatientRegId = patientRegId;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    PhoneNo = phoneNo;
        //    Gender = gender;
        //    Age = age;
        //    Address = address;
        //    AadharNo = aadharNo;
        //    SpecialityToBeConsulted = specialityToBeConsulted;
        //}

    }
}
