using System.Collections.Generic;

namespace HomeTaskOOP
{
    public class Manager : Employee
    {
        public List<Employee> Team;

        public Manager(double salary, string firstName, string lastName, int experiance, Manager manager,
            List<Employee> team) : base(salary, firstName, lastName, experiance, manager)
        {
            Team = new List<Employee>(team);
        }

        public Manager()
        {
        }

        public void AddToTeam(Employee employee)
        {
            if (employee is Manager)
                throw new WrongEmployeeRoleException(employee.LastName);
            Team.Add(employee);
        }

        public void AddToTeam(Employee[] employees)
        {
            if (employees.Length != 0)
            {
                foreach (Employee element in employees)
                {
                    this.AddToTeam(element);
                }
            }
            else
                throw new NotEmployeeException();
        }
    }
}