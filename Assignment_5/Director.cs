using Customize_EmployeeApp.BLL;
using System;


namespace Customize_EmployeeApp
{
    class Director
    {
        static void Main(string[] args)
        {
            HR HRobj = new HR();
            HRobj.EmployeeDetails();
            Console.ReadLine();
        }
    }
}
