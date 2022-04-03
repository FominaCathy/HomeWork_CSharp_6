using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 3. Дано число N. Используя рекурсию, определите, что оно является степенью числа 3.

namespace ADD_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 81;
            int degree = 0;
            
            
                if (number == 0)
                    Console.WriteLine($"число {number} НЕ является степенью числа 3");
                else if ((Recurcy(number) ==0)||(number == 1))
                    Console.WriteLine($"число {number} является степенью числа 3");

                else //(Recurcy(number) != 0)
                    Console.WriteLine($"число {number} НЕ является степенью числа 3");
            
            Console.ReadLine();

            int Recurcy (int numm)
            {
                if (numm == 3)
                    degree += 0;
                else if ((numm > 3)&(numm%3 == 0))

                    Recurcy(numm / 3);
                return degree += numm % 3;
                
            }

        }
    }
}
