using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.


namespace ADD_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dec_numm = 24;
            string bynary_numm = String.Empty;

            Trans_Recurs(dec_numm);
            Console.WriteLine(bynary_numm);
            Console.ReadLine();

            int Trans_Recurs(int numm)
            {
                if (numm >= 2) 
                    Trans_Recurs(numm / 2);
                bynary_numm = String.Concat(bynary_numm, (numm % 2));
                return numm % 2;
            }
        }
    }
}
