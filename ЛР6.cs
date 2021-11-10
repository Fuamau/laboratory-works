using System;

namespace ЛР6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задания от 1 до 7:");
            string s = Console.ReadLine();
            switch (s) 
            {
                case "1":
                    Console.WriteLine("Введите A:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B:");
                    int b = int.Parse(Console.ReadLine());
                    int h = a;
                    a = b;
                    b = h;
                    Console.WriteLine($"A={a} B={b}");
                    break;
                case "2":
                    Console.WriteLine("Введите A:");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B:");
                    int b1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите C:");
                    int c1 = int.Parse(Console.ReadLine());
                    int d, e;
                    d = b1;
                    e = c1;
                    b1 = a1;
                    c1 = d;
                    a1 = e;
                    Console.WriteLine($"A={a1} B={b1} C={c1}");
                    break;
                case "3":
                    Console.WriteLine("Введите A:");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B:");
                    int b2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите C:");
                    int c2 = int.Parse(Console.ReadLine());
                    int d1, e1;
                    d1 = c2;
                    e1 = b2;
                    c2 = a2;
                    b2 = d1;
                    a2 = e1;
                    Console.WriteLine($"A={a2} B={b2} C={c2}");
                    break;
                case "4":
                    Console.WriteLine("Введите x:");
                    int x = int.Parse(Console.ReadLine());
                    float y = Convert.ToSingle(3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7);
                    Console.WriteLine($"Значение функции={y}");
                    break;
                case "5":
                    int x1 = int.Parse(Console.ReadLine());
                    float y1 = Convert.ToSingle(4 * Math.Pow(x1-3, 6) - 7 * Math.Pow(x1-3, 3) + 2);
                    Console.WriteLine($"Значение функции={y1}");
                    break;
                case "6":
                    Console.WriteLine("Введите A:");
                    int A = int.Parse(Console.ReadLine());
                    int A8 = Convert.ToInt32(Math.Pow(A, 2) * Math.Pow(A, 2) * Math.Pow(A, 2));
                    Console.WriteLine("A в восьмой степени равна", A8);
                    break;
                case "7":
                    Console.WriteLine("Введите A:");
                    int A1 = int.Parse(Console.ReadLine());
                    int A3 = Convert.ToInt32(Math.Pow(A1, 3));
                    int A15 = A3 * A3 * A3 * A3 * A3;
                    Console.WriteLine("A в восьмой степени равна", A15);
                    break;
            }
        }
    }
}
