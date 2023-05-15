using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_
{
    class GenericList
    {
        List<int> employementId = new List<int>()
        {
            199701,
            200010,
            311995,
            131995,
            199204,
            199309,
            181994,
            199412
        };

        public void IterateList()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n*-*-*----List of EmployeesId----*-*-*\n");
            Console.WriteLine("Employee IDs");
            foreach (var empId in employementId)
            {
                Console.WriteLine("=> " + empId);
            }
        }
        public void AddId()
        {
            IterateList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEnter the number of Ids, You want to add in the list : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Enter the EmployementId : ");
                employementId.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\n-------List of EmployeeIds After Adding More Ids-------\n");
            foreach (var empId in employementId)
            {
                Console.WriteLine("=> " + empId);
            }

        }

        public void UpdateId()
        {
            IterateList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEnter the number of Ids, You want update in the list : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Enter the index number where you want to update the Id : ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Enter the updated Id : ");
                employementId[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n-------List of EmployeesId After Updating Ids-------\n");
            foreach (var empId in employementId)
            {
                Console.WriteLine("=> " + empId);
            }
        }
        public void InsertId()
        {
            IterateList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEnter the number of Ids, You want to insert in the list : ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i<num; i++)
            {
                Console.Write("Enter the index number where you want to insert the Ids : ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Enter the Ids you want to insert in the list : ");
                employementId.Insert(index, int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\n-------List of EmployeesIds After Inserting Ids-------\n");
            foreach (var empId in employementId)
            {
                Console.WriteLine("=> " + empId);
            }
        }
        public void SearchId()
        {
            IterateList();
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("\nEnter the number of Ids, You want to search : ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i<num; i++)
            {
                Console.Write("Enter the Ids you want to search : ");
                int Id = int.Parse(Console.ReadLine());
                bool trueOrFalse = employementId.Contains(Id);
                Console.WriteLine("\nIs list contains Id \"{0}\"? : {1}", Id, trueOrFalse);
            }
        }
        public void RemoveId()
        {
            IterateList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEnter the number of Ids, You want to remove : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the Ids you want to remove : ");
                employementId.Remove(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\n-------List of EmployeesId After Removing Ids-------\n");
            foreach (var empId in employementId)
            {
                Console.WriteLine("=> " + empId);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("NOTE :\tYellow color list defines EmployeesId before applying any method to them.\n\tCyan color lists define EmployeesId after applying methods to them.\n");
            GenericList obj = new GenericList();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Press 1 for Adding EmployeesId in the list..");
            Console.WriteLine("Press 2 for Updating EmployeesId in the list..");
            Console.WriteLine("Press 3 for Inserting EmployeesId in the list..");
            Console.WriteLine("Press 4 for Searching EmployeesId in the list..");
            Console.WriteLine("Press 5 for Removing EmployeesId in the list..");
            Console.WriteLine("Press 6 for Exit the program..");

            int num = int.Parse(Console.ReadLine());
            switch (num) 
            { 
                case 1:
                    obj.AddId();
                    break;
                case 2:
                    obj.UpdateId();
                    break;
                case 3:
                    obj.InsertId();
                    break;
                case 4:
                    obj.SearchId();
                    break;
                case 5:
                    obj.RemoveId();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
