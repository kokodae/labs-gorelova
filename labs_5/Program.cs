using System;

namespace labs_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!задание 1
            Console.WriteLine("Введите координаты первой точки (x1, y1):");
            double _x1z1 = double.Parse(Console.ReadLine());
            double _y1z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки (x2, y2):");
            double _x2z1 = double.Parse(Console.ReadLine());
            double _y2z1 = double.Parse(Console.ReadLine());

            double _aZ1;
            if (_x1z1 > _x2z1)
            { _aZ1 = _x1z1 - _x2z1; }
            else
            { _aZ1 = _x2z1 - _x1z1; }

            double _bZ1;
            if (_y1z1 > _y2z1)
            { _bZ1 = _y1z1 - _y2z1; }
            else
            { _bZ1 = _y2z1 - _y1z1; }

            double _lenZ1 = Math.Sqrt( Math.Pow(_aZ1, 2) + Math.Pow(_bZ1, 2));
            Console.WriteLine($"Расстояние между точками равно {_lenZ1}");


            //!!!задание 2
            Console.WriteLine("Введите точки А, В, С:");
            double _aZ2 = double.Parse(Console.ReadLine());
            double _bZ2 = double.Parse(Console.ReadLine());
            double _cZ2 = double.Parse(Console.ReadLine());

            double _acZ2;
            if (_aZ2 > _cZ2)
            { _acZ2 = _aZ2 - _cZ2; }
            else 
            { _acZ2 = _cZ2 - _aZ2; }

            double _bcZ2;
            if (_bZ2 > _cZ2)
            { _bcZ2 = _bZ2 - _cZ2; }
            else
            { _bcZ2 = _cZ2 - _bZ2; }

            double _sumZ2 = _acZ2 + _bcZ2;
            Console.WriteLine($"Длина отрезка АС равна {_acZ2}, ВС - {_bcZ2}, сумма этих отрезков - {_sumZ2}");


            //!!!задание 3
            Console.WriteLine("Введите точки А, В, С (точка С между А и В):");
            double _aZ3 = double.Parse(Console.ReadLine());
            double _bZ3 = double.Parse(Console.ReadLine());
            double _cZ3 = double.Parse(Console.ReadLine());

            double _acZ3;
            if (_aZ3 > _cZ3)
            { _acZ3 = _aZ3 - _cZ3; }
            else
            { _acZ3 = _cZ3 - _aZ3; }

            double _bcZ3;
            if (_bZ3 > _cZ3)
            { _bcZ3 = _bZ3 - _cZ3; }
            else
            { _bcZ3 = _cZ3 - _bZ3; }

            double _prZ3 = _acZ3 * _bcZ3;

            Console.WriteLine($"Произведение длин отрезков АС и ВС равно {_prZ3}");


            //!!!задание 4
            Console.WriteLine("Введине координаты первой вершины:");
            double _x1z4 = double.Parse(Console.ReadLine());
            double _y1z4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введине координаты второй вершины:");
            double _x2z4 = double.Parse(Console.ReadLine());
            double _y2z4 = double.Parse(Console.ReadLine());

            double _aZ4;
            if (_x1z4 > _x2z4)
            { _aZ4 = _x1z4 - _x2z4; }
            else
            { _aZ4 = _x2z4 - _x1z4; }

            double _bZ4;
            if (_y1z4 > _y2z4)
            { _bZ4 = _y1z4 - _y2z4; }
            else
            { _bZ4 = _y2z4 - _y1z4; }

            double _perimZ4 = 2 * (_aZ4 + _bZ4);
            double _squareZ4 = _aZ4 * _bZ4;
            Console.WriteLine($"Периметр прямоугольника равен {_perimZ4}, а его площадь равна {_squareZ4}");


            //!!!задание 5
            Console.WriteLine("Введите координаты первой вершины треугольника:");
            double _x1z5 = double.Parse(Console.ReadLine());
            double _y1z5 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины треугольника:");
            double _x2z5 = double.Parse(Console.ReadLine());
            double _y2z5 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты третьей вершины треугольника:");
            double _x3z5 = double.Parse(Console.ReadLine());
            double _y3z5 = double.Parse(Console.ReadLine());

            //тут небольшое месиво с вычислением сторон треугольника, _lenA и _lenB - вспомогательные параметры
            double _lenA;
            if (_x1z5 > _x2z5)
            { _lenA = _x1z5 - _x2z5; }
            else
            { _lenA = _x2z5 - _x1z5; }

            double _lenB;
            if (_y1z5 > _y2z5)
            { _lenB = _y1z5 - _y2z5; }
            else
            { _lenB = _y2z5 - _y1z5; }

            double _aZ5 = Math.Sqrt(Math.Pow(_lenA, 2) + Math.Pow(_lenB, 2));


            if (_x3z5 > _x2z5)
            { _lenA = _x3z5 - _x2z5; }
            else
            { _lenA = _x2z5 - _x3z5; }

            if (_y3z5 > _y2z5)
            { _lenB = _y3z5 - _y2z5; }
            else
            { _lenB = _y2z5 - _y3z5; }

            double _bZ5 = Math.Sqrt(Math.Pow(_lenA, 2) + Math.Pow(_lenB, 2));


            if (_x3z5 > _x1z5)
            { _lenA = _x3z5 - _x1z5; }
            else
            { _lenA = _x1z5 - _x3z5; }

            if (_y3z5 > _y1z5)
            { _lenB = _y3z5 - _y1z5; }
            else
            { _lenB = _y1z5 - _y3z5; }

            double _cZ5 = Math.Sqrt(Math.Pow(_lenA, 2) + Math.Pow(_lenB, 2));

            double _perimZ5 = _aZ5 + _bZ5 + _cZ5;
            double _halfPerim = _perimZ5 / 2;
            double _squareZ5 = Math.Sqrt(_halfPerim * (_halfPerim - _aZ5) * (_halfPerim - _bZ5) * (_halfPerim - _cZ5));

            Console.WriteLine($"Периметр треугольника равен {_perimZ5}, а площадь равна {_squareZ5}");
        }
    }
}
