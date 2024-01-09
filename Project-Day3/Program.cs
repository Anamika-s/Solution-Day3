namespace Project_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}
            //int sum = 0;
            //foreach (int i in num)
            //{
            //    sum+= i;
            //    Console.WriteLine(i);
            //}

            //float avg = (float)sum/num.Length;
            //Console.WriteLine(avg);

            // LINQ
            //1 . Query syntax

            // (from range variable in datasource
            // select rangevariable

            var list = (from temp in num
            select temp);

            foreach(var x in list)
            { Console.WriteLine(x);
            }

            var evenList = (from temp in num
                            where temp % 2 == 0
                            select temp);
            Console.WriteLine("Even numbers");
            foreach (var x in evenList)
            {
                Console.WriteLine(x);
            }

            // Lazy loading

            var numbersMoreThan5 = (from temp in num
                                    where temp > 5
                                    select temp
                                    );

            Console.WriteLine("numbersMoreThan5");
            foreach (var x in numbersMoreThan5)
            {
                Console.WriteLine(x);
            }


            // Eager Loading

            var list1 = (from temp in num
                         select temp).ToList();


            int sum = (from temp in num
                       select temp).Sum();



            double avg = (from temp in num
                         select temp).Average();


            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 8 };
            var numList1 = (from temp in numList
                            select temp);



            List<string> students = new List<string>
            {  "Ajay", "vijay", "sagar", "deepak"};


            var listOfNames = (from temp in students
                               where temp.Contains("sagar")
                               select temp).ToList();


           
            var found = (from temp in students
                         where temp.Contains("gggg")
                         select temp).FirstOrDefault();


            Console.WriteLine("NAme found" + found);


            // Method Syntax

            var listNum = num.ToList();
            var evenList1 = num.Where(x => x % 2 == 0).ToList();
            var listNames = students.Where(x => x.Contains("sagar")).FirstOrDefault();
            var sum1 = num.ToList().Sum();






































        }
    }
}