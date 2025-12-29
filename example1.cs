using System;
namespace Classes_and_object
{
    class Calculator
    {
            public int num1;
            public int num2;
        public void input()
        {
            Console.Write("Enter first number: ");
            num1= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2= Convert.ToInt32(Console.ReadLine());
        }
        public void add()
        {
            Console.WriteLine("Addition:" + (num1 + num2));
        }
        public void subtract()
        {
            Console.WriteLine("Subtraction:" + (num1 - num2));
        }
    }
    class example1
    {
        public static void Main(string[] args)
        {
            Calculator basic = new Calculator();
            basic.input();
            basic.add();
            basic.subtract();
            Console.ReadLine();
        }
    }
}
