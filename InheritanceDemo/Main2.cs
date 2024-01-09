using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Main2
    {
        static void Main()

        {
            Result result= new Result(rn:1, name:"ajay", sportsName:"hockey", score:19);
            result.CalculateTotalMarks();
            result.CalulateTotalScore();
            result.DisplayDetails();
            

        }
    }
}
