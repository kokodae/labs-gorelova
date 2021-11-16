using System;

namespace labs_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите день и месяц:");
            int _day = int.Parse(Console.ReadLine());
            int _month = int.Parse(Console.ReadLine());

            switch (_day)
            {
                case 1:
                    Console.Write("первое ");
                    break;
                case 2:
                    Console.Write("второе ");
                    break;
                case 3:
                    Console.Write("третье ");
                    break;
                case 4:
                    Console.Write("четвертое ");
                    break;
                case 5:
                    Console.Write("пятое ");
                    break;
                case 6:
                    Console.Write("шестое ");
                    break;
                case 7:
                    Console.Write("седьмое ");
                    break;
                case 8:
                    Console.Write("восьмое ");
                    break;
                case 9:
                    Console.Write("девятое ");
                    break;
                case 10:
                    Console.Write("десятое ");
                    break;
                case 11:
                    Console.Write("одиннадцатое ");
                    break;
                case 12:
                    Console.Write("двенадцатое ");
                    break;
                case 13:
                    Console.Write("тринадцатое ");
                    break;
                case 14:
                    Console.Write("четырнадцатое ");
                    break;
                case 15:
                    Console.Write("пятнадцатое ");
                    break;
                case 16:
                    Console.Write("шестнадцатое ");
                    break;
                case 17:
                    Console.Write("семнадцатое ");
                    break;
                case 18:
                    Console.Write("восемнадцатое ");
                    break;
                case 19:
                    Console.Write("девятнадцатое ");
                    break;
                case 20:
                    Console.Write("двадцатое ");
                    break;
                case 21:
                    Console.Write("двадцать первое ");
                    break;
                case 22:
                    Console.Write("двадцать второе ");
                    break;
                case 23:
                    Console.Write("двадцать третье ");
                    break;
                case 24:
                    Console.Write("двадцать четвертое ");
                    break;
                case 25:
                    Console.Write("двадцать пятое ");
                    break;
                case 26:
                    Console.Write("двадцать шестое ");
                    break;
                case 27:
                    Console.Write("двадцать седьмое ");
                    break;
                case 28:
                    Console.Write("двадцать восьмое ");
                    break;
                case 29:
                    Console.Write("двадцать девятое ");
                    break;
                case 30:
                    Console.Write("тридцатое ");
                    break;
                case 31:
                    Console.Write("тридцать первое ");
                    break;
                default:
                    Console.WriteLine("неверное значение дня");
                    break;
            }

            switch (_month)
            {
                case 1:
                    Console.WriteLine("января");
                    break;
                case 2:
                    Console.WriteLine("февраля");
                    break;
                case 3:
                    Console.WriteLine("марта");
                    break;
                case 4:
                    Console.WriteLine("апреля");
                    break;
                case 5:
                    Console.WriteLine("мая");
                    break;
                case 6:
                    Console.WriteLine("июня");
                    break;
                case 7:
                    Console.WriteLine("июля");
                    break;
                case 8:
                    Console.WriteLine("августа");
                    break;
                case 9:
                    Console.WriteLine("сентября");
                    break;
                case 10:
                    Console.WriteLine("октября");
                    break;
                case 11:
                    Console.WriteLine("ноября");
                    break;
                case 12:
                    Console.WriteLine("декабря");
                    break;
                default:
                    Console.WriteLine("неверное значение месяца");
                    break;
            }

            Console.WriteLine("");


            //задание 2
            Console.WriteLine("Введите направление и команду:");
            string _symbol = Console.ReadLine();
            int _dir = int.Parse(Console.ReadLine());
            bool _zn = true;
            int _temp = 0;

            switch (_symbol)
            {
                case "С":
                    _temp = 0;
                    break;
                case "В":
                    _temp = 3;
                    break;
                case "З":
                    _temp = 1;
                    break;
                case "Ю":
                    _temp = 2;
                    break;
                default:
                    _zn = false;
                    break;
            }

            if ((_dir > -2) && (_dir < 2) && (_zn == true))
            {
                _temp = _temp + _dir;
                switch (_temp)
                {
                    case 0:
                        Console.WriteLine("Робот направлен на север");
                        break;
                    case 4:
                        Console.WriteLine("Робот направлен на север");
                        break;
                    case 1:
                        Console.WriteLine("Робот направлен на запад");
                        break;
                    case 2:
                        Console.WriteLine("Робот направлен на юг");
                        break;
                    case 3:
                        Console.WriteLine("Робот направлен на восток");
                        break;
                    case -1:
                        Console.WriteLine("Робот направлен на восток");
                        break;
                }
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 3
            Console.WriteLine("Введите количество заданий:");
            int _z = int.Parse(Console.ReadLine());

            if ((_z > 9) && (_z < 41))
            {
                switch (_z)
                {
                    case 10:
                        Console.WriteLine("десять учебных заданий");
                        break;
                    case 11:
                        Console.WriteLine("одиннадцать учебных заданий");
                        break;
                    case 12:
                        Console.WriteLine("двенадцать учебных заданий");
                        break;
                    case 13:
                        Console.WriteLine("тринадцать учебных заданий");
                        break;
                    case 14:
                        Console.WriteLine("четырнадцать учебных заданий");
                        break;
                    case 15:
                        Console.WriteLine("пятнадцать учебных заданий");
                        break;
                    case 16:
                        Console.WriteLine("шестнадцать учебных заданий");
                        break;
                    case 17:
                        Console.WriteLine("семнадцать учебных заданий");
                        break;
                    case 18:
                        Console.WriteLine("восемнадцать учебных заданий");
                        break;
                    case 19:
                        Console.WriteLine("девятнадцать учебных заданий");
                        break;
                    case 20:
                        Console.WriteLine("двадцать учебных заданий");
                        break;
                    case 21:
                        Console.WriteLine("двадцать одно учебное задание");
                        break;
                    case 22:
                        Console.WriteLine("двадцать два учебных задания");
                        break;
                    case 23:
                        Console.WriteLine("двадцать три учебных задания");
                        break;
                    case 24:
                        Console.WriteLine("двадцать четыре учебных задания");
                        break;
                    case 25:
                        Console.WriteLine("двадцать пять учебных заданий");
                        break;
                    case 26:
                        Console.WriteLine("двадцать шесть учебных заданий");
                        break;
                    case 27:
                        Console.WriteLine("двадцать семь учебных заданий");
                        break;
                    case 28:
                        Console.WriteLine("двадцать восемь учебных заданий");
                        break;
                    case 29:
                        Console.WriteLine("двадцать девять учебных заданий");
                        break;
                    case 30:
                        Console.WriteLine("тридцать учебных заданий");
                        break;
                    case 31:
                        Console.WriteLine("тридцать одно учебное задание");
                        break;
                    case 32:
                        Console.WriteLine("тридцать два учебных задания");
                        break;
                    case 33:
                        Console.WriteLine("тридцать три учебных задания");
                        break;
                    case 34:
                        Console.WriteLine("тридцать четыре учебных задания");
                        break;
                    case 35:
                        Console.WriteLine("тридцать пять учебных заданий");
                        break;
                    case 36:
                        Console.WriteLine("тридцать шесть учебных заданий");
                        break;
                    case 37:
                        Console.WriteLine("тридцать семь учебных заданий");
                        break;
                    case 38:
                        Console.WriteLine("тридцать восемь учебных заданий");
                        break;
                    case 39:
                        Console.WriteLine("тридцать девять учебных заданий");
                        break;
                    case 40:
                        Console.WriteLine("сорок учебных заданий");
                        break;
                }
            }
            else { Console.WriteLine("Введены неверные значения"); }

            Console.WriteLine("");


            //задание 4
            Console.WriteLine("Введите число:");
            int _x = int.Parse(Console.ReadLine());
            int _x1, _x2, _x3;
            _temp = 0;

            if ((_x > 99) && (_x < 1000))
            {
                _x1 = _x % 10;
                _x2 = (_x % 100 - _x1) / 10;
                _x3 = (_x - _x1 - _x2 * 10) / 100;

                switch (_x3)
                {
                    case 1:
                        Console.Write("сто ");
                        break;
                    case 2:
                        Console.Write("двести ");
                        break;
                    case 3:
                        Console.Write("триста ");
                        break;
                    case 4:
                        Console.Write("четыреста ");
                        break;
                    case 5:
                        Console.Write("пятьсот ");
                        break;
                    case 6:
                        Console.Write("шестьсот ");
                        break;
                    case 7:
                        Console.Write("семьсот ");
                        break;
                    case 8:
                        Console.Write("восемьсот ");
                        break;
                    case 9:
                        Console.Write("девятьсот ");
                        break;
                }

                switch (_x2)
                {
                    case 1:
                        _temp = 1;
                        break;
                    case 2:
                        Console.Write("двадцать ");
                        break;
                    case 3:
                        Console.Write("тридцать ");
                        break;
                    case 4:
                        Console.Write("сорок ");
                        break;
                    case 5:
                        Console.Write("пятьдесят ");
                        break;
                    case 6:
                        Console.Write("шестьдесят ");
                        break;
                    case 7:
                        Console.Write("семьдесят ");
                        break;
                    case 8:
                        Console.Write("восемьдесят ");
                        break;
                    case 9:
                        Console.Write("девяносто ");
                        break;
                }

                if (_temp == 1)
                {
                    switch (_x1)
                    {
                        case 0:
                            Console.Write("десять");
                            break;
                        case 1:
                            Console.Write("одиннадцать");
                            break;
                        case 2:
                            Console.Write("двенадцать");
                            break;
                        case 3:
                            Console.Write("тринадцать");
                            break;
                        case 4:
                            Console.Write("четырнадцать");
                            break;
                        case 5:
                            Console.Write("пятнадцать");
                            break;
                        case 6:
                            Console.Write("шестнадцать");
                            break;
                        case 7:
                            Console.Write("семнадцать");
                            break;
                        case 8:
                            Console.Write("восемнадцать");
                            break;
                        case 9:
                            Console.Write("девятнадцать");
                            break;
                    }
                }
                else
                {
                    switch (_x1)
                    {
                        case 1:
                            Console.Write("один");
                            break;
                        case 2:
                            Console.Write("два");
                            break;
                        case 3:
                            Console.Write("три");
                            break;
                        case 4:
                            Console.Write("четыре");
                            break;
                        case 5:
                            Console.Write("пять");
                            break;
                        case 6:
                            Console.Write("шесть");
                            break;
                        case 7:
                            Console.Write("семь");
                            break;
                        case 8:
                            Console.Write("восемь");
                            break;
                        case 9:
                            Console.Write("девять");
                            break;
                    }
                }
            }
            else { Console.WriteLine("Введены неверные значения"); }

            Console.WriteLine("");
            Console.WriteLine("");


            //задание 5
            Console.WriteLine("Введите год:");
            int _year = int.Parse(Console.ReadLine());
            int _color, _animal;

            _temp = Math.Abs(1984 - _year);
            _color = _temp % 60; ;
            _animal = _temp % 12;

            if (_color < 12) { _color = 1; }
            if ((_color > 11) && (_color < 24)) { _color = 2; }
            if ((_color > 23) && (_color < 36)) { _color = 3; }
            if ((_color > 35) && (_color < 48)) { _color = 4; }
            if (_color > 47) { _color = 5; }

            if (_year >= 1984)
            {
                if ((_animal > 1) && (_animal < 5))
                {
                    switch (_color)
                    {
                        case 1:
                            Console.Write("год зеленого");
                            break;
                        case 2:
                            Console.Write("год красного");
                            break;
                        case 3:
                            Console.Write("год желтого");
                            break;
                        case 4:
                            Console.Write("год белого");
                            break;
                        case 5:
                            Console.Write("год черного");
                            break;
                    }
                }
                else
                {
                    switch (_color)
                    {
                        case 1:
                            Console.Write("год зеленой");
                            break;
                        case 2:
                            Console.Write("год красной");
                            break;
                        case 3:
                            Console.Write("год желтой");
                            break;
                        case 4:
                            Console.Write("год белой");
                            break;
                        case 5:
                            Console.Write("год черной");
                            break;
                    }
                }

                switch (_animal)
                {
                    case 0:
                        Console.WriteLine(" крысы");
                        break;
                    case 1:
                        Console.WriteLine(" коровы");
                        break;
                    case 2:
                        Console.WriteLine(" тигра");
                        break;
                    case 3:
                        Console.WriteLine(" зайца");
                        break;
                    case 4:
                        Console.WriteLine(" дракона");
                        break;
                    case 5:
                        Console.WriteLine(" змеи");
                        break;
                    case 6:
                        Console.WriteLine(" лошади");
                        break;
                    case 7:
                        Console.WriteLine(" овцы");
                        break;
                    case 8:
                        Console.WriteLine(" обезьяны");
                        break;
                    case 9:
                        Console.WriteLine(" курицы");
                        break;
                    case 10:
                        Console.WriteLine(" собаки");
                        break;
                    case 11:
                        Console.WriteLine(" свиньи");
                        break;
                }
            }
            else
            {
                if ((_animal > 1) && (_animal < 5))
                {
                    switch (_color)
                    {
                        case 5:
                            Console.Write("год зеленого");
                            break;
                        case 4:
                            Console.Write("год красного");
                            break;
                        case 3:
                            Console.Write("год желтого");
                            break;
                        case 2:
                            Console.Write("год белого");
                            break;
                        case 1:
                            Console.Write("год черного");
                            break;
                    }
                }
                else
                {
                    switch (_color)
                    {
                        case 5:
                            Console.Write("год зеленой");
                            break;
                        case 4:
                            Console.Write("год красной");
                            break;
                        case 3:
                            Console.Write("год желтой");
                            break;
                        case 2:
                            Console.Write("год белой");
                            break;
                        case 1:
                            Console.Write("год черной");
                            break;
                    }
                }

                switch (_animal)
                {
                    case 0:
                        Console.WriteLine(" крысы");
                        break;
                    case 11:
                        Console.WriteLine(" коровы");
                        break;
                    case 10:
                        Console.WriteLine(" тигра");
                        break;
                    case 9:
                        Console.WriteLine(" зайца");
                        break;
                    case 8:
                        Console.WriteLine(" дракона");
                        break;
                    case 7:
                        Console.WriteLine(" змеи");
                        break;
                    case 6:
                        Console.WriteLine(" лошади");
                        break;
                    case 5:
                        Console.WriteLine(" овцы");
                        break;
                    case 4:
                        Console.WriteLine(" обезьяны");
                        break;
                    case 3:
                        Console.WriteLine(" курицы");
                        break;
                    case 2:
                        Console.WriteLine(" собаки");
                        break;
                    case 1:
                        Console.WriteLine(" свиньи");
                        break;
                }
            }
        }
    }
}
