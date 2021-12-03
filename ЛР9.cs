using System;

namespace ЛР9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задания от 1 до 5:");
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Console.WriteLine("Введите целое количество суток:");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Количество секунд, прошедших с начала последней минуты, равно {n1%60}");
                    break;
                case "2":
                    Console.WriteLine("Введите целое число от 1 до 365:");
                    int d = int.Parse(Console.ReadLine());
                    while (d > 7)
                        d -= 7;
                    if (d == 0) Console.WriteLine("0|Воскресение");
                    if (d == 1) Console.WriteLine("1|Понедельник");
                    if (d == 2) Console.WriteLine("2|Вторник");
                    if (d == 3) Console.WriteLine("3|Среда");
                    if (d == 4) Console.WriteLine("4|Четверг");
                    if (d == 5) Console.WriteLine("5|Пятница");
                    if (d == 6) Console.WriteLine("6|Суббота");
                    break;
                case "3":
                    Console.WriteLine("Введите целое число от 1 до 365:");
                    int d2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число от 1 до 7:");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Номер дня недели {((d2 + n2 - 2) % 7) + 1}");
                    break;
                case "4":
                    Console.WriteLine("Введите целое положительное число A:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое положительное число B:");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое положительное число C:");
                    int c = int.Parse(Console.ReadLine());
                    int s = a * b;
                    int s1 = s / (c * c);
                    Console.WriteLine($"Количество квадратов равно {s1}, Свободная площадь равна {s-s1*c*c}");
                    break;
                case "5":
                    Console.WriteLine("Введите год:");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Столетие:{(y-1)/100 + 1}");
                    break;
            }
        }
    }
}
