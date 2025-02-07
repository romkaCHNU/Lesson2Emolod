using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = new int[20];
            Random rand = new Random();
            Console.Write("Заданий масив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10,100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int index = -1;
            int biggestSumm = int.MinValue;

            for (int i = 1;i < array.Length-1;i++)
            {
                if (array[i - 1] + array[i] + array[i + 1] > biggestSumm)
                {
                    biggestSumm = array[i - 1] + array[i] + array[i + 1];
                    index = i;
                }
            }
            Console.WriteLine($"Індекси трьох чисел які мають найбільшу суму значень : {index-1} {index} {index+1}");
            Console.WriteLine($"Ці числа: {array[index-1]} {array[index]} {array[index+1]}");
        }
    }
}
