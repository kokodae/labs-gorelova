using System;

namespace labs_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, temp1, temp2, k;
            Random x = new Random();
            //задание 1
            Console.WriteLine("Введите размер массива:");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                int[] _arr1 = new int[n1];
                Console.WriteLine("Массив: ");
                _arr1[0] = 1;
                Console.Write($"{_arr1[0]} ");

                for (i = 1; i < n1; i++)
                {
                    _arr1[i] = _arr1[i - 1] + 2;
                    Console.Write($"{_arr1[i]} ");
                }
                Console.WriteLine("");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 2
            Console.WriteLine("Введите кол-во элементов прогрессии, первый элемент и знаменатель:");
            int n2 = int.Parse(Console.ReadLine());
            double a2= double.Parse(Console.ReadLine());
            double d2= double.Parse(Console.ReadLine());

            if (n2 > 1)
            {
                double[] _arr2 = new double[n2];
                _arr2[0] = a2;
                Console.WriteLine("Массив: ");
                Console.Write($"{_arr2[0]} ");

                for (i = 1; i < n2; i++)
                {
                    _arr2[i] = _arr2[i - 1] * d2;
                    Console.Write($"{_arr2[i]} ");
                }
                Console.WriteLine("");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 3
            Console.WriteLine("Введите кол-во элементов прогрессии и первые два ее элемента:");
            int n3 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());

            if (n3 > 2)
            {
                int[] _arr3 = new int[n3];
                _arr3[0] = a3; _arr3[1] = b3;

                Console.WriteLine("Массив: ");
                Console.Write($"{_arr3[0]} {_arr3[1]} ");

                for (i = 2; i < n3; i++)
                {
                    _arr3[i] = _arr3[i - 1] + _arr3[i - 2];
                    Console.Write($"{_arr3[i]} ");
                }
                Console.WriteLine("");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");


            //задание 4
            Console.WriteLine("Введите размер массива:");
            int n4 = int.Parse(Console.ReadLine());

            if (n4 > 0)
            {
                int[] _arr4 = new int[n4];

                Console.WriteLine("Массив: ");
                for (i = 0; i < n4; i++)
                { 
                    _arr4[i] = x.Next(-100, 100); 
                    Console.Write($"{_arr4[i]} "); 
                }
                Console.WriteLine("");

                temp1 = 0; temp2 = 0;
                Console.WriteLine("По порядку задания:");
                for (i = 0; i < n4; i++)
                {
                    if ( i % 2 == 0)
                    { Console.Write($"{_arr4[temp2]} "); temp2++; }
                    else
                    { Console.Write($"{_arr4[n4 - 1 - temp1]} "); temp1++; }
                }
                Console.WriteLine("");
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");

            //задание 5
            Console.WriteLine("Введите размер массива:");
            int n5 = int.Parse(Console.ReadLine());

            if (n5 > 0)
            {
                temp1 = 0; temp2 = 0;
                int[] _arr5 = new int[n5];

                Console.WriteLine("Массив: ");
                for (i = 0; i < n5; i++)
                {
                    _arr5[i] = x.Next(-100, 100);
                    Console.Write($"{_arr5[i]} ");
                    if (_arr5[i] % 2 == 0)
                    { temp2++; }
                    else
                    { temp1++; }
                }
                Console.WriteLine("");

                if (temp1 > 0)
                {
                    k = 0;
                    int[] _nech = new int[temp1];
                    for (i = 0; i < n5; i++)
                    {
                        if ((_arr5[i] % 2 == 1) || (_arr5[i] % 2 == -1))
                        {
                            _nech[k] = _arr5[i];
                            //Console.Write($"{_nech[k]} ");
                            k++;
                        }
                    }
                    //Console.WriteLine("");

                    Array.Sort(_nech);
                    Console.WriteLine("Нечетные числа в порядке возрастания:");
                    for (i = 0; i < temp1; i++)
                    {
                        Console.Write($"{_nech[i]} ");
                    }
                    Console.WriteLine("");
                }
                else { Console.WriteLine("Нечетных чисел нет"); }

                if (temp2 > 0)
                {
                    k = 0;
                    int[] _ch = new int[temp2];
                    for (i = 0; i < n5; i++)
                    {
                        if (_arr5[i] % 2 == 0)
                        {
                            _ch[k] = _arr5[i];
                            //Console.Write($"{_ch[k]} ");
                            k++;
                        }
                    }
                    //Console.WriteLine("");

                    Array.Sort(_ch);
                    Console.WriteLine("Четные числа в порядке убывания:");
                    for (i = temp2 - 1; i > -1; i--)
                    {
                        Console.Write($"{_ch[i]} ");
                    }
                    Console.WriteLine("");
                }
                else { Console.WriteLine("Четных чисел нет"); }
            }
            else { Console.WriteLine("Введены неверные значения"); }
            Console.WriteLine("");
        }
    }
}
