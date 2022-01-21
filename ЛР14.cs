using System;

namespace ЛР14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задания от 1 до 6:");
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Console.WriteLine("Введите первое целое число:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе целое число:"); 
                    int b = int.Parse(Console.ReadLine());
                    int i;
                    if (a > b)
                    {
                        int h = b;
                        b = a;
                        a = h;
                    }
                    for (i = a; i <= b; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите первое целое число:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе целое число:");
                    b = int.Parse(Console.ReadLine());
                    if (b > a)
                    {
                        int h = b;
                        b = a;
                        a = h;
                    }
                    while (a > b) 
                    {
                        a = a - b;
                    }
                    Console.WriteLine($"Длина незанятой части отрезка равна {a}");
                    break;
                case "3":
                    Console.WriteLine("Введите целое число:");
                    a = int.Parse(Console.ReadLine());
                    int k=0;
                    i = 0;
                    while (k < a)
                    {
                        i++;
                        k = k + i;
                    }
                    Console.WriteLine($"Последнее число = {i} Сумма = {k}");
                    break;
                case "4":
                    Console.WriteLine("Введите целое число от 0 до 25:");
                    float p = float.Parse(Console.ReadLine());
                    float s = 1000;
                    i = 0;
                    p = p / 100;
                    while (s < 1100) 
                    {
                        s = s + s*p;
                        i++;
                    }
                    Console.WriteLine($"Кол-во месяцев = {i}  Итоговый размер вклада = {s}");
                    break;
                case "5":
                    Console.WriteLine("Введите первое целое число:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе целое число:");
                    b = int.Parse(Console.ReadLine());
                    while (a != 0 & b != 0) 
                    {
                        if (a > b)
                        {
                            a = a % b;
                        }
                        else b = b % a;
                    }
                    Console.WriteLine($"НОД = {a + b}");
                    break;
                case "6":
                    Console.WriteLine("Введите целое число, являющееся числом Фибоначчи:");
                    a = int.Parse(Console.ReadLine());
                    int f1 = 1, f2 = 1, f = 0;
                    k = 2;
                    while (f < a)
                    {
                        ++k;
                        f = f2 + f1;
                        f2 = f1;
                        f1 = f;
                    }
                    Console.WriteLine($"Порядковый номер числа Фибоначчи = {k}");
                    break;
            }
        }
    }
}
