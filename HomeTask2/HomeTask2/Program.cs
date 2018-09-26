using System;
using System.Collections;

namespace HomeTask2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CircleInfo(5);
            DayInfo(15, 23);
            Color();
            DatePrint(2, "September", 2018);
            DivisibleByThree();
            Console.WriteLine(AvarageOfPositive());
            Console.WriteLine(OperationOfArray(new int[] {1, 2, -3, 4, 5, 2, 2, 2, 2, 2}));
        }

        public static void CircleInfo(double radius)
        {
            Console.WriteLine("Circumference = {0:0.###}", 2 * Math.PI * radius);
            Console.WriteLine("Circle area = {0:0.###}", Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("Sphere volume = {0:0.###}", 4.0 / 3 * Math.PI * Math.Pow(radius, 3));
        }

        public static void DayInfo(int hour, int minute)
        {
            if (hour < 0 && hour > 24 && minute < 0 && minute > 60)
            {
                throw new Exception("Incorrect Time");
            }

            if (hour >= 0 && hour < 8)
                Console.WriteLine("Good night!");
            if (hour >= 8 && hour < 12)
                Console.WriteLine("Good moorning!");
            if (hour >= 12 && hour < 18)
                Console.WriteLine("Good afternoon!");
            if (hour >= 18 && hour < 24)
                Console.WriteLine("Good evening!");
        }

        enum Colors
        {
            Green,
            Blue,
            Orange,
            Black,
            White
        }

        public static void Color()
        {
            Console.WriteLine("My favourite colours are: {0} and {1}.", Colors.Orange, Colors.Blue);
        }

        public struct Date
        {
            public int day;
            public string month;
            public int year;

            public void Print()
            {
                Console.WriteLine($"Today is: {day} {month} {year}");
            }
        }

        public static void DatePrint(int day, string month, int year)
        {
            Date today = new Date();
            today.day = day;
            today.month = month;
            today.year = year;
            today.Print();
        }

        public static void DivisibleByThree()
        {
            int a, b;
            Console.WriteLine("Input a (a must be less than b)");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b (a must be less than b)");
            b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
                throw new Exception("Incorrect value");
            Console.WriteLine("Numbers are divisible by 3 in a range: ");
            for (int i = a + 1; i < b; i++)
            {
                if (i % 3 == 0)
                    Console.Write("{0}, ", i);
            }
        }

        public static double AvarageOfPositive()
        {
            ArrayList positive = new ArrayList();
            while (true)
            {
                Console.WriteLine("Input number (for exit write negative number):");
                int number = Convert.ToInt16(Console.ReadLine());
                if (number <= 0)
                    break;
                positive.Add(number);
            }

            int sumaPositive = 0;
            foreach (int element in positive)
            {
                sumaPositive += element;
            }

            return (double) sumaPositive / positive.Count;
        }

        public static int OperationOfArray(int[] array)
        {
            bool positive = true;
            for (int i = 0; i < 5; i++)
            {
                if (array[i] <= 0)
                {
                    positive = false;
                    break;
                }
            }
            int result = 1;
            if (positive)
            {
                result = 0;
                for (int i = 0; i < 5; i++)
                {
                    result += array[i];
                }
                return result;
            }
            for (int i = 5; i < 10; i++)
            {
                result *= array[i];
            }
            return result;
        }
    }
}