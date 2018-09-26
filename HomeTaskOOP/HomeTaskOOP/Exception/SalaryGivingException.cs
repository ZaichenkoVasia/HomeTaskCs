using System;

namespace HomeTaskOOP
{
    public class SalaryGivingException : Exception
    {
        public SalaryGivingException()
        {
            Console.WriteLine("There is not employee in department");
        }
    }
}