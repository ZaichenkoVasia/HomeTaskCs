using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeTaskOOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OOP();
            ListTask();
            ArrayListTask();
            SortedListTask();
            HierarchyDepartment();
            Div();
            Phone();
        }

        public static void Phone()
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>(9);
            string PersonName, PhoneNumber;
            using (StreamReader reader =
                new StreamReader(@"D:\Мови програмування\4 s\C#\HomeTask\HomeTaskOOP\HomeTaskOOP\FilesTxt\phones.txt"))
            {
                for (int i = 0; i < 9; i++)
                {
                    PersonName = reader.ReadLine();
                    PhoneNumber = reader.ReadLine();
                    PhoneBook.Add(PersonName, PhoneNumber);
                }
            }

            using (StreamWriter writer =
                new StreamWriter(
                    @"D:\Мови програмування\4 s\C#\HomeTask\HomeTaskOOP\HomeTaskOOP\FilesTxt\onlyPhone.txt"))
            {
                foreach (KeyValuePair<string, string> keyValue in PhoneBook)
                {
                    writer.WriteLine(keyValue.Value);
                }
            }

            using (StreamWriter writer =
                new StreamWriter(@"D:\Мови програмування\4 s\C#\HomeTask\HomeTaskOOP\HomeTaskOOP\FilesTxt\new.txt"))
            {
                foreach (KeyValuePair<string, string> keyValue in PhoneBook)
                {
                    writer.WriteLine("+3" + keyValue.Value);
                }
            }

            Console.WriteLine("Write name of person:");
            string name = Console.ReadLine();
            foreach (KeyValuePair<string, string> keyValue in PhoneBook)
            {
                if (name == keyValue.Key)
                    Console.WriteLine($"Phone of {name}: " + keyValue.Value);
            }
        }

        public static void Div()
        {
            decimal result = 0;
            decimal a = 0;
            decimal b = 0;
            try
            {
                using (StreamReader reader =
                    new StreamReader(@"D:\Мови програмування\4 s\C#\HomeTask\HomeTaskOOP\HomeTaskOOP\FilesTxt\data.txt")
                )
                {
                    a = Convert.ToDecimal(reader.ReadLine());
                    b = Convert.ToDecimal(reader.ReadLine());
                    result = a / b;
                }

                using (StreamWriter writer =
                    new StreamWriter(@"D:\Мови програмування\4 s\C#\HomeTask\HomeTaskOOP\HomeTaskOOP\FilesTxt\rez.txt"))
                {
                    writer.WriteLine(result);
                }

                string path = @"D:\Мови програмування\4 s\C#\HomeTask\HomeTaskOOP\HomeTaskOOP\FilesTxt\allText.txt";
                if (File.Exists(path))
                {
                    string text = $"{a} / {b} = {result}";
                    File.WriteAllText(path, text);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private static void HierarchyDepartment()
        {
            Developer developer1 = new Developer(3500, "Roman", "Mark", 3, null);
            Developer developer2 = new Developer(2700, "Vova", "Tsar", 2, null);
            Developer developer3 = new Developer(2900, "Yuriy", "Sen", 4, null);
            Designer designer1 = new Designer(3500, "Yuriy", "Sav", 3, null, 0.8);
            Designer designer2 = new Designer(2700, "Sasha", "Smir", 2, null, 0.9);
            Designer designer3 = new Designer(2900, "Mike", "Taison", 1, null, 0.5);
            List<Employee> team1 = new List<Employee>();
            List<Employee> team2 = new List<Employee>();
            List<Employee> team3 = new List<Employee>();
            team1.Add(developer1);
            team1.Add(designer1);
            team2.Add(developer2);
            team2.Add(designer2);
            team3.Add(developer3);
            team3.Add(designer3);
            List<Manager> managers = new List<Manager>();
            Manager manager1 = new Manager(5000, "Vasyl", "Pet", 4, null, team1);
            Manager manager2 = new Manager(6000, "Ivan", "Por", 4, null, team2);
            Manager manager3 = new Manager(7000, "Dima", "Mon", 4, null, team3);
            managers.Add(manager1);
            managers.Add(manager2);
            managers.Add(manager3);
            Department department = new Department(managers);
            department.GiveSalary(designer1);
            department.GiveSalary(manager2);
            //department.GiveSalary(new Manager(6000, "Error", "Error",4, null, team3));    //for salarygivingexception
        }

        private static void ListTask()
        {
            List<int> myColl1 = new List<int>();
            Console.WriteLine("Input array:");
            for (int i = 0; i < 10; i++)
                myColl1.Add(Convert.ToInt32(Console.ReadLine()));
            List<int> indexs = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                if (myColl1[i] == -10)
                {
                    indexs.Add(i);
                }
            }

            Console.Write("Indexs that have value -10 are : ");
            foreach (int element in indexs)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            List<int> updateMyColl1 = new List<int>();
            foreach (int element in myColl1)
            {
                if (element < 20)
                {
                    updateMyColl1.Add(element);
                }
            }

            Console.WriteLine();
            if (updateMyColl1.Count >= 8)
            {
                updateMyColl1[2] = 1;
                updateMyColl1[8] = -3;
                updateMyColl1[5] = -4;
            }
            else throw new IndexOutOfRangeException("List hasnt more 8 elements!");

            Console.WriteLine("Updated list: ");
            foreach (int element in updateMyColl1)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            updateMyColl1.Sort();
            Console.WriteLine("Sorted list: ");
            foreach (int element in updateMyColl1)
            {
                Console.Write(element + " ");
            }
        }

        private static void ArrayListTask()
        {
            ArrayList myColl1 = new ArrayList();
            Console.WriteLine("Input array:");
            for (int i = 0; i < 10; i++)
                myColl1.Add(Convert.ToInt32(Console.ReadLine()));
            ArrayList indexs = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToInt32(myColl1[i]) == -10)
                {
                    indexs.Add(i);
                }
            }

            Console.Write("Indexs that have value -10 are : ");
            foreach (int element in indexs)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            ArrayList updateMyColl1 = new ArrayList();
            foreach (int element in myColl1)
            {
                if (element < 20)
                {
                    updateMyColl1.Add(element);
                }
            }

            Console.WriteLine();
            if (updateMyColl1.Count >= 8)
            {
                updateMyColl1[2] = 1;
                updateMyColl1[8] = -3;
                updateMyColl1[5] = -4;
            }
            else throw new IndexOutOfRangeException("ArrayList hasnt more 8 elements!");

            Console.WriteLine("Updated ArrayList: ");
            foreach (int element in updateMyColl1)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            updateMyColl1.Sort();
            Console.WriteLine("Sorted ArrayList: ");
            foreach (int element in updateMyColl1)
            {
                Console.Write(element + " ");
            }
        }

        private static void SortedListTask()
        {
            SortedList<int, int> myColl1 = new SortedList<int, int>();
            Console.WriteLine("Input array:");
            int iterator = 0;
            while (iterator < 10)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                myColl1.Add(number, number);
                iterator++;
            }

            Console.Write("Indexs that have value -10 are : ");
            if (myColl1.ContainsKey(-10))
            {
                Console.WriteLine(myColl1[-10]);
            }

            Console.WriteLine();
            SortedList<int, int> updateMyColl1 = new SortedList<int, int>();
            foreach (KeyValuePair<int, int> kvp in myColl1)
            {
                if (kvp.Value < 20)
                {
                    updateMyColl1.Add(kvp.Key, kvp.Value);
                }
            }

            updateMyColl1[2] = 1;
            updateMyColl1[8] = -3;
            updateMyColl1[5] = -4;

            Console.WriteLine("Updated SortedList: ");
            foreach (KeyValuePair<int, int> kvp in updateMyColl1)
            {
                Console.Write(Convert.ToInt16(kvp.Value) + " ");
            }

            Console.WriteLine();
        }

        public static void OOP()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Ferarri", "Red", 25000));
            cars.Add(new Car("Bugatti", "Blue", 35000));
            cars.Add(new Car("Opel", "White", 7000));
            foreach (Car element in cars)
            {
                element.ChangePrise(90);
                element.Print();
            }

            foreach (Car element in cars)
            {
                if (element.Color == "White")
                {
                    element.Color = "Specific";
                    element.Print();
                }
            }

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog("Zhyk"));
            animals.Add(new Cat("Mars"));
            foreach (IAnimal element in animals)
            {
                element.Feed();
                element.Voice();
            }
        }
    }
}