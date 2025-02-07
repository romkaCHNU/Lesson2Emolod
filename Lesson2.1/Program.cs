using System;
using System.Text;

namespace Lesson2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[][] array = new int[10][];
            Random random = new Random();
            while (true)
            {
                try
                {
                    int min = Input("Введіть початок діапазону: ");
                    int max = Input("Введіть кінець діапазону: ");
                    int countFive = 0;
                    int countRange = 0;
                    Console.WriteLine("Початковий масив:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = new int[10];
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            array[i][j] = random.Next(10, 99);
                            if (array[i][j] % 5 == 0) countFive++;
                            if (array[i][j] >= min && array[i][j] <= max) countRange++;                          
                        }
                        Console.WriteLine(String.Join(" ", array[i]));
                    }
                    
                    Console.WriteLine($"кількість чисел кратних п'яти: {countFive}");
                    Console.WriteLine($"кількість чисел які задовільняють діапазон: {countRange}");
                    return;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некоректний символ!");
                }
            }
        }
        static int Input(string massage) {
            Console.Write(massage);
            return int.Parse(Console.ReadLine());
        }
    }
}
