using Assignment_7.BLL;
using Assignment_7.Models;
using System;


namespace Assignment_7.UI
{
    class EmployeeMainApp
    {
        public static void Main()
        {
            int empId;
            string confirm;
            Employee emp;
            EmployeeMethod EmpApp = new EmployeeMethod();

            do
            {
                Console.WriteLine("Press 1 to Add Employee");
                Console.WriteLine("Press 2 to Show Employee List");
                Console.WriteLine("Press 3 to Update Employee Data in List");
                Console.WriteLine("Press 4 to Search Employee Data in List");
                Console.WriteLine("Press 5 to Delete Employee Data in List");
                Console.WriteLine("Press 6 to Exit the program");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                            try
                            {
                                emp = new Employee();
                                Console.WriteLine("Enter Employee Id : ");
                                emp.EmployeeId = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Employee Name : ");
                                emp.EmployeeName = Console.ReadLine();

                                Console.WriteLine("Enter Employee Age : ");
                                emp.EmployeeAge = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Employee Salary : ");
                                emp.EmployeeSalary = Convert.ToDouble(Console.ReadLine());
                                EmpApp.CreateEmployee(emp);

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        break;
                    case 2:
                        Console.WriteLine("--------Employee List------");
                        List<Employee> empList = EmpApp.GetEmpList();

                        foreach(var emps in empList)
                        {
                            Console.WriteLine("Employee Id : "+emps.EmployeeId);
                            Console.WriteLine("Employee Name : "+ emps.EmployeeName);
                            Console.WriteLine("Employee Age : " + emps.EmployeeAge);
                            Console.WriteLine("Employee Salary : " + emps.EmployeeSalary);
                            Console.WriteLine("");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Which employee details do you want to update? Please enter the employeeId : ");
                        empId = Convert.ToInt32(Console.ReadLine());
                        EmpApp.UpdateEmployee(empId);
                        break;
                    case 4:
                        Console.WriteLine("Which employee details do you want to search? Please enter the employeeId : ");
                        empId = Convert.ToInt32(Console.ReadLine());
                        EmpApp.SearchEmployee(empId);
                        break;
                    case 5:
                        Console.WriteLine("Which employee details do you want to delete? Please enter the employeeId : ");
                        empId = Convert.ToInt32(Console.ReadLine());
                        EmpApp.DeleteEmployee(empId);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine("Do you want to continue the program? If yes press 'Y'");
                confirm = Console.ReadLine();
            } while (confirm == "Y");
        }
    }
}
