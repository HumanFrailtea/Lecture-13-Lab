using System;

namespace Lecture_13_Labs
{
    class rectangle
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            mydelegate rectdale = new mydelegate(rect.area);
            rectdale += rectdale + new mydelegate(rect.perimeter);
            rectdale.Invoke(6.0, 4.5);
            Console.WriteLine();
            rectdale.Invoke(15.3, 11.4);
        }

        //declaring delgate
        public delegate void mydelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: " + (width * height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: " + (2*(width * height)));
        }
    }
}
