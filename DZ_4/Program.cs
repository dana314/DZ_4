// 5.1 написать метод, который находит набольшее значение из 2 чисел

using System;
namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите целое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите целое число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int maxValue = Max(a, b);
            Console.WriteLine($"наибольшее число: {maxValue}");

            static int Max(int a, int b)
            {
                return a > b ? a : b;
            }


            //5.2 поменять значение вводимых данных местами

            int A = 5;
            int B = 10;

            Console.WriteLine($"до: a = {A}, b = {B}");

            
            Swap(ref A, ref B);

            Console.WriteLine($"после: a = {A}, b = {B}");

            static void Swap(ref int z, ref int u)
            {
                int v = z;
                z = u;
                u = v;
            }
            
            // 5.3 написать метод вычисления факториала
            Console.WriteLine("введите число для вычисления факториала: ");
            int n = int.Parse(Console.ReadLine());
            long result;

            if (factorial(n, out result))
            {
                Console.WriteLine($"факториал {n} равен {result}");
            }
            else
            {
                Console.WriteLine("переполнение факториала.");
            }
        }

        static bool factorial(int n, out long factorial)
        {
            factorial = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        factorial *= i;
                    }
                }
            }
            catch (OverflowException)
            {
                return false;
            }
            return true;

            //5.1 ДЗ написать метод НОД для 2 и 3 натуральных чисел с одним именем
            Console.WriteLine("Введите два натуральных числа для вычисления НОД: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int NODTwo = NOD(a, b);
            Console.WriteLine($"НОД({a} и {b}) = {NODTwo}");


            Console.WriteLine("Введите три натуральных числа для вычисления НОД: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int NODThree = NOD(x, y, z);
            Console.WriteLine($"НОД({x}, {y}, {z}) = {NODThree}");
        }
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int z = b;
                b = a % b;
                a = z;
            }
            return a;
        }
        static int NOD(int a, int b, int c)
        {
            return NOD(NOD(a, b), c);
        }
    }
    
}
        








    


