using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtsractClassDemo
{

    abstract class Shape
    {
        protected int area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
    internal class Square : Shape
    {
        int side;
        public override void GetDimensions()
        {
            Console.WriteLine("Enter Side");
            side = int.Parse(Console.ReadLine());
        }
        public override void CalculateArea()

        {
            area = side * side;
        }
        
    }

    internal class Rectange : Shape
    {
        int l, b;
        public override void GetDimensions()
        {
            Console.WriteLine("Enter l");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = int.Parse(Console.ReadLine());
        }
        public override void CalculateArea()

        {
            area = l * b;
        }
         
    }

    class Triangle : Shape
    {
        int Base, height;
        public override void CalculateArea()
        {
            area = (int).5 * Base * height;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter base");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            height = int.Parse(Console.ReadLine());
        }
    }

}
