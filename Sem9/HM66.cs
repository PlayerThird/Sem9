//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
using System;

namespace Sem9
{
    internal class HM66
    {
        internal static void Start()
        {
            int m = Checker.CheckInput<int>(x => x < 1, "Введите M", "Ниже нельзя");

            int n = Checker.CheckInput<int>(x => x <= m, "Введите N", "Ты убил логику программы, N должна быть больше M");
            int sum = 0;
            
            Recurs(m);
            Console.Write($" от {m} до {n} = {sum}");
            void Recurs(int el)
            {
                sum += el;
                if (el == n)
                {
                    return;
                }
                Recurs(el + 1);
            }
        }
    }
}