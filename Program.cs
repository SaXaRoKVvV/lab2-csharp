using System;

namespace lab2
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine
                    ("=== Лабораторная работа №2. Вариант 10 ===");
                Console.WriteLine
                    ("1 - Задание 1.3  (Имя)");
                Console.WriteLine
                    ("2 - Задание 2.2  (Человек с именем)");
                Console.WriteLine
                    ("3 - Задание 2.3  (Человек с родителем)");
                Console.WriteLine
                    ("4 - Задание 3.2  (Ломаная)");
                Console.WriteLine
                    ("5 - Задание 4.9  (Создаём Ломаную)");
                Console.WriteLine
                    ("6 - Задание 5.7  (Длина Ломаной)");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunTask1_3();
                        break;
                    case "2":
                        RunTask2_2();
                        break;
                    case "3":
                        RunTask2_3();
                        break;
                    case "4":
                        RunTask3_2();
                        break;
                    case "5":
                        RunTask4_9();
                        break;
                    case "6":
                        RunTask5_7();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine
                            ("Неверный пункт меню.");
                        break;
                }
            }
        }

        // ----- Задание 1.3. Имя -----
        private static void RunTask1_3()
        {
            Console.WriteLine();
            Console.WriteLine("--- Задание 1.3. Имя ---");

            Name n1 = new Name("Клеопатра");
            Name n2 = 
                new Name("Пушкин", "Александр", "Сергеевич");
            Name n3 = new Name("Маяковский", "Владимир");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
        
        // ----- Задание 2.2. Человек с именем -----
        private static void RunTask2_2()
        {
            Console.WriteLine();
            Console.WriteLine
                ("--- Задание 2.2. Человек с именем ---");

            Name name1 = new Name("Клеопатра");
            Name name2 = new Name
                ("Пушкин", "Александр", "Сергеевич");
            Name name3 = new Name("Маяковский", "Владимир");

            Person p1 = new Person(name1, 152);
            Person p2 = new Person(name2, 167);
            Person p3 = new Person(name3, 189);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }

// ----- Задание 2.3. Человек с родителем -----
        private static void RunTask2_3()
        {
            Console.WriteLine();
            Console.WriteLine
                ("--- Задание 2.3. Человек с родителем ---");
            
            Name ivanName = new Name
                ("Чудов", "Иван");
            Person ivan = new Person(ivanName, 180);
            
            Name petrName = new Name
                ("Чудов", "Пётр");
            Person petr = new Person(petrName, 175, ivan);
            
            Name borisName = new Name("Борис");
            Person boris = new Person
                (borisName, 170, petr);

            Console.WriteLine(ivan);
            Console.WriteLine(petr);
            Console.WriteLine(boris);
        }
        
        private static void RunTask3_2()
        {
            Console.WriteLine();
            Console.WriteLine("--- Задание 3.2. Ломаная ---");
            
            Point p1 = new Point(1, 5);
            Point p2 = new Point(2, 8);
            Point p3 = new Point(5, 3);

            Polyline line1 = new
                Polyline(new Point[] { p1, p2, p3 });
            
            Point m1 = new Point(2, -5);
            Point m2 = new Point(4, -8);

            Polyline line2 = new 
                Polyline(new Point[] { p1, m1, m2, p3 });
            
            Console.WriteLine("Первая ломаная:  " + line1);
            Console.WriteLine("Вторая ломаная:  " + line2);
            
            p1.X = 10;
            p1.Y = 10;

            Console.WriteLine();
            Console.WriteLine("После сдвига начала первой ломаной:");
            Console.WriteLine("Первая ломаная:  " + line1);
            Console.WriteLine("Вторая ломаная:  " + line2);
        }
        
        // ----- Задание 4.9. Создаём Ломаную -----
        private static void RunTask4_9()
        {
            Console.WriteLine();
            Console.WriteLine
                ("--- Задание 4.9. Создаём Ломаную ---");
            
            PolylineExtended empty = new PolylineExtended();
            Console.WriteLine("Пустая ломаная:   " + empty);
            Console.WriteLine("Длина:       " + empty.Length());
            
            int n = Input.ReadNonNegativeInt
                ("Введите количество точек: ");
            if (n < 2)
            {
                Console.WriteLine
                    ("Ошибка: нужно минимум 2 точки.");
                return;
            }

            Point[] points = ReadPoints(n);
            PolylineExtended line = new PolylineExtended(points);

            Console.WriteLine();
            Console.WriteLine("Исходная ломаная:      " + line);
            Console.WriteLine("Длина:         " + line.Length());
            
            Console.WriteLine();
            Console.WriteLine("Добавляем одну точку:");
            double x = Input.ReadDouble("  X = ");
            double y = Input.ReadDouble("  Y = ");
            Point extra = new Point(x, y);

            PolylineExtended line2 = line.AddPoint(extra);
            Console.WriteLine("Ломаная:     " + line2);
            Console.WriteLine("Длина:        " + line2.Length());

            
            int m = Input.ReadNonNegativeInt
                ("Сколько точек добавить массивом? ");
            if (m > 0)
            {
                Point[] extraArr = ReadPoints(m);
                PolylineExtended line3 = line2.AddPoints(extraArr);
                Console.WriteLine("Ломаная:   " + line3);
                Console.WriteLine("Длина:    " + line3.Length());

                Console.WriteLine();
                Console.WriteLine("Исходная (не изменилась): " + line);
            }
        }
        
        // ----- Задание 5.7. Длина Ломаной -----
        private static void RunTask5_7()
        {
            Console.WriteLine();
            Console.WriteLine
                ("--- Задание 5.7. Длина Ломаной ---");

            
            int n = Input.ReadNonNegativeInt
                ("Введите количество точек: ");
            if (n < 2)
            {
                Console.WriteLine
                    ("Ошибка: нужно минимум 2 точки.");
                return;
            }

            Point[] points = ReadPoints(n);
            PolylineExtended line = new PolylineExtended(points);

            Console.WriteLine();
            Console.WriteLine("Ломаная:     " + line);
            Console.WriteLine("Длина:       " + line.Length());

            
            bool addMore = true;
            while (addMore)
            {
                Console.Write
                    ("Добавить ещё точку? (1 - да, 0 - нет): ");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    double x = Input.ReadDouble("  X = ");
                    double y = Input.ReadDouble("  Y = ");
                    Point p = new Point(x, y);

                    line = line.AddPoint(p);
                    Console.WriteLine
                        ("Ломаная:               " + line);
                    Console.WriteLine("Длина: " + line.Length());
                }
                else
                {
                    addMore = false;
                }
            }
        }
        
        // Чтение массива точек с клавиатуры.
        private static Point[] ReadPoints(int count)
        {
            Point[] points = new Point[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Точка " + (i + 1) + ":");
                double x = Input.ReadDouble("  X = ");
                double y = Input.ReadDouble("  Y = ");
                points[i] = new Point(x, y);
            }
            return points;
        }
    }
}