using System;

namespace labs_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите положительные числa A и В:");
            int _a1 = int.Parse(Console.ReadLine());
            int _b1 = int.Parse(Console.ReadLine());

            if ((_a1 > 0) && (_b1 > 0))
            {
                Console.WriteLine("");
                for (int i = _a1; i < _b1 + 1; i++)
                {
                    for (int k = 1; k < i + 1; k ++)
                    {
                        Console.WriteLine($"{i}");
                    }
                    Console.WriteLine("");
                }
            }
            else { Console.WriteLine("Введены неверные значения"); Console.WriteLine(""); }


            //задание 2
            Console.WriteLine("Введите положительные числa A и В:");
            double _a2 = double.Parse(Console.ReadLine());
            double _b2 = double.Parse(Console.ReadLine());

            if ((_a2 > _b2) && (_b2 > 0))
            {
                while (_a2 >= _b2)
                {
                    _a2 = _a2 - _b2;
                }
                Console.WriteLine($"Длина незанятой части отрезка равна {_a2}");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 3
            Console.Write("Введите число N (больше 1): ");
            int _n3 = int.Parse(Console.ReadLine());
            int _sum3 = 0;
            int _k3 = 1;

            if (_n3 > 1)
            {
                while (_sum3 <= _n3)
                {
                    _sum3 = _sum3 + _k3;
                    _k3++;
                }
                Console.WriteLine($"К равно {_k3 - 1}, а сумма - {_sum3}");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 4
            Console.Write("Введите процент: ");
            double _p = double.Parse(Console.ReadLine());
            double _sumP = 1000;
            int _month = 0;

            if ((25 > _p) && (_p > 0))
            {
                _p = _p / 100;
                while (_sumP <= 1100)
                {
                    _sumP = (_sumP) * (1 + _p);
                    _month++;
                }
                Console.WriteLine($"Количество месяцев - {_month}, сумма - {_sumP}");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 5
            Console.WriteLine("Введите положительные числa A и В:");
            int _a5 = int.Parse(Console.ReadLine());
            int _b5 = int.Parse(Console.ReadLine());
            int _nod = 0, _ost = 1;

            if ((_a5 > 0) && (_b5 > 0))
            {
                if (_b5 > _a5)
                {
                    _a5 = _a5 + _b5;
                    _b5 = _a5 - _b5;
                    _a5 = _a5 - _b5;
                }

                while (_ost > 0)
                {
                    _ost = _a5 % _b5;
                    _a5 = _b5;
                    _b5 = _ost;
                    _nod = _a5;
                }
                Console.WriteLine($"Нод этих чисел равен {_nod}");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 6
            Console.Write("Введите одно из чисел Фибонначи: ");
            int _num = int.Parse(Console.ReadLine());
            int _fib1 = 1, _fib2 = 1, temp, _count = 2;

            if (_num > 1)
            {
                while (_num > _fib2)
                {
                    temp = _fib2;
                    _fib2 = _fib2 + _fib1;
                    _fib1 = temp;
                    _count++;
                }
                if (_num == _fib2)
                { Console.WriteLine($"Номер этого числа - {_count}"); }
                else { Console.WriteLine("Это не число Фибонначи"); }
            }
            else { Console.WriteLine("Введены неверные значения"); }
        }
    }
}
