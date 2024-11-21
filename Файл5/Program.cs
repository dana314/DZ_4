// 2 написать метод гед в качестве аргумента будет передан массив
// вывести сумму элементов массива
//  вывести произведение массива и вывести среднее арифметическое в массиве

using System;
namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 7, 29 };
            int sum;
            long pr = 1;
            double middle;

            CalculateArray(array, ref pr, out middle);
            sum = CalculateSum(array);

            Console.WriteLine($"сумма : {sum}");
            Console.WriteLine($"произведение: {pr}");
            Console.WriteLine($"среднее: {middle}");
        }

        static void CalculateArray(int[] numbers, ref long pr, out double middle)
        {
            int res = numbers.Length;
            double sum = 0;

            for (int i = 0; i < res; i++)
            {
                pr *= numbers[i];
                sum += numbers[i];
            }

            middle = sum / res;
        }

        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

    }
}