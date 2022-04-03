using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ADD_Task_Time
{
    internal class Program
    {
        //Задача 1*. Создайте программу, показывающую текущее время.
        static void Main(string[] args)
        {
            int[,] arraytime = new int[7, 27];

            int  [][,] numbers = new int[10][,];

            numbers[0] = new int[7, 3] { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 0, 1, 0 } };
            numbers[1] = new int[7, 3] { { 0, 0, 1 }, { 0, 1, 1 }, { 1, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 } };
            numbers[2] = new int[7, 3] { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 0, 1, 0 }, { 1, 0, 0 }, { 1, 1, 1 } }; 
            numbers[3] = new int[7, 3] { { 1, 1, 0 }, { 0, 0, 1 }, { 0, 0, 1 }, { 1, 1, 0 }, { 0, 0, 1 }, { 0, 0, 1 }, { 1, 1, 0 } };
            numbers[4] = new int[7, 3] { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 } };
            numbers[5] = new int[7, 3] { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 0 }, { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 1, 1, 0 } };
            numbers[6] = new int[7, 3] { { 0, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 }, { 0, 1, 0 } };
            numbers[7] = new int[7, 3] { { 1, 1, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 0, 1, 0 }, { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 0 } };
            numbers[8] = new int[7, 3] { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 }, { 0, 1, 0 } };
            numbers[9] = new int[7, 3] { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 0, 0, 1 }, { 0, 0, 1 }, { 0, 1, 0 } };

            arraytime[2, 8] = 1;
            arraytime[4, 8] = 1;
            arraytime[2, 18] = 1;
            arraytime[4, 18] = 1;

            while (Console.KeyAvailable == false)
            {
                Console.Clear();
                CreateTime();
                PrintTime();
                Thread.Sleep(1000);               
            }
            

            void PrintTime()
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 27; j++)
                        if (arraytime[i, j] == 1) Console.Write(" #");
                        else Console.Write("  ");

                    Console.WriteLine();
                }
            }

            void InputNumber(int[,] nums, int poses)
            {
                for (int i = 0; i < 7; i++)
                    for (int j = 0; j < 3; j++)
                        arraytime[i, j + poses] = nums[i, j];
            }

            
            void CreateTime()
            {
                DateTime moment = DateTime.Now; 
                int hour = moment.Hour;
                int minute = moment.Minute;
                int second = moment.Second;

                //часы
                InputNumber(numbers[hour / 10], 0);
                InputNumber(numbers[hour % 10], 4);
                // минуты
                InputNumber(numbers[minute / 10], 10);
                InputNumber(numbers[minute % 10], 14);
                // секунды
                InputNumber(numbers[second / 10], 20);
                InputNumber(numbers[second % 10], 24);
                // точки


            }   
        }
    }
}
