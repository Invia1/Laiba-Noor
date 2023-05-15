using System;


namespace Customize_EmployeeApp.Models
{
    public class Employee
    {
        string Name;
        int Age;
        string Qualifications;
        public string EName
        {
            get
            {
                return Name;
            }
            set
            {
                while (true)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Please Enter Correct Name: ");
                        value = Console.ReadLine();
                        continue;
                    }
                    foreach(char item in value)
                    {
                        if (char.IsDigit(item))
                        {
                            Console.Write("Digits Are NotAllowed....\n");
                            Console.Write("Please Enter Correct Name: \n");
                            value = Console.ReadLine();
                            break;
                        }
                    }
                    break;
                }
                Name = value;
            }

        }

        public int EAge
        {
            get
            {
                return Age;
            }
            set
            {
                if(value < 20)
                {
                    Console.WriteLine("You are not eligible for this job.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                Age = value;
            }
        }
        public string EQualifications
        {
            get
            {
                return Qualifications;
            }
            set
            {
                while (true)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Please Enter Correct Qualifications: ");
                        value = Console.ReadLine();
                        continue;
                    }
                    foreach (char item in value)
                    {
                        if (char.IsDigit(item))
                        {
                            Console.Write("Digits Are NotAllowed....\n");
                            Console.Write("Please Enter Correct Qualifications: ");
                            value = Console.ReadLine();
                            break;
                        }
                    }
                    break;
                }
                Qualifications = value;
            }
        }
    }
}
