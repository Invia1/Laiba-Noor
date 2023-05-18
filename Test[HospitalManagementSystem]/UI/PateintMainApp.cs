using HospitalManagementSystem.BLL;
using HospitalManagementSystem.Models;
using System;
using System.Diagnostics;

namespace HospitalManagementSystem.UI
{
    class PateintMainApp
    {
        static void Main()
        {
            bool RUN = true;
            int choice;
            Patient obj = new Patient();
            PatientDetails pd = new PatientDetails();

            while(RUN)
            {
                try
                {
                    Console.WriteLine("---------------------------------HOSPITAL MANAGEMENT SYSTEM----------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Specialities : GENERAL MEDICINE   ||   ORTHOPAEDICS   ||   DENTAL");
                    Console.WriteLine("");
                    Console.WriteLine("Press 1 To Add Patient Details");
                    Console.WriteLine("Press 2 To Show Patient Details List");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice) 
                    {
                        case 1:
                            Console.WriteLine("Enter Patient Registration ID : ");
                            obj.PatientRegId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Patient First Name : ");
                            obj.FirstName = Console.ReadLine();
                            if (string.IsNullOrEmpty(obj.FirstName))
                            {
                                Console.WriteLine("Please Enter Correct First Name: ");
                                obj.FirstName = Console.ReadLine();
                                continue;
                            }
                            foreach (char item in obj.FirstName)
                            {
                                if (char.IsDigit(item))
                                {
                                    Console.WriteLine("Digits are not allowed...");
                                    Console.WriteLine("Please Enter Correct First Name: ");
                                    obj.FirstName = Console.ReadLine();
                                    break;
                                }
                            }

                            Console.WriteLine("Enter Patient Last Name : ");
                            obj.LastName = Console.ReadLine();
                            if (string.IsNullOrEmpty(obj.LastName))
                            {
                                Console.WriteLine("Please Enter Correct Last Name: ");
                                obj.LastName = Console.ReadLine();
                                continue;
                            }
                            foreach (char item in obj.LastName)
                            {
                                if (char.IsDigit(item))
                                {
                                    Console.WriteLine("Digits are not allowed...");
                                    Console.WriteLine("Please Enter Correct Last Name: ");
                                    obj.LastName = Console.ReadLine();
                                    break;
                                }
                            }

                            Console.WriteLine("Enter Patient Phone Number : ");
                            obj.PhoneNo = Convert.ToUInt32(Console.ReadLine());

                            Console.WriteLine("Enter Patient Gender : ");
                            obj.Gender= Console.ReadLine();
                            if (string.IsNullOrEmpty(obj.Gender))
                            {
                                Console.WriteLine("Please Enter Correct Format: ");
                                obj.Gender = Console.ReadLine();
                                continue;
                            }
                            foreach (char item in obj.Gender)
                            {
                                if (char.IsDigit(item))
                                {
                                    Console.WriteLine("Digits are not allowed...");
                                    Console.WriteLine("Please Enter Correct Format: ");
                                    obj.Gender = Console.ReadLine();
                                    break;
                                }
                            }

                            Console.WriteLine("Enter Patient Age : ");
                            obj.Age = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Patient Address : ");
                            obj.Address = Console.ReadLine();
                            if (string.IsNullOrEmpty(obj.Address))
                            {
                                Console.WriteLine("Please Enter Correct Address: ");
                                obj.Address = Console.ReadLine();
                                continue;
                            }
                            foreach (char item in obj.Address)
                            {
                                if (char.IsDigit(item))
                                {
                                    Console.WriteLine("Digits are not allowed...");
                                    Console.WriteLine("Please Enter Correct Address: ");
                                    obj.Address = Console.ReadLine();
                                    break;
                                }
                            }

                            Console.WriteLine("Enter Patient Aadhar Number : ");
                            uint aadharNo = Convert.ToUInt32(Console.ReadLine());
                            if(aadharNo != obj.AadharNo || obj.AadharNo == 0)
                            {
                                obj.AadharNo = aadharNo;
                            }
                            else
                            {
                                Console.WriteLine("You Can't Enter Duplicate Data");
                                Environment.Exit(0);
                            }
                            

                            Console.WriteLine("Enter Which Speciality Patient Want To Be Consulted : ");
                            obj.SpecialityToBeConsulted = Console.ReadLine();
                            if (string.IsNullOrEmpty(obj.SpecialityToBeConsulted))
                            {
                                Console.WriteLine("Please Enter Correct Speciality: ");
                                obj.SpecialityToBeConsulted = Console.ReadLine();
                                continue;
                            }
                            foreach (char item in obj.SpecialityToBeConsulted)
                            {
                                if (char.IsDigit(item))
                                {
                                    Console.WriteLine("Digits are not allowed...");
                                    Console.WriteLine("Please Enter Correct Speciality: ");
                                    obj.SpecialityToBeConsulted = Console.ReadLine();
                                    break;
                                }
                            }

                            pd.AddPatient(obj);
                            break;

                        case 2:
                            Console.WriteLine("--------Patients List--------");
                            Console.WriteLine("");

                            List<Patient> patientList = pd.GetPatients();
                            foreach (var detail in patientList)
                            {
                                Console.WriteLine("Registration Id : " + detail.PatientRegId);
                                Console.WriteLine("First Name : " + detail.FirstName);
                                Console.WriteLine("Last Name : " + detail.LastName);
                                Console.WriteLine("Phone No : " + detail.PhoneNo);
                                Console.WriteLine("Gender : " + detail.Gender);
                                Console.WriteLine("Age : " + detail.Age);
                                Console.WriteLine("Address : " + detail.Address);
                                Console.WriteLine("Aadhar No. : " + detail.AadharNo);
                                Console.WriteLine("Speciality To Be Consulted : "+detail.SpecialityToBeConsulted);
                                Console.WriteLine("");
                                Console.WriteLine("");
                            }
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Do You Want To Continue The Program? If Yes Press 'Y' Or 'N");
                string confirm = Console.ReadLine();
                if (confirm != "Y")
                {
                    RUN = false;
                    break;
                }
            }
           
        }
    }
}
