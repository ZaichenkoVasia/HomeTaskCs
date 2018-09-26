using System;

namespace HomeTaskOOP
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public Dog()
        {
            Name = "Muchtar";
        }

        public Dog(string name)
        {
            Name = name;
        }

        public void Voice()
        {
            Console.WriteLine("Dog say: 'Gav'");
        }

        public void Feed()
        {
            Console.WriteLine("Dog eat bones");
        }
    }
}