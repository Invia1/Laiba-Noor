using HospitalManagementSystem.Models;
using System;


namespace HospitalManagementSystem.BLL
{
    public class PatientDetails
    {
        List<Patient> patients = new List<Patient>();
        
        public int AddPatient (Patient patient)
        {
            
            patients.Add(patient);
            return 1;
        }
        public List<Patient> GetPatients ()
        {
            return patients;
        }
        
       
    }
}
