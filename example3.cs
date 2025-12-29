using System;
namespace example_3
{
    class areacalculator
    {
        public int length;
        public int width;

        public void input()
        {
            Console.WriteLine("Enter Lenth:");
            length= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            width= Convert.ToInt32(Console.ReadLine());
        }
        public void area()
        {
            int area = length * width;
            Console.WriteLine("Area of Rectangle is: " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            areacalculator obj = new areacalculator();
            obj.input();
            obj.area();
            Console.ReadLine();
        }
    }
    class example3
    {
        public static void main(string[]args)
        {
            areacalculator rectanglearea= new areacalculator();
            rectanglearea.input();
            rectanglearea.area();
        }
    }
}
