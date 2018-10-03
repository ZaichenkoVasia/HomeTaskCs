using System;

namespace HomeTaskPrecision
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string number = "1,235666";
            int precision;
            Console.WriteLine("Enter precision of number 1.235666");
            try
            {
                precision = Convert.ToInt32(Console.ReadLine());
                if (precision < 0 || precision > 6)
                    throw new Exception("Enter incorrect value! Precision must be [0;6]");
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter incorrect value!");
                throw;
            }

            GetNumWithPrec(number, precision);
        }

        public static void GetNumWithPrec(string stringNumber, int precision)
        {
            double number = Double.Parse(stringNumber);
            double result = Math.Round(number, precision);
            Console.WriteLine("Number with precision:" + result);
        }
    }
}