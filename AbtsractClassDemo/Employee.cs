using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Employee
    {
        int id;
        string name;
        string dept;
        public virtual void Get()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Dept");
            dept = Console.ReadLine();
        }
        public virtual void Display()
        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine("NAme is " + name);
            Console.WriteLine("Dept is " + dept);
        }
        public Employee() { }
        public Employee(int id,
        string name,
        string dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
        //Employee(int id) { }
        //}
    }

}
