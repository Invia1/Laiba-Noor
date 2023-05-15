using Customize_EmployeeApp.Models;
using System;
using System.Collections.Generic;


namespace Customize_EmployeeApp.BLL
{
    public class HR
    {
        public void EmployeeDetails()
        {
            Employee emp = new Employee();

            List<Employee> EmpList = new List<Employee>();
            string next;
            do
            {
                Console.WriteLine("Enter Your Name: ");
                emp.EName = Console.ReadLine();

                Console.WriteLine("Enter Your Age: ");
                emp.EAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Qualifications: ");
                emp.EQualifications = Console.ReadLine();

                EmpList.Add(emp);

                Console.WriteLine("Do you want to add another employee ? (Type Y if yes else N for no)");
                next = Console.ReadLine();
            }
            while (next == "Y");

            Console.WriteLine("--------EMPLOYEE DETAILS-----\n");
            foreach (Employee employee in EmpList)
            {
                Console.WriteLine("Employee Name : " + employee.EName + "\nAge : " + employee.EAge + "\nQualifications : " + employee.EQualifications+"\n");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
