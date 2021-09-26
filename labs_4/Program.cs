using System;

namespace labs_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!первое задание, сначала пишем ввод сторон прямоугольника с небольшой проверкой, мало ли введут не число а буковки
            Console.WriteLine("Введите длину прямоугольника:");
            bool _isLength = double.TryParse(Console.ReadLine(), out double _length);

            Console.WriteLine("Введите ширину прямоугольника:");
            bool _isWidth = double.TryParse(Console.ReadLine(), out double _width);

            if (_isLength == false || _isWidth == false)
            {
                Console.WriteLine("Неверные значения параметров");
            }
            else
            {
                double _perimetr = 2 * (_length + _width);
                double _square = _length * _width;

                Console.WriteLine($"Периметр равен {_perimetr}, площадь равна {_square}");
            }


            //!!!второе задание, делаем константу пи и аналогично пишем ввод диаметра окр.
            const double PI = 3.14f;
            Console.WriteLine("Введите диаметр окружности:");

            bool _isDiam = double.TryParse(Console.ReadLine(), out double _diametr);
            if (_isDiam == false)
            {
                Console.WriteLine("Неверные значения параметров");
            }
            else
            {
                double _lengthokr = PI * _diametr;

                Console.WriteLine($"Диаметр равен {_lengthokr}");
            }


            //!!!третье задание
            Console.WriteLine("Введите число а:");
            bool _isA1 = double.TryParse(Console.ReadLine(), out double _a1);

            Console.WriteLine("Введите число b:");
            bool _isB1 = double.TryParse(Console.ReadLine(), out double _b1);

            if (_isA1 == false || _isB1 == false)
            {
                Console.WriteLine("Неверные значения параметров");
            }
            else
            {
                double _srArifm = (_a1 + _b1)/2;
                Console.WriteLine($"Среднее арифметическое чисел a и b равно {_srArifm}");
            }


            //!!!четвертое и пятое задание, т.к. в обоих нужны два ненулевых числа, я решила сделать их вместе
            Console.WriteLine("Введите первое ненулевое число:");
            bool _isA2 = double.TryParse(Console.ReadLine(), out double _a2);

            Console.WriteLine("Введите второе ненулевое число:");
            bool _isB2 = double.TryParse(Console.ReadLine(), out double _b2);

            if (_isA2 == false || _isB2 == false || _a2 == 0 || _b2 == 0)
            {
                Console.WriteLine("Неверные значения параметров");
            }
            else
            {
                //задание 4 - с квадратами чисел
                double _sum4 = Math.Pow(_a2, 2) + Math.Pow(_b2, 2);
                double _dif4 = Math.Pow(_a2, 2) - Math.Pow(_b2, 2);
                double _pr4 = Math.Pow(_a2, 2) * Math.Pow(_b2, 2);
                double _ch4 = Math.Pow(_a2, 2) / Math.Pow(_b2, 2);

                Console.WriteLine($"Сумма квадратов этих чисел равна {_sum4}, разность - {_dif4}, произведение - {_pr4}, частное - {_ch4}");

                //задание 5 - с модулями чисел
                double _sum5 = Math.Abs(_a2) + Math.Abs(_b2);
                double _dif5 = Math.Abs(_a2) - Math.Abs(_b2);
                double _pr5 = Math.Abs(_a2) * Math.Abs(_b2);
                double _ch5 = Math.Abs(_a2) / Math.Abs(_b2);

                Console.WriteLine($"Сумма модулей этих чисел равна {_sum5}, разность - {_dif5}, произведение - {_pr5}, частное - {_ch5}");
            }
        }
    }
}
