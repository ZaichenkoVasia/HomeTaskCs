using System;

namespace HomeTaskOOP
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }

        public Cat()
        {
            Name = "Jorick";
        }

        public Cat(string name)
        {
            Name = name;
        }

        public void Voice()
        {
            Console.WriteLine("Cat say: 'Meow'");
        }

        public void Feed()
        {
            Console.WriteLine("Cat eat fish");
        }
    }
}