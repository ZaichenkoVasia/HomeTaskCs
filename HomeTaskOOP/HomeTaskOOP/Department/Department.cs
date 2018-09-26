using System;
using System.Collections.Generic;

namespace HomeTaskOOP
{
    public class Department
    {
        List<Manager> managers = new List<Manager>();

        public Department()
        {
        }

        public Department(List<Manager> managers)
        {
            this.managers = new List<Manager>(managers);
        }

        public void AddManager(Manager manager)
        {
            managers.Add(manager);
        }

        public void GiveSalary(Employee employee)
        {
            bool exception = true;
            foreach (Manager manager in managers)
            {
                if (manager.Equals(employee))
                {
                    if (manager.Team.Count > 5 && manager.Team.Count <= 10)
                        manager.Salary += 200;
                    if (manager.Team.Count > 10)
                        manager.Salary += 300;
                    int count = 0;
                    foreach (Employee element in manager.Team)
                    {
                        if (element is Developer)
                            count++;
                    }

                    if (count >= manager.Team.Count / 2.0)
                    {
                        manager.Salary = manager.Salary * 1.1;
                    }

                    Console.WriteLine($"{manager.FirstName} {manager.LastName}: got salary: {manager.Salary}");
                    exception = false;
                    break;
                }

                foreach (Employee element in manager.Team)
                {
                    if (element.Equals(employee))
                    {
                        Console.WriteLine($"{element.FirstName} {element.LastName}: got salary: {element.Salary}");
                        exception = false;
                        break;
                    }
                }
            }

            if (exception)
                throw new SalaryGivingException();
        }

        public void AddTeamMembers(Manager manager, Employee[] array)
        {
            if (manager is Manager)
            {
                manager.AddToTeam(array);
                managers.Add(manager);
            }
            else
                throw new WrongEmployeeRoleException(manager.LastName);
        }
    }
}