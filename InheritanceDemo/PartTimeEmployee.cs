using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceDemo
{
    internal class PartTimeEmployee : Employee
    {
        string projectName;
        string duartion;
        public void Get()
        //public void GetPartTimeEmployeeDetails()
        {
            base.Get();
            Console.WriteLine("Enter projectName");
            projectName = Console.ReadLine();
            Console.WriteLine("Enter duartion");
            duartion = Console.ReadLine();
        }
        public void Display()
        //public void DisplayPartTimeEmployeeDetails()
        {
             base.Display();
            Console.WriteLine("projectName is " + projectName);
            Console.WriteLine("duartion is " + duartion);
        }
        public PartTimeEmployee() : base() { }
        public PartTimeEmployee(int id,
        string name,
        string dept, string projectName, string duartion) :base(id, name, dept)
        {
            this.projectName = projectName;
            this.duartion = duartion;
        }

    }
}
