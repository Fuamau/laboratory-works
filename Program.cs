using System;

namespace ЛР7
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
                    Console.WriteLine("Введите угол:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine($"В радианах: {a * 3,14/180}");
                    break;
                case "2":
                    Console.WriteLine("Введите угол:");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"В градусах: {b * 180/3,14}");
                    break;
                case "3":
                    Console.WriteLine("Введите, сколько конфет(X кг):");
                    int X = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите стоимость(A руб):");
                    int A = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите, сколько конфет(Y кг):");
                    int Y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Стоимость 1 кг и Y кг конфет равна: {A*(Y+1)/X}");
                    break;
                case "4":
                    Console.WriteLine("Введите скорость первого автомобиля:");
                    int v1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите скорость второго автомобиля:");
                    int v2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите расстояние между ними:");
                    int s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите время:");
                    int t = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Расстояние через {t} часов равно: {s+v1*t+v2*t}");
                    break;
                case "5":
                    Console.WriteLine("Решаем уравнение вида A*x + B = 0");
                    Console.WriteLine("Введите A:");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B:");
                    int b1 = int.Parse(Console.ReadLine());
                    if (a1 != 0)
                        Console.WriteLine($"x = {-b1 / a1}");
                    else Console.WriteLine("Вы ввели A=0, попробуйте другое значение");
                    break;
                case "6":
                    Console.WriteLine("Введите A1:");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B1:");
                    int b2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите C2:");
                    int c2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите A2:");
                    int a3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B2:");
                    int b3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите C3:");
                    int c3 = int.Parse(Console.ReadLine());
                    float y = (c3 * a2 - a3 * c2) / (b3 * a2 - a3 * b2);
                    Console.WriteLine($"x = {(c2-b2*y)/a2}  y = {y}");
                    break;
            }
        }
    }
}
