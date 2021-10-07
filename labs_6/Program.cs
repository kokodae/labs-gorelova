using System;

namespace labs_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите значение А и В:");
            double _aZ1 = double.Parse(Console.ReadLine());
            double _bZ1 = double.Parse(Console.ReadLine());

            _aZ1 = _aZ1 + _bZ1;
            _bZ1 = -(_bZ1 - _aZ1);
            _aZ1 = _aZ1 - _bZ1;

            Console.WriteLine($"Теперь значение переменной А равно {_aZ1}, а переменной В - {_bZ1}");

            //задание 2
            Console.WriteLine("Введите значение А, В и С:");
            double _aZ2 = double.Parse(Console.ReadLine());
            double _bZ2 = double.Parse(Console.ReadLine());
            double _cZ2 = double.Parse(Console.ReadLine());

            _aZ2 = _aZ2 + _bZ2;
            _bZ2 =  _aZ2 - _bZ2;
            _aZ2 = _aZ2 - _bZ2;

            _aZ2 = _aZ2 + _cZ2;
            _cZ2 = _aZ2 - _cZ2;
            _aZ2 = _aZ2 - _cZ2;

            Console.WriteLine($"Теперь значение переменной А равно {_aZ2}, переменной В - {_bZ2}, а переменной C - {_cZ2}");

            //задание 3
            Console.WriteLine("Введите значение А, В и С:");
            double _aZ3 = double.Parse(Console.ReadLine());
            double _bZ3 = double.Parse(Console.ReadLine());
            double _cZ3 = double.Parse(Console.ReadLine());

            _aZ3 = _aZ3 + _bZ3;
            _bZ3 = _aZ3 - _bZ3;
            _aZ3 = _aZ3 - _bZ3;

            _bZ3 = _bZ3 + _cZ3;
            _cZ3 = _bZ3 - _cZ3;
            _bZ3 = _bZ3 - _cZ3;

            Console.WriteLine($"Теперь значение переменной А равно {_aZ3}, переменной В - {_bZ3}, а переменной C - {_cZ3}");

            //задание 4 & 5
            double _yZ4;
            double _yZ5;

            Console.WriteLine("Введите значение x:");
            double _x = double.Parse(Console.ReadLine());

            _yZ4 = 3 * Math.Pow(_x, 6) - 6 * Math.Pow(_x, 2) - 7;
            _yZ5 = 4 * Math.Pow(_x - 3, 6) - 7 * Math.Pow(_x - 3, 6) + 2;

            Console.WriteLine($"Значение функции из задания 4 при заданном х равно {_yZ4}, а из задания 5 - {_yZ5}");

            //задание 6 & 7
            double _temp1;
            double _temp2;

            double _aZ6;
            double _aZ7;

            Console.WriteLine("Введите значение А:");
            double _A = double.Parse(Console.ReadLine());

            _temp1 = Math.Pow(_A, 2);
            _aZ6 = _temp1 * _temp1 * _temp1 * _temp1;
            _temp2 = Math.Pow(_A, 3);
            _aZ7 = _temp2 * _temp2 * _temp2 * _temp1 * _temp1 * _temp1;

            Console.WriteLine($"А в 8 степени равно {_aZ6}, а в 15 степени - {_aZ7}");

        }
    }
}
