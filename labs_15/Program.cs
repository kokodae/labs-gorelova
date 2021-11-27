using System;

namespace labs_15
{
    class Program
    {
        static double PowerA3(double A, double B)
        {
            B = A * A * A;
            return B;
        }

        static int Sign(double X)
        {
            int RES;
            if (X > 0) { RES = 1; }
            else if (X == 0) { RES = 0; }
            else { RES = -1; }
            return RES;
        }

        static double RingS(double R1, double R2)
        {
            double RES = Math.PI * (R1 * R1 - R2 * R2);
            return RES;
        }

        static int Qarter(double x, double y)
        {
            int RES = 0;
            
            if (x > 0)
            {
                if (y > 0) { RES = 1; }
                else { RES = 4; }
            }
            else
            {
                if (y > 0) { RES = 2; }
                else { RES = 3; }
            }

            return RES;
        }

        static double Fact2(int N)
        {
            double RES = 1;
            int temp = 0;

            if (N % 2 == 1) { temp = 1; }
            else { temp = 2; }

            for (int i = temp; i <= N; i = i + 2)
            {
                RES = RES * i;
            }

            return RES;
        }

        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите пять чисел:");
            double _a1 = 0, _b1 = 0;
            for (int i = 1; i < 6; i++)
            {
                _a1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Это число в 3 степени равно {PowerA3(_a1, _b1)}");
            }
            Console.WriteLine("");


            //задание 2
            Console.WriteLine("Введите А и В:");
            double _a2 = double.Parse(Console.ReadLine());
            double _b2 = double.Parse(Console.ReadLine());

            int _sum2 = Sign(_a2) + Sign(_b2);
            Console.WriteLine($"Значение заданного выражения равно {_sum2}");
            Console.WriteLine("");


            //задание 3
            Console.WriteLine("Введите параметры трех колец:");
            double _r2, _r1;

            for (int i = 1; i < 4; i++)
            {
                _r1 = double.Parse(Console.ReadLine());
                _r2 = double.Parse(Console.ReadLine());

                if (_r1 > _r2)
                {
                    Console.WriteLine($"Площадь этого кольца равна {RingS(_r1, _r2)}");
                }
                else { Console.WriteLine("Введены неверные значения"); }
            }

            Console.WriteLine("");


            //задание 4
            Console.WriteLine("Введите параметры трех точек:");
            double _x4, _y4;
            
            for (int i = 1; i < 4; i++)
            {
                _x4 = double.Parse(Console.ReadLine());
                _y4 = double.Parse(Console.ReadLine());

                if ((_x4 == 0) || (_y4 == 0))
                { Console.WriteLine("Введены неверные значения"); }
                else
                {
                    Console.WriteLine($"Номер четверти - {Qarter(_x4, _y4)}");
                }
            }

            Console.WriteLine("");


            //задание 5
            Console.Write("Введите число: ");
            int _n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Значение функции Fact2 равно {Fact2(_n)}");
        }
    }
}
