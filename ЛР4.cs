using System;

namespace лр4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Прямоугольник:
            Console.WriteLine("Вычисление площади и периметра прямоугольника:");
            Console.WriteLine("Введите длину:");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            Console.WriteLine("Введите ширину:");
            s = Console.ReadLine();
            int b = Convert.ToInt32(s);
            int S, P;
            S = a * b;
            P = 2 * (a + b);
            Console.WriteLine($"Площадь={S}, Периметр={P}");

            //Окружность:
            Console.WriteLine("Вычисление длины окружности:");
            Console.WriteLine("Введите диаметр окружности:");
            string l=Console.ReadLine();
            int d = Convert.ToInt32(l);
            float pi=3.14f;
            float L;
            L = pi * d;
            Console.WriteLine($"Длина окружности={L}");

            //Ср.арифм:
            Console.WriteLine("Вычисление среднего арифметического двух чисел:");
            Console.WriteLine("Введите первое число:");
            string c = Console.ReadLine();
            int a1= Convert.ToInt32(c);
            Console.WriteLine("Введите второе число:");
            c = Console.ReadLine();
            int b2 = Convert.ToInt32(c);
            Console.WriteLine($"Среднее арифметическое a и b равно {(a1+b2)/2}");

            //квадраты чисел
            Console.WriteLine("Работа с квадратами чисел:");
            Console.WriteLine("Введите первое число:");
            string n = Console.ReadLine();
            int n1 = Convert.ToInt32(n);
            Console.WriteLine("Введите второе число:");
            n = Console.ReadLine();
            int n2 = Convert.ToInt32(n);
            int n3, n4,h;
            n3 = n1 * n1;
            n4 = n2 * n2;
            if (n4 > n3)
            {
                h = n3;
                n3 = n4;
                n4 = h;
            }
            Console.WriteLine($"Сумма их кв-в = {n3+n4} Разность = {n3-n4} Произведение = {n3*n4} Частное = {n3/n4}");

            //модули чисел
            Console.WriteLine("Работа с модулями чисел:");
            Console.WriteLine("Введите первое число:");
            string x = Console.ReadLine();
            int x1 = Convert.ToInt32(x);
            Console.WriteLine("Введите второе число:");
            x = Console.ReadLine();
            int x2 = Convert.ToInt32(x);
            int x3 = Math.Abs(x1);
            int x4 = Math.Abs(x2);
            int k;
            if (x4 > x3)
            {
                k = x3;
                x3 = x4;
                x4 = k;
            }
            Console.WriteLine($"Сумма их модулей = {x3 + x4} Разность = {x3 - x4} Произведение = {x3 * x4} Частное = {x3 / x4}");
        }
    }
}
