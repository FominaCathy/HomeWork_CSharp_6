using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2-> 2
//- 1, -7, 567, 89, 223-> 3

namespace Task_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            int count = 0;

            Console.WriteLine("Введите числа через Enter. по окончанию ввода ведите пробел");
            number = Console.ReadLine();

            while (number != " ")
            {
                if (int.Parse(number) > 0) count++;
                number = Console.ReadLine();
            }
            Console.WriteLine($"Введено {count} чисел(числа) больше нуля");
            Console.ReadLine();
            
        }
    }
}
