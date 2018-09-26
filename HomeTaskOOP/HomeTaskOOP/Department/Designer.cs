namespace HomeTaskOOP
{
    public class Designer : Employee
    {
        private double effCoef { get; set; }

        public Designer(double salary, string firstName, string lastName, int experiance, Manager manager,
            double effCoef) : base(salary, firstName, lastName, experiance, manager)
        {
            this.effCoef = effCoef;
            Salary = salary * effCoef;
        }

        public Designer()
        {
        }
    }
}