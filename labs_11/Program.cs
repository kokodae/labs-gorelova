using System;

namespace labs_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите А и В:");
            int _aZ1 = int.Parse(Console.ReadLine());
            int _bZ1 = int.Parse(Console.ReadLine());

            if (_aZ1 > _bZ1)
            { _bZ1 = _aZ1; }
            else if (_aZ1 < _bZ1)
            { _aZ1 = _bZ1; }
            else
            { 
                _aZ1 = 0;
                _bZ1 = 0;
            }

            Console.WriteLine($"Значение А - {_aZ1}, В - {_bZ1}");


            //задание 2
            double _z2;
            Console.WriteLine("Введите А, В и С:");
            double _aZ2 = double.Parse(Console.ReadLine());
            double _bZ2 = double.Parse(Console.ReadLine());
            double _cZ2 = double.Parse(Console.ReadLine());

            if ((_aZ2 >= _bZ2) && (_aZ2 >= _cZ2))
            {
                if (_bZ2 > _cZ2)
                { _z2 = _aZ2 + _bZ2; }
                else
                { _z2 = _aZ2 + _cZ2; }
            }
            else if ((_bZ2 > _cZ2) && (_bZ2 > _aZ2))
            {
                if (_cZ2 > _aZ2)
                { _z2 = _bZ2 + _cZ2; }
                else
                { _z2 = _bZ2 + _aZ2; }
            }
            else
            {
                if (_aZ2 > _bZ2)
                { _z2 = _cZ2 + _aZ2; }
                else
                { _z2 = _cZ2 + _bZ2; }
            }

            Console.WriteLine($"Сумма двух наибольших чисел равна {_z2}");


            //задание 3
            Console.WriteLine("Введите координаты А:");
            double _a_x = double.Parse(Console.ReadLine());
            double _a_y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты B:");
            double _b_x = double.Parse(Console.ReadLine());
            double _b_y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты C:");
            double _c_x = double.Parse(Console.ReadLine());
            double _c_y = double.Parse(Console.ReadLine());

            double _d_ab = Math.Sqrt( Math.Pow(_a_x - _b_x, 2) + Math.Pow(_a_y - _b_y, 2) );
            double _d_ac = Math.Sqrt(Math.Pow(_a_x - _c_x, 2) + Math.Pow(_a_y - _c_y, 2));

            if (_d_ab < _d_ac)
            { Console.WriteLine($"Точка В ближе, расстояние равно {_d_ab}"); }
            else if (_d_ab > _d_ac)
            { Console.WriteLine($"Точка C ближе, расстояние равно {_d_ac}"); }
            else
            { Console.WriteLine($"В и С наа одинаковом расстоянии {_d_ab}"); }


            //задание 4
            Console.WriteLine("Введите координаты точки:");
            double _x = double.Parse(Console.ReadLine());
            double _y = double.Parse(Console.ReadLine());

            if ((_x == 0) || (_y == 0))
            { Console.WriteLine("Введены неверные значения"); }
            else
            {
                if (_x > 0)
                {
                    if (_y > 0)
                    { Console.WriteLine("Номер четверти 1"); }
                    else
                    { Console.WriteLine("Номер четверти 4"); }
                }
                else
                {
                    if (_y > 0)
                    { Console.WriteLine("Номер четверти 2"); }
                    else
                    { Console.WriteLine("Номер четверти 3"); }
                }
            }


            //задание 5
            Console.WriteLine("Введите число:");
            int _z5 = int.Parse(Console.ReadLine());

            if (_z5 > 0)
            {
                if (_z5 % 2 == 0)
                { Console.WriteLine("Положительное четное число"); }
                else
                { Console.WriteLine("Положительное нечетное число"); }
            }
            else if (_z5 < 0)
            {
                if (_z5 % 2 == 0)
                { Console.WriteLine("Отрицательное четное число"); }
                else
                { Console.WriteLine("Отрицательное нечетное число"); }
            }
            else 
            { Console.WriteLine("Нулевое число"); }


            //задание 6
            Console.WriteLine("Введите число:");
            int _z6 = int.Parse(Console.ReadLine());

            if ((_z6 > 0) && (_z6 < 1000))
            {
                if (_z6 < 10)
                {
                    if (_z5 % 2 == 0)
                    { Console.WriteLine("Однозначное четное число"); }
                    else 
                    { Console.WriteLine("Однозначное нечетное число"); }
                }
                else if (_z6 < 100)
                {
                    if (_z5 % 2 == 0)
                    { Console.WriteLine("Двузначное четное число"); }
                    else
                    { Console.WriteLine("Двузначное нечетное число"); }
                }
                else
                {
                    if (_z5 % 2 == 0)
                    { Console.WriteLine("Трехзначное четное число"); }
                    else
                    { Console.WriteLine("Трехзначное нечетное число"); }
                }
            }
            else { Console.WriteLine("Введены неверные значения"); }
        }
    }
}
