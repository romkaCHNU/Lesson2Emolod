using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char[] array = Input();
            Result(array);
        }
        static char[] Input() {
            while (true)
            {
            Console.WriteLine("Введіть рядок англійською мовою:");
            char[] input = Console.ReadLine().ToCharArray();
            if (IsEnglish(input)) return input;
            Console.WriteLine("Помилка! Введіть тільки англійські літери.");
            }
        }
        static bool IsEnglish(char[] text) {
            foreach (char letter in text)
            {
                if (!(letter >= 'A' && letter <= 'Z') && !(letter >= 'a' && letter <= 'z'))
                {
                    return false;
                }
            }
            return true;
        }
        static void Result(char[] input) {
            Array.Sort(input);
            int count = 1;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"  {input[i]} --- {count} ");
                    count = 1;
                }
            }
            Console.WriteLine($"  {input[input.Length - 1]} --- {count} ");
        }
    }
}
