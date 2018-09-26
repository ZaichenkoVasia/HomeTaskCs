using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TakeString("Vasia");
            Console.WriteLine("Suma of array = " + Sum(new int[] {1, 2, 3, 4}));
            Console.WriteLine("Multiply of array = " + Multiply(new int[] {1, 2, 3, 4}));
            Console.WriteLine("Example reverse string: " + Reverse("String"));
            Console.WriteLine("'String' is palindrome? " + Is_palindrome("String"));
            Console.WriteLine("'Radar' is palindrome? " + Is_palindrome("Radar"));
            Console.WriteLine("Example of histogram:");
            Histogram(new int[] {3, 6, 2});
            Console.WriteLine("Example of Caesar cipher:");
            Console.WriteLine(CaesarCipher(2, "Some? Look, too!"));
            Console.WriteLine("Example reverse Matrix:");
            int n = 3, m = 4; //matrix nxm                                       
            int[,] myArr =
            {
                {1, 2, 3, 5},
                {4, 5, 6, 5},
                {7, 8, 9, 5}
            };
            Diagonal_reverse(myArr, n, m);
            Random random = new Random();
            int leftLimit = random.Next(0, 10);
            int rightLimit = random.Next(30, 50);
            Game(leftLimit, rightLimit);
            Console.WriteLine("Example of balance [ and ]. Balance? " + IsBalanced("[[[][][]]]]["));
            Console.WriteLine("Example of dictionary:");
            Char_freq("wwwinternet");
            Console.WriteLine("Example of transfer decimial to binary:");
            Dec_to_bin(7);
        }

        public static void TakeString(string stringName)
        {
            Console.WriteLine("Hello, {0}", stringName);
        }

        public static int Sum(int[] args)
        {
            int result = 0;
            foreach (int element in args)
            {
                result += element;
            }

            return result;
        }

        public static int Multiply(int[] array)
        {
            int result = 1;
            foreach (int element in array)
            {
                result *= element;
            }

            return result;
        }

        public static string Reverse(string revString)
        {
            char[] revChars = revString.ToCharArray();
            char[] buffer = new char[revChars.Length];
            for (int i = 0; i < revChars.Length; i++)
            {
                buffer[i] = revChars[revChars.Length - i - 1];
            }

            return new string(buffer);
        }

        public static bool Is_palindrome(string palindrom)
        {
            return palindrom.ToLower() == Reverse(palindrom.ToLower());
        }

        public static void Histogram(int[] array)
        {
            foreach (int element in array)
            {
                for (int i = 0; i < element; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public static string CaesarCipher(int key, string stringToCipher)
        {
            string result = "";
            string alfphabetSmall = "abcdefghijklmnopqrstuvwxyz";
            string alfphabetBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string signs = " ,.-!?:;";
            for (int i = 0; i < stringToCipher.Length; i++)
            {
                foreach (char element in signs)
                {
                    if (stringToCipher[i] == element)
                        result = result + element;
                }

                for (int j = 0; j < alfphabetSmall.Length; j++)
                {
                    if (stringToCipher[i] == alfphabetSmall[j])
                    {
                        int numberInAlfphabet = j + key;
                        while (numberInAlfphabet >= alfphabetSmall.Length)
                            numberInAlfphabet -= alfphabetSmall.Length;
                        result = result + alfphabetSmall[numberInAlfphabet];
                    }

                    if (stringToCipher[i] == alfphabetBig[j])
                    {
                        int numberInAlfphabet = j + key;
                        while (numberInAlfphabet >= alfphabetBig.Length)
                            numberInAlfphabet -= alfphabetBig.Length;
                        result = result + alfphabetBig[numberInAlfphabet];
                    }
                }
            }

            return result;
        }

        public static int[,] Diagonal_reverse(int[,] matrix, int n, int m)
        {
            int[,] result = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    result[i, j] = matrix[j, i];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(result[i, j] + " ");
                Console.WriteLine();
            }

            return result;
        }

        public static void Game(int leftLimit, int rightLimit)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Input number:");
                int input = Convert.ToInt16(Console.ReadLine());
                if (input > leftLimit && input < rightLimit)
                {
                    Console.WriteLine("Congratulation! You win!");
                    exit = true;
                }
                else Console.WriteLine("Try again!");
            }
        }

        static bool IsBalanced(string stringText)
        {
            char open = '[', close = ']';
            byte iteratorBalance = 0;
            foreach (char element in stringText)
            {
                if (element == open)
                {
                    iteratorBalance++;
                }

                if (element == close)
                {
                    if (iteratorBalance == 0)
                    {
                        return false;
                    }

                    iteratorBalance--;
                }
            }

            return iteratorBalance == 0;
        }

        public static void Char_freq(string stringText)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>(26);

            foreach (char element in stringText)
            {
                if (Char.IsLetter(element))
                {
                    if (letters.ContainsKey(element))
                        letters[element]++;
                    else
                    {
                        letters.Add(element, 1);
                    }
                }
            }

            foreach (KeyValuePair<char, int> keyValue in letters)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }

        public static void Dec_to_bin(int number)
        {
            string result = "";
            int binaryNum = 0;
            while (number > 0)
            {
                binaryNum = number % 2;
                number = number / 2;
                result = binaryNum.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}