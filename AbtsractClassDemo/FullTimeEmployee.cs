using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class FullTimeEmployee : Employee
    {
        string manager;
        double salary;
        public  void Get()
        //public void GetFullTimeEmployeeDetails()
        {
            base.Get();

            Console.WriteLine("Enter manager");
            manager = Console.ReadLine();
            Console.WriteLine("Enter salary");
            salary = Double.Parse(Console.ReadLine());
        }
        public void Display()
        //public void DisplayFullTimeEmployeeDetails()
        {
            base.Display();
            Console.WriteLine("manager is " + manager);
            Console.WriteLine("salary is " + salary);
        }

       public FullTimeEmployee() { }
        public FullTimeEmployee(int id,
        string name,
        string dept, string manager, double salary) : base(id, name, dept)
        {
            this.manager= manager;
            this.salary= salary;

        }
    }
}
