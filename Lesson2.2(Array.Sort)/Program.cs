using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._2_Array.Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Це рішення задачі простіше, але ми не знаємо індексу нашого числа, тому розв'язок не повний(на мій погляд)
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = new int[100];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 900);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(array);

            Console.WriteLine($"Друге найменше число в масиві: {array[1]}");
        }
    }
}
