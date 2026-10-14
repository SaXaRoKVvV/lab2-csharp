using System;

namespace lab2
{
    // Класс для проверки ввода с клавиатуры.
    public static class Input
    {
        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string s = Console.ReadLine();
                int result;
                if (int.TryParse(s, out result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка: нужно целое число.");
            }
        }
        
        public static int ReadNonNegativeInt(string message)
        {
            while (true)
            {
                int result = ReadInt(message);
                if (result >= 0)
                {
                    return result;
                }
                Console.WriteLine
                    ("Ошибка: число не может быть отрицательным.");
            }
        }
        
        public static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                string s = Console.ReadLine();
                double result;
                if (double.TryParse(s, out result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка: нужно число.");
            }
        }
    }
}