using System;
using System.Security.Cryptography.X509Certificates;
namespace Example_2
{
    class marks
    {   public int m1;
        public int m2;
        public int m3;
        public int m4;
        public int m5;

        public void GetMarks()
        {
            Console.WriteLine("Enter marks of Subject 1");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject 2");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject 3");
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject 4");
            m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Subject 5");
            m5 = Convert.ToInt32(Console.ReadLine());
        }
            public void Calculate()
        {
            int total = m1 + m2 + m3 + m4 + m5;
            double average = total / 5.0;
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
        }
        class program
        {
            public static void Main(string[] args)
            {
                marks studentMarks = new marks();
                studentMarks.GetMarks();
                studentMarks.Calculate();
            }
        }

    }
}
