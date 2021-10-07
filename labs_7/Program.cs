using System;

namespace labs_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            double _a_rad;

            Console.WriteLine("Введите значение угла в градусах:");
            double _aZ1 = double.Parse(Console.ReadLine());

            if ((0 > _aZ1) || (360 < _aZ1))
            { Console.WriteLine("!!!неправильные параметры угла!!!"); }
            else
            {
                _a_rad = _aZ1 / 180;
                Console.WriteLine($"Значение этого угла в радианах равно {_a_rad}");
            }

            //задание 2
            double _a_deg;

            Console.WriteLine("Введите значение угла в радианах:");
            double _aZ2 = double.Parse(Console.ReadLine());

            if ((0 > _aZ2) || (2 < _aZ1))
            { Console.WriteLine("!!!неправильные параметры угла!!!"); }
            else
            {
                _a_deg = _aZ2 * 180;
                Console.WriteLine($"Значение этого угла в градусах равно {_a_deg}");
            }

            //задание 3
            double _price;
            double _bZ3;

            Console.WriteLine("Введите массу конфет, их стоимость и второе значение массы:");
            double _mX = double.Parse(Console.ReadLine());
            double _aZ3 = double.Parse(Console.ReadLine());
            double _mY = double.Parse(Console.ReadLine());

            _price = _aZ3 / _mX;
            _bZ3 = _price * _mY;
            Console.WriteLine($"Стоимость конфет за килограмм равна {_price} рублей,а {_mY} килограмм стоят {_bZ3} рублей");

            //задание 4
            double _z4;

            Console.WriteLine("Введите скорость первого и второго автомобиля, а также расстояние между ними и время:");
            double _v1 = double.Parse(Console.ReadLine());
            double _v2 = double.Parse(Console.ReadLine());
            double _s = double.Parse(Console.ReadLine());
            double _t = double.Parse(Console.ReadLine());

            _z4 = (_v1 + _v2) * _t + _s;
            Console.WriteLine($"Расстояние между автомобилями равно {_z4}");

            //задание 5
            double _xZ5;

            Console.WriteLine("Введите коэффициенты А и В линейного уравнения:");
            double _aZ5 = double.Parse(Console.ReadLine());
            double _bZ5 = double.Parse(Console.ReadLine());

            _xZ5 = -(_bZ5 / _aZ5);
            Console.WriteLine($"Х равен {_xZ5}");

            //задание 6
            double _x;
            double _y;

            Console.WriteLine("Введите коэффициенты А, В и С первого линейного уравнения:");
            double _a1 = double.Parse(Console.ReadLine());
            double _b1 = double.Parse(Console.ReadLine());
            double _c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициенты А, В и С второго линейного уравнения:");
            double _a2 = double.Parse(Console.ReadLine());
            double _b2 = double.Parse(Console.ReadLine());
            double _c2 = double.Parse(Console.ReadLine());

            double _del = _a1 * _b2 - _a2 * _b1;
            double _del_x = _c1 * _b2 - _c2 * _b1;
            double _del_y = _a1 * _c2 - _a2 * _c1;

            _x = _del_x / _del;
            _y = _del_y / _del;
            Console.WriteLine($"Х равен {_x}, У равен {_y}");
        }
    }
}
