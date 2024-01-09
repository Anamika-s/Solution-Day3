namespace AbtsractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape square = new Square();
            //square.GetDimensions();
            //square.CalculateArea();
            //square.DisplayArea();

            //Rectange rectange= new Rectange();

            //Console.WriteLine("ENter choice");
            //int ch = int.Parse(Console.ReadLine());
            //if(ch==1)
            //{
            //    Square square = new Square();
            //    square.GetDimensions();
            //    square.CalculateArea();
            //    square.DisplayArea();
            //}

            Console.WriteLine("ENter choice");
            Shape shape = null; ;
            int ch = int.Parse(Console.ReadLine());
            if(ch==1) { 
                  shape = new Square();
            }
            else if(ch==2)
            {
                shape = new Rectange();
            }
            CalculateArea(shape);





        }
        static void CalculateArea(Shape shape)
        {
            if(shape is Square)
            {

            }
            else if(shape is Rectange)
            {

            }

        }
    }
}