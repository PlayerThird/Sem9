//Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
using System;

namespace Sem9
{
    internal class HM65
    {
        internal static void Start()
        {
            int m = Checker.CheckInput<int>(x => x < 1, "Введите M", "Ниже нельзя");
            
            int n = Checker.CheckInput<int>(x => x < 1, "Введите N", "Ниже нельзя");
            
            Console.Write($" от {m} до {n} = ");
            Recurs(m);

            void Recurs(int el)
            {
                Console.Write($"{el}, ");
                if (el == n)
                {
                    return;
                }
                Recurs(el + 1);
            }
        }
    }
}