using System;

namespace ЛР11
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
                    Console.WriteLine("Введите число A:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число B:");
                    int b = int.Parse(Console.ReadLine());
                    if (a != b)
                    {
                        if (a > b)
                        {
                            b = a;
                            Console.WriteLine($"a={a} b={b}");
                        }
                        else
                        {
                            a = b; 
                            Console.WriteLine($"a={a} b={b}");
                        }
                    }
                    else
                    { 
                        a = 0; 
                        b = 0; 
                        Console.WriteLine($"a={a} b={b}"); 
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите первое число:");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int b1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    int c1 = int.Parse(Console.ReadLine());
                    if (a1 > c1 && b1 > c1) Console.WriteLine($"Сумма двух наибольших чисел равна {a1 + b1}");
                    if (a1 > b1 && c1 > b1) Console.WriteLine($"Сумма двух наибольших чисел равна {a1 + c1}");
                    if (c1 > a1 && b1 > a1) Console.WriteLine($"Сумма двух наибольших чисел равна {c1 + b1}");
                    break;
                case "3":
                    Console.WriteLine("Первая точка|A:");
                    Console.WriteLine("Введите x1:");
                    int x11 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите y1:");
                    int y11 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Вторая точка|B:");
                    Console.WriteLine("Введите x2:");
                    int x12 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите y2:");
                    int y12 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Третья точка|C:");
                    Console.WriteLine("Введите x3:");
                    int x13 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите y3:");
                    int y13 = int.Parse(Console.ReadLine());
                    float ab = Convert.ToSingle(Math.Sqrt(Math.Pow((x12 - x11), 2) + Math.Pow((y12 - y11), 2)));
                    float ac = Convert.ToSingle(Math.Sqrt(Math.Pow((x13 - x11), 2) + Math.Pow((y13 - y11), 2)));
                    if (ab < ac) Console.WriteLine($"Точка B ближе к точке A, расстояние равно {ab}");
                    if (ac < ab) Console.WriteLine($"Точка C ближе к точке A, расстояние равно {ac}");
                    if (ab==ac) Console.WriteLine($"Точки B и C равноудалены от точки A, расстояние равно {ac}");
                    break;
                case "4":
                    Console.WriteLine("Введите координаты точки:");
                    Console.WriteLine("Введите x:");
                    int x21 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите y:");
                    int y21 = int.Parse(Console.ReadLine());
                    if (x21 == 0 || y21 == 0) Console.WriteLine("Определить четверть не получится, попробуйте снова.");
                    if (x21 > 0)
                    {
                        if (y21 > 0) Console.WriteLine("Первая четверть.");
                        else Console.WriteLine("Четвёртая четверть.");
                    }
                    else if (y21 > 0) Console.WriteLine("Вторая четверть.");
                    else Console.WriteLine("Третья четверть.");
                    break;
                case "5":
                    Console.WriteLine("Введите целое число:");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 0) Console.WriteLine("Нулевое число.");
                    else if (c>0)
                    {
                        if (c % 2 == 0) Console.WriteLine("Положительное чётное число.");
                        else Console.WriteLine("Положительное нечётное число.");
                    }
                    else if (c % 2 == 0) Console.WriteLine("Отрицательное чётное число.");
                    else Console.WriteLine("Отрицательное нечётное число.");
                    break;
                case "6":
                    Console.WriteLine("Введите целое число от 1 до 999:");
                    int v = int.Parse(Console.ReadLine());
                    int k=0;
                    int l = v;
                    while (l>0)
                    {
                        l /= 10;
                        k ++;
                    }
                    if (k==1)
                    {
                        if (v % 2 == 0) Console.WriteLine("Чётное натуральное число.");
                        else Console.WriteLine("Нечётное однозначное число.");
                    }
                    if (k == 2)
                    {
                        if (v % 2 == 0) Console.WriteLine("Чётное двузначное число.");
                        else Console.WriteLine("Нечётное двузначное число.");
                    }
                    if (k == 3)
                    {
                        if (v % 2 == 0) Console.WriteLine("Чётное трёхзначное число.");
                        else Console.WriteLine("Нечётное трёхзначное число.");
                    }
                    break;
            }
        }
    }
}
