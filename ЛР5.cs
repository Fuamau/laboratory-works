using System;

namespace ЛР5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1.");
            Console.WriteLine("Введите x1:");
            int x1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите y1:");
            int y1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y2 = int.Parse(Console.ReadLine());
            int x = Convert.ToInt32(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            Console.WriteLine($"Расстояние между двумя точками равно {x}");

            Console.WriteLine("Задание 2.");
            Console.WriteLine("Точка А:");
            Console.WriteLine("Введите x1:");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            int y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Точка В:");
            Console.WriteLine("Введите x2:");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Точка С:");
            Console.WriteLine("Введите x3:");
            int x5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y3:");
            int y5 = int.Parse(Console.ReadLine());
            int y = Convert.ToInt32(Math.Sqrt(Math.Pow((x5 - x3), 2) + Math.Pow((y5 - y3), 2)));
            int z = Convert.ToInt32(Math.Sqrt(Math.Pow((x5 - x4), 2) + Math.Pow((y5 - y4), 2)));
            Console.WriteLine($"AC+BC = {y}+{z} = {y+z}");

            Console.WriteLine("Задание 3.");
            Console.WriteLine("Точка А:");
            Console.WriteLine("Введите x1:");
            int x6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            int y6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Точка В:");
            Console.WriteLine("Введите x2:");
            int x7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Точка С:");
            Console.WriteLine("Введите x3:");
            int x8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y3:");
            int y8 = int.Parse(Console.ReadLine());
            int q = Convert.ToInt32(Math.Sqrt(Math.Pow((x8 - x6), 2) + Math.Pow((y8 - y6), 2)));
            int w = Convert.ToInt32(Math.Sqrt(Math.Pow((x8 - x7), 2) + Math.Pow((y8 - y7), 2)));
            Console.WriteLine($"AC*BC = {q}*{w} = {q * w}");

            Console.WriteLine("Задание 4.");
            Console.WriteLine("Введите x1:");
            int x9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            int y9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            int x10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y10 = int.Parse(Console.ReadLine());
            int e = Convert.ToInt32(Math.Abs(x10 - x9));
            int r = Convert.ToInt32(Math.Abs(y10 - y9));
            Console.WriteLine($"Периметр = {2*(e + r)} Площадь = {e * r}");

            Console.WriteLine("Задание 5.");
            Console.WriteLine("Первая точка:");
            Console.WriteLine("Введите x1:");
            int x11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            int y11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Вторая точка:");
            Console.WriteLine("Введите x2:");
            int x12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Третья точка:");
            Console.WriteLine("Введите x3:");
            int x13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y3:");
            int y13 = int.Parse(Console.ReadLine());
            int a = Convert.ToInt32(Math.Sqrt(Math.Pow((x12 - x11), 2) + Math.Pow((y12 - y11), 2)));
            int b = Convert.ToInt32(Math.Sqrt(Math.Pow((x13 - x12), 2) + Math.Pow((y13 - y12), 2)));
            int c = Convert.ToInt32(Math.Sqrt(Math.Pow((x13 - x11), 2) + Math.Pow((y13 - y11), 2)));
            int P = a + b + c;
            int p2 = P / 2;
            int S = Convert.ToInt32(Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c)));
            Console.WriteLine($"Периметр = {P} Площадь = {S}");
        }
    }
}
