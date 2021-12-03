using System;

namespace ЛР10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задания от 1 до 7:");
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Console.WriteLine("Введите целое число A:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число B:");
                    int b = int.Parse(Console.ReadLine());
                    if (a > 2 && b <= 3) Console.WriteLine("Высказывание истинно");
                    else Console.WriteLine("Высказывание ложно");
                    break;
                case "2":
                    Console.WriteLine("Введите целое число A:");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число B:");
                    int b1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число C:");
                    int c1 = int.Parse(Console.ReadLine());
                    if (a1 < b1 && b1 < c1) Console.WriteLine("Высказывание истинно");
                    else Console.WriteLine("Высказывание ложно");
                    break;
                case "3":
                    Console.WriteLine("Введите целое положительное число:");
                    int r = int.Parse(Console.ReadLine());
                    if (r > 9 && r < 100 && r % 2 == 0) Console.WriteLine("Данное число является четным двузначным");
                    else Console.WriteLine("Данное число НЕ является четным двузначным");
                    break;
                case "4":
                    Console.WriteLine("Введите трёхзначное число:");
                    int h = int.Parse(Console.ReadLine());
                    int h1 = h / 100;
                    int h2 = h / 10;
                    int h3 = h % 10;
                    if (h1 > h2 && h2 > h3 || h1 < h2 && h2 < h3) Console.WriteLine("Цифры данного числа образуют возрастающую или убывающую последовательность");
                    else Console.WriteLine("Цифры данного числа НЕ образуют возрастающую или убывающую последовательность");
                    break;
                case "5":
                    Console.WriteLine("Введите четырёхзначное число:");
                    int q = int.Parse(Console.ReadLine());
                    int q1 = q / 1000;
                    int q2 = q / 100;
                    int q3 = q / 10;
                    int q4 = q % 10;
                    if (q2 == q3 && q1 == q4) Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
                    else Console.WriteLine("Данное число НЕ читается одинаково слева направо и справа налево");
                    break;
                case "6":
                    Console.WriteLine("Введите целое число a:");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число b:");
                    int b2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число c:");
                    int c2 = int.Parse(Console.ReadLine());
                    if (c2 > a2 && c2 > b2 && c2 * c2 == a2 * a2 + b2 * b2) Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
                    else if (b2 > a2 && b2 > c2 && b2 * b2 == a2 * a2 + c2 * c2) Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
                    else if (a2 > b2 && a2 > c2 && a2 * a2 == b2 * b2 + c2 * c2) Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
                    else Console.WriteLine("Треугольник со сторонами a, b, c НЕ является прямоугольным");
                    break;
                case "7":
                    Console.WriteLine("Введите целое число a:");
                    int a3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число b:");
                    int b3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число c:");
                    int c3 = int.Parse(Console.ReadLine());
                    if (a3 < b3 + c3 && b3 < a3 + c3 && c3 < a3 + b3) Console.WriteLine("Существует треугольник со сторонами a, b, c");
                    else Console.WriteLine("Треугольник со сторонами a, b, c НЕ существует");
                    break;
            }
        }
    }
}
