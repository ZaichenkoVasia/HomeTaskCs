namespace HomeTaskOOP
{
    public class Developer : Employee
    {
        public Developer(double salary, string firstName, string lastName, int experiance, Manager manager) : base(
            salary, firstName, lastName, experiance, manager)
        {
        }

        public Developer()
        {
        }
    }
}