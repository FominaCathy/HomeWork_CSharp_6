using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

namespace Task_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float k1, k2, b1, b2;

            Input_Data();

            if (k1 == k2)
                if (b1 == b2)
                    Console.WriteLine("Прямые совпадают");
                else 
                    Console.WriteLine("Прямые параллельны и точки пересечения нет");
            else
            {
                Console.WriteLine($"точка пересечения прямых({((b2 - b1) / (k1 - k2)):f2}, {(k1 * ((b2 - b1) / (k1 - k2)) + b1):f2})");
            }

            Console.ReadLine();


            void Input_Data()
            {
                
                Console.WriteLine("Введите параметры для уравнения первой прямой y = k1 * x + b1: ");
                Console.Write("k1 = ");
                k1 = int.Parse(Console.ReadLine());
                Console.Write("b1 = ");
                b1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите параметры для уравнения второй прямой y = k2 * x + b2: ");
                Console.Write("k2 = ");
                k2 = int.Parse(Console.ReadLine());
                Console.Write("b2 = ");
                b2 = int.Parse(Console.ReadLine());
            }

        }
    }
}
