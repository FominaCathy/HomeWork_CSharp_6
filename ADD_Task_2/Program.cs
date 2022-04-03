using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_2
{
    //Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”.
    //Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
    internal class Program
    {
        static void Main(string[] args)
        {
            string proverb =  "без труда не выловишь и рыбку из пруда";
            string vowels = "уеыаоэяиюёэ";
            int count = 0;

            Console.WriteLine($"поговорка: { proverb}");

            Console.Write($"кол-во гласных букв в поговорке: ");
            Console.WriteLine(Recursion(proverb));
            Console.ReadLine();

            int Recursion(string text)
            {
                if (text.Length > 0)
                {   count = count + vowels.Contains(text[text.Length - 1]).GetHashCode() + Recursion(text.Remove(text.Length - 1));
                }
                return count;        

            }

        }
    }
}
