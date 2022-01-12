using System;

namespace ЛР13
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
                    Console.WriteLine("Введите цену 1 кг конфет:");
                    int price = int.Parse(Console.ReadLine());
                    double i = 0.1;
                    while (i < 1)
                    {
                        Console.WriteLine(price*i);
                        i += 0.1;
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите целое число:");
                    int N = int.Parse(Console.ReadLine());
                    int j=0;
                    double k = 1;
                    double z = 1.1;
                    while (j < N)
                    {
                        k = k * z;
                        z = z + 0.1;
                        j++;
                    }
                    Console.WriteLine($"Произведение 1.1*1.2*1.3...(N сомножителей) равно {k}");
                    break;
                case "3":
                    Console.WriteLine("Введите целое число:");
                    N = int.Parse(Console.ReadLine());
                    k = 0;
                    i = 0;
                    while (i < N)
                    {
                        i++;
                        k = k + (2 * i - 1);
                        Console.Write($"Текущее значение суммы равно {k} ");
                    }
                    break;
                case "4":
                    Console.WriteLine("Введите вещественное число:");
                    int A = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число:");
                    N = int.Parse(Console.ReadLine());
                    k = 0;
                    for (i=0; i<=N; i++)
                    {
                        k+=Math.Pow((A), i);
                    }
                    Console.WriteLine($"Сумма равна {k}");
                    break;
                case "5":
                    Console.WriteLine("Введите вещественное число:");
                    A = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целое число:");
                    N = int.Parse(Console.ReadLine());
                    k = 1;
                    i = 0;
                    j = 1;
                    while (i < N)
                    {
                        j *= -A;
                        i++;
                        k += j;
                    }
                    Console.WriteLine($"Значение выражения равно {k}");
                    break;
            }
        }
    }
}
