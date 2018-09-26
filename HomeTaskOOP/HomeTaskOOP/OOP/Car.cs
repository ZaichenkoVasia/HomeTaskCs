using System;

namespace HomeTaskOOP
{
    public class Car
    {
        private string brand;
        private string color;
        private double price;

        public Car()
        {
            brand = "Noname";
            color = "Black";
            price = 1;
        }

        public Car(string brand, string color, double price)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public void Input()
        {
            Console.WriteLine("Input brand of car:");
            brand = Console.ReadLine();
            Console.WriteLine("Input color of car:");
            color = Console.ReadLine();
            Console.WriteLine("Input price of car:");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Car: brand - {brand}, color - {color}, price - {price}.");
        }

        public void ChangePrise(double x)
        {
            price *= x / 100;
        }
    }
}