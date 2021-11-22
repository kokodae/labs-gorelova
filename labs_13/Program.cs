using System;

namespace labs_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.Write("Введите цену конфет за килограмм (все ответы будут округлены до сотых): ");
            double _cost = double.Parse(Console.ReadLine());
            _cost = _cost / 10;
            double _cost1;

            for (double i = 1; i < 11; i++)
            {
                _cost1 = Math.Round(_cost * i, 2);
                Console.WriteLine($"Цена за {Math.Round(0.1 * i, 2)} кг равна {_cost1}");
            }


            //задание 2
            Console.Write("Введите число N (больше нуля): ");
            double _n1 = double.Parse(Console.ReadLine());
            double _pr1 = 1.1;

            if (_n1 > 0)
            {
                _n1 = _n1 / 10;
                for (double i = 0.2; i < _n1 + 0.1; i = i + 0.1)
                {
                    _pr1 = _pr1 * (1 + i);
                }
                Console.WriteLine($"Произведение равно {_pr1}");
            }
            else { Console.WriteLine("Введены неверные значения"); }


            //задание 3
            Console.Write("Введите число N (больше нуля): ");
            double _n2 = double.Parse(Console.ReadLine());
            int _sq = 1;
            int _k1 = 1;

            if (_n1 > 0)
            {
                for (int i = 3; i < 2 * _n2; i = i + 2)
                {
                    _sq = _sq + i;
                    Console.WriteLine($"Промежуточное произведение {_sq}");
                }
                Console.WriteLine($"Квадрат числа равен {_sq}");
            }
            else { Console.WriteLine("Введены неверные значения"); }


            //задание 4 & 5
            Console.WriteLine("Введите числa A и N (N больше нуля):");
            double _a = double.Parse(Console.ReadLine());
            int _n = int.Parse(Console.ReadLine());
            double _v1 = 1;
            double _v2 = 1;

            if (_n > 0)
            {
                for (int i = 1; i < _n + 1; i++)
                {
                    _v1 = _v1 + Math.Pow(_a, i);
                    _v2 = _v2 + Math.Pow(_a, i) * Math.Pow(-1, i);
                }
                Console.WriteLine($"Значение выражения из задания 4 равно {_v1}, а из задания 5 - {_v2}");
            }
            else { Console.WriteLine("Введены неверные значения"); }
        }
    }
}
