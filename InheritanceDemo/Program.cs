namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.Get();
            ////partTimeEmployee.GetPartTimeEmployeeDetails();
            //partTimeEmployee.Display();
            ////partTimeEmployee.DisplayPartTimeEmployeeDetails();


            //FullTimeEmployee fullTimeEmployee= new FullTimeEmployee();
            //fullTimeEmployee.Get();
            ////fullTimeEmployee.GetFullTimeEmployeeDetails();
            //fullTimeEmployee.Display();
            //fullTimeEmployee.DisplayFullTimeEmployeeDetails();

            FullTimeEmployee ft = new FullTimeEmployee(101, "ajay", "accts"
                , "deepak", 12000);
        }

        

    }
}