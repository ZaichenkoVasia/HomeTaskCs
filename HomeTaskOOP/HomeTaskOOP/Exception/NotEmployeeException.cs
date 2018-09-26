using System;

namespace HomeTaskOOP
{
    public class NotEmployeeException : Exception
    {
        public NotEmployeeException()
        {
            Console.WriteLine("There are not Employees in array");
        }
    }
}