using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = new int[100];
            Random random = new Random();
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 900);
                if (array[i] < min)
                    min = array[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int newMin = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < newMin && array[i] > min)
                {
                    newMin = array[i];
                    index = i;
                }
            }
            Console.WriteLine($"Друге найменше число {newMin}, а його індекс - {index}");
        }
    }
}
