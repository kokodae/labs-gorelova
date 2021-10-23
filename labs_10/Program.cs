using System;

namespace labs_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите А и В:");
            int _aZ1 = int.Parse(Console.ReadLine());
            int _bZ1 = int.Parse(Console.ReadLine());

            if ((_aZ1 > 2) && (_bZ1 <= 3))
            { Console.WriteLine("Высказывание истинно"); }
            else
            { Console.WriteLine("Высказывание ложно"); }


            //задание 2
            Console.WriteLine("Введите А, В и С:");
            int _aZ2 = int.Parse(Console.ReadLine());
            int _bZ2 = int.Parse(Console.ReadLine());
            int _cZ2 = int.Parse(Console.ReadLine());

            if ((_aZ2 < _bZ2) && (_bZ2 < _cZ2))
            { Console.WriteLine("Высказывание истинно"); }
            else
            { Console.WriteLine("Высказывание ложно"); }


            //задание 3
            int _tempZ3;
            Console.WriteLine("Введите число:");
            int _aZ3 = int.Parse(Console.ReadLine());

            if (_aZ3 > 0)
            {
                _tempZ3 = _aZ3 % 2;
                if ((_tempZ3 == 0) && (_aZ3 > 9) && (_aZ3 < 100))
                { Console.WriteLine("Высказывание истинно"); }
                else
                { Console.WriteLine("Высказывание ложно"); }
            }
            else { Console.WriteLine("Введены неверные значения"); }

            //задание 4
            int _r1_z4, _r2_z4, _r3_z4;
            Console.WriteLine("Введите трехзначное число:");
            int _aZ4 = int.Parse(Console.ReadLine());

            if ((_aZ4 > 99) && (_aZ4 < 1000))
            {
                _r3_z4 = _aZ4 % 10;
                _r2_z4 = (_aZ4 % 100 - _r3_z4) / 10;
                _r1_z4 = (_aZ4 - _aZ4 % 100) / 100;

                if ((_r3_z4 > _r2_z4) && (_r2_z4 > _r1_z4) && (_r3_z4 != _r2_z4) && (_r2_z4 != _r1_z4))
                { Console.WriteLine("Высказывание истинно"); }
                else
                {
                    if ((_r3_z4 < _r2_z4) && (_r2_z4 < _r1_z4) && (_r3_z4 != _r2_z4) && (_r2_z4 != _r1_z4))
                    { Console.WriteLine("Высказывание истинно"); }
                    else
                    { Console.WriteLine("Высказывание ложно"); }
                }
            }
            else { Console.WriteLine("Введены неверные значения"); }


            //задание 5
            double _r1_z5, _r2_z5, _r3_z5, _r4_z5;
            Console.WriteLine("Введите четрехзначное число:");
            int _aZ5 = int.Parse(Console.ReadLine());

            if ((_aZ5 < 1000) || (_aZ5 > 10000))
            {
                Console.WriteLine("Введены неверные значения");
            }
            else 
            {
                _r4_z5 = _aZ5 % 10;
                _r3_z5 = (_aZ5 % 100 - _r4_z5) / 10;
                _r2_z5 = (_aZ5 % 1000 - _aZ5 % 100) / 100;
                _r1_z5 = (_aZ5 - _aZ5 % 1000) / 1000;

                if ((_r4_z5 == _r1_z5) && (_r3_z5 == _r2_z5))
                { Console.WriteLine("Высказывание истинно"); }
                else
                { Console.WriteLine("Высказывание ложно"); }
            }


            //задание 6 & 7
            int _temp;
            Console.WriteLine("Введите a, b и c:");
            int _a = int.Parse(Console.ReadLine());
            int _b = int.Parse(Console.ReadLine());
            int _c = int.Parse(Console.ReadLine());

            if ((_a > 0) && (_b > 0) && (_c > 0))
            {
                if ((_a + _b > _c) && (_a + _c > _b) && (_c + _b > _a))
                {
                    if ((_a > _b) && (_a > _c))
                    {
                        _temp = _b * _b + _c * _c;
                        if (_temp == Math.Pow(_a, 2 )) { Console.WriteLine("Такой треугольник прямоугольный"); }
                        else { Console.WriteLine("Такой треугольник существует, но он не прямоугольный"); }
                    }
                    else
                    {
                        if ((_b > _c) && (_b > _a))
                        {
                            _temp = _a * _a + _c * _c;
                            if (_temp == Math.Pow(_b, 2)) { Console.WriteLine("Такой треугольник прямоугольный"); }
                            else { Console.WriteLine("Такой треугольник существует, но он не прямоугольный"); }
                        }
                        else
                        {
                            _temp = _b * _b + _a * _a;
                            if (_temp == Math.Pow(_c, 2)) { Console.WriteLine("Такой треугольник прямоугольный"); }
                            else { Console.WriteLine("Такой треугольник существует, но он не прямоугольный"); }
                        }
                    }
                }
                else { Console.WriteLine("Такого треугольника не существует"); }
            }
            else { Console.WriteLine("Введены неверные значения"); }

        }
    }
}
