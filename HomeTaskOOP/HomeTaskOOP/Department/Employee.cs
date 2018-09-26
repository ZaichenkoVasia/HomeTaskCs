using System;

namespace HomeTaskOOP
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;
        private int experiance;
        private Manager manager;

        protected Employee(double salary, string firstName, string lastName, int experiance, Manager manager)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.experiance = experiance;
            this.salary = salary;
            this.manager = manager;
        }

        public double Salary
        {
            get => salary;
            set
            {
                if (experiance > 5)
                    salary = value * 1.2 + 500;
                if (experiance <= 5 && experiance > 2)
                    salary = value + 200;
                if (experiance <= 2)
                    salary = value;
            }
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Experiance
        {
            get => experiance;
            set => experiance = value;
        }

        protected Employee()
        {
        }

        public void Print()
        {
            Console.WriteLine($"{firstName} {lastName}, manager:{manager.lastName}, experiance:{experiance}");
        }

        public bool Equals(Employee employee)
        {
            return firstName == employee.FirstName && lastName == employee.LastName &&
                   experiance == employee.Experiance;
        }
    }
}