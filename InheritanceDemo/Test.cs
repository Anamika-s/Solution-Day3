using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Student
    {
        int rn;
        string name;
        public Student()
        {

        }
        public Student(int rn, string name)
        {
            this.rn = rn;
            this.name = name;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Rn is " + rn);
            Console.WriteLine("NAme is " + name);
        }
    }
    class Sports : Student
    {
        string sportsName;
        protected int score;
        public Sports()
        {

        }
        public Sports(int rn , string name, 
            string sportsName, int score) : base(rn,name)
        {
            this.sportsName = sportsName;
            this.score = score;
        }
        public void DisplayDetails()

        {
            base.DisplayDetails();
            Console.WriteLine("Sports NAme is " + sportsName);
            Console.WriteLine("Score is " + score);
        }
    }

        class Test : Sports
        {
            int[] marks = new int[] { 90, 78, 67, 89, 67 };
            protected int total;
        public Test()
        {

        }
        public Test(int rn , string name, string sportsName, int score): base(rn ,name, sportsName, score) { }
            public void CalculateTotalMarks()
            {
                total = marks.ToList().Sum();
            }
            public void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine("Total Marks are " + total);
            }
        }

        class Result : Test
        {
            int totalScore;
        public Result()
        {

        }
        public Result(int rn, string name, string sportsName, int score) : base(rn, name, sportsName, score) { }

        public void CalulateTotalScore()
            {
                totalScore = total + score;
            }

            public void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine("Total Score is " + totalScore);
            }
        }
    }


