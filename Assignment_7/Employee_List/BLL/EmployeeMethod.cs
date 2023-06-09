﻿using Assignment_7.Models;
using System;


namespace Assignment_7.BLL
{
    public  class EmployeeMethod
    {
        List<Employee> empList = new List<Employee>();
        
        public int CreateEmployee(Employee emp)
        {
            empList.Add(emp);
            return 1;
        }
        public List<Employee> GetEmpList()
        {
            return empList;
        }
        public void UpdateEmployee(int  empId)
        {
        int count =0;
            try
            {
                foreach (var emp in empList)
                {
                    if (emp.EmployeeId == empId)
                    {
                        Console.WriteLine("Enter Updated Employee Name : ");
                        emp.EmployeeName = Console.ReadLine();

                        Console.WriteLine("Enter Updated Employee Age : ");
                        emp.EmployeeAge = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Updated Employee Salary : ");
                        emp.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Data has been updated succesfully!!");
                        count++;
                    }
                }
                if(count == 0)
                {
                    Console.WriteLine("Invalid Employee Id !!");
                }
               
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SearchEmployee(int empID)
        {
        int count =0;
            try
            {
                foreach(var emp in empList)
                {
                    if(emp.EmployeeId == empID)
                    {
                        Console.WriteLine("Employee Id : "+ emp.EmployeeId);
                        Console.WriteLine("Employee Name : " + emp.EmployeeName);
                        Console.WriteLine("Employee Age : " + emp.EmployeeAge);
                        Console.WriteLine("Employee Salary : " + emp.EmployeeSalary);
                        Console.WriteLine("");
                        count++;
                    }
                }
                 if(count == 0)
                {
                    Console.WriteLine("Invalid Employee Id !!");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteEmployee(int empId)
        {
        int count =0;
            try
            {
                foreach(var emp in empList)
                {
                    if(emp.EmployeeId == empId)
                    {
                        empList.Remove(emp);
                        Console.WriteLine("Employee data has been deleted successully!!");
                        count ++;
                    }
                }
                 if(count == 0)
                {
                    Console.WriteLine("Invalid Employee Id !!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
