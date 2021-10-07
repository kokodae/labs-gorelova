using System;

namespace labs_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите размер файла в байтах:");
            double _v_byte = double.Parse(Console.ReadLine());

            double _v_kb = Math.Ceiling(_v_byte / 1024);
            Console.WriteLine($"Этот файл занимает {_v_kb} полных килобайт");

            //задание 2 & 3
            double _countZ2;
            double _tempZ2;
            double _free;

            Console.WriteLine("Введите целые положительные А и В:");
            uint _aZ2 = uint.Parse(Console.ReadLine());
            uint _bZ2 = uint.Parse(Console.ReadLine());

            if ((_aZ2 > _bZ2) && (_bZ2 > 0))
            {
                _tempZ2 = _aZ2 / _bZ2;
                _countZ2 = Math.Floor(_tempZ2);
                _free = _aZ2 - _countZ2 * _bZ2;

                Console.WriteLine($"В отрезке А размещено {_countZ2} отрезков В, не занятая часть равна {_free}");
            }
            else { Console.WriteLine("!!!неправильные значения!!!"); }

            //задание 4
            double _des_z4;
            double _ed_z4;
            double _tempZ4;
            double _resZ4;

            Console.WriteLine("Введите двузначное число");
            int _numZ4 = int.Parse(Console.ReadLine());

            if ((Math.Abs(_numZ4) < 100) || (Math.Abs(_numZ4) > 9))
            {
                _tempZ4 = _numZ4 / 10;
                _des_z4 = Math.Floor(_tempZ4);
                _ed_z4 = _numZ4 - _des_z4 * 10;
                _resZ4 = _des_z4 + _ed_z4 * 10;
                Console.WriteLine($"Результат - {_resZ4}");
            }
            else { Console.WriteLine("!!!неправильное значение!!!"); }

            //задание 5
            double _sot;
            double _des;
            double _ed;
            double _temp;
            double _res;

            Console.WriteLine("Введите трехзначное число");
            int _numZ5 = int.Parse(Console.ReadLine());

            if ((Math.Abs(_numZ5) < 1000) || (Math.Abs(_numZ5) > 99))
            {
                _temp = _numZ5 / 100;
                _sot = Math.Floor(_temp);
                _temp = _numZ5 / 10;
                _des = Math.Floor(_temp) - _sot * 10;
                _ed = _numZ5 - _sot * 100 - _des * 10;

                _res = _des * 100 + _ed * 10 + _sot;
                Console.WriteLine($"Результат - {_res}");
            }
            else { Console.WriteLine("!!!неправильное значение!!!"); }
        }
    }
}
