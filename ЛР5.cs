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
            float x = Convert.ToSingle(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            Console.WriteLine($"Расстояние между двумя точками равно {x}");

            Console.WriteLine("Задание 2.");
            Console.WriteLine("Введите A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int c = int.Parse(Console.ReadLine());
            int ac = Math.Abs(c-a);
            int bc = Math.Abs(c-b);
            Console.WriteLine($"AC+BC = {ac}+{bc} = {ac+bc}");

            Console.WriteLine("Задание 3.");
            Console.WriteLine("Введите A:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int c1 = int.Parse(Console.ReadLine());
            if (c1 > a1 && c1 < b1)
            {
                int ac1 = Math.Abs(c1-a1);
                int bc1 = Math.Abs(c1-b1);
                Console.WriteLine($"AC*BC = {ac1}*{bc1} = {ac1 * bc1}");
            }
            else Console.WriteLine("Точка C не расположена между точками A и B.");

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
            float a2 = Convert.ToSingle(Math.Sqrt(Math.Pow((x12 - x11), 2) + Math.Pow((y12 - y11), 2)));
            float b2 = Convert.ToSingle(Math.Sqrt(Math.Pow((x13 - x12), 2) + Math.Pow((y13 - y12), 2)));
            float c2 = Convert.ToSingle(Math.Sqrt(Math.Pow((x13 - x11), 2) + Math.Pow((y13 - y11), 2)));
            float P = a2 + b2 + c2;
            float p2 = P / 2;
            float S = Convert.ToSingle(Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2)));
            Console.WriteLine($"Периметр = {P} Площадь = {S}");
        }
    }
}
