using System;

namespace labs_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите количество секунд N:");
            int _nZ1 = int.Parse(Console.ReadLine());

            int _z1 = _nZ1 % 60;
            Console.WriteLine($"Количество секунд, прошедших с начала последней минуты, равно {_z1}");


            //задание 2
            int _z2;
            Console.WriteLine("Введите число дней К:");
            int _kZ2 = int.Parse(Console.ReadLine());

            _z2 = _kZ2 % 7;
            Console.WriteLine($"Номер дня недели {_z2}");


            //задание 3
            double _z3;
            Console.WriteLine("Введите число дней К и номер дня недели 1 января N:");
            int _kZ3 = int.Parse(Console.ReadLine());
            int _nZ3 = int.Parse(Console.ReadLine());

            if ((_kZ3 > 0) && (_kZ3 < 366) && (_nZ3 > 0) && (_nZ3 < 8))
            {
                _z3 = (_kZ3 + _nZ3 - ((_kZ3 + _nZ3) % 7)) / 7 + 1;
                //считаю за отдельную неделю даже если 1 января не понедельник
                Console.WriteLine($"Номер недели {_z3}");
            }
            else { Console.WriteLine("Введены неверные значения"); }


            //задание 4
            double _count, _sq;
            Console.WriteLine("Введите А, В и С:");
            int _a = int.Parse(Console.ReadLine());
            int _b = int.Parse(Console.ReadLine());
            int _c = int.Parse(Console.ReadLine());

            if ((_a > 0) && (_b > 0) && (_c > 0))
            {
                _count = ((_a - (_a % _c)) /_c) * ((_b - (_b % _c)) / _c);
                _sq = (_a * _b) - (_count * _c * _c);
                Console.WriteLine($"Поместится {_count} квадратов, незанятая площадь - {_sq}");
            }
            else { Console.WriteLine("Введены неверные значения"); }


            //задание 5
            double _z5;
            Console.WriteLine("Введите год:");
            int _year = int.Parse(Console.ReadLine());

            if (_year > 0)
            {
                _z5 = ((_year - (_year % 100)) / 100) + 1;
                Console.WriteLine($"Номер столетия {_z5}");
            }
            else { Console.WriteLine("Введены неверные значения"); }
        }
    }
}
