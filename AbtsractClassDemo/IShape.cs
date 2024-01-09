using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtsractClassDemo1
{
    internal interface IShape
    {
        
        void GetDimensions();
        void CalculateArea();
        void DisplayArea();
    }

    class Sqaure : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    class Rectangle : IShape
    {
        void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    interface IA1
    {
        void A();
        void B();
    }
    interface IB1
    {
        void C();
        void B();
    }

    class C : IA1, IB1
    {
        void IA1.A()
        {
            throw new NotImplementedException();
        }

        void IA1.B()
        {
            throw new NotImplementedException();
        }

        void IB1.B()
        {
            throw new NotImplementedException();
        }

        void IB1.C()
        {
            throw new NotImplementedException();
        }
    }
}
