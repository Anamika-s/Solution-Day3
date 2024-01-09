using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceDemo;
namespace AbtsractClassDemo
{
    internal class Main2
    {
        static void Main()
        {
            //{Employee employee = new Employee();


            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.Get();

            Console.WriteLine("Enter choice");
            int ch = Byte.Parse(Console.ReadLine());
            Employee employee= null;
            if(ch==1)
              employee = new PartTimeEmployee();
            else if(ch==2)
                  employee = new FullTimeEmployee();

            Decide(employee);
        }
        static void Decide(Employee employee)
        {
            if(employee is PartTimeEmployee)
            {
                employee.Get();
                employee.Display();
            }
            else if(employee is FullTimeEmployee)
            {
                employee.Get();
                employee.Display();
            }


        }
    }
}
