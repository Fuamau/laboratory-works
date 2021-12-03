using System;

namespace ЛР8
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
                    Console.WriteLine("Введите размер файла в байтах:");
                    int f1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Размер файла равен {f1 / 1024} Кб");
                    break;
                case "2":
                    Console.WriteLine("Введите положительное число A:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите положительное число B:");
                    int b = int.Parse(Console.ReadLine());
                    int c = a / b;
                    Console.WriteLine($"Количество отрезков B, размещенных на отрезке A, равно {c}");
                    break;
                case "3":
                    Console.WriteLine("Введите положительное число A:");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите положительное число B:");
                    int b1 = int.Parse(Console.ReadLine());
                    int c1 = a1 / b1;
                    Console.WriteLine($"Длина незанятой части равна {a1 - c1*b1}");
                    break;
                case "4":
                    Console.WriteLine("Введите двузначное число:");
                    int n1 = int.Parse(Console.ReadLine());
                    int n11 = n1 / 10;
                    int n12 = n1%10;
                    Console.WriteLine($"{n12}{n11}");
                    break;
                case "5":
                    Console.WriteLine("Введите трёхзначное число:");
                    int n2 = int.Parse(Console.ReadLine());
                    int n21 = n2 / 100;
                    int n22 = n2 % 100;
                    Console.WriteLine($"{n22}{n21}");
                    break;
            }
        }
    }
}
