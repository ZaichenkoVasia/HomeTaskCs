using System;

namespace HomeTaskOOP
{
    public class WrongEmployeeRoleException : Exception
    {
        public WrongEmployeeRoleException(string secondName)
        {
            Console.WriteLine($"Employee {secondName} has unexpected role!");
        }
    }
}