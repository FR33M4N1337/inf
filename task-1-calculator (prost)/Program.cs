using System;

namespace task_1_calculator__простой_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;
            Console.WriteLine("Калькулятор");
            while (true)
            {
                Console.WriteLine(' ');
                Console.WriteLine("");
                Console.WriteLine("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оператор: ");
                oper = Convert.ToChar(Console.ReadLine().Substring(0, 1));

                if (oper == '^')
                {
                    total = a * a;
                    Console.WriteLine("Возведение в квадрат равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Введите второе число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (oper == '+')
                    {
                        total = a + b;
                        Console.WriteLine("Cумма равна " + total + ".");
                    }

                    else if (oper == '-')
                    {
                        total = a - b;
                        Console.WriteLine("Разность равна " + total + ".");
                    }

                    else if (oper == '*')
                    {
                        total = a * b;
                        Console.WriteLine("Умножение равно " + total + ".");
                    }

                    else if (oper == '/')
                    {
                        total = a / b;
                        Console.WriteLine("Деление равно " + total + ".");
                        if (b == 0)
                        {
                            Console.WriteLine("Деление на 0 невозможно.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неизвестный оператор.");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
