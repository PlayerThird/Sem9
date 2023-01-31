//Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;

namespace Sem9
{
    internal class HM64
    {
        internal static void Start()
        {
            int n = Checker.CheckInput<int>(x => x < 1, "Введите N", "Ниже нельзя");
            Console.Write($"{n} = ");
            Recurs(n);

            void Recurs(int el)
            {
                Console.Write($"{el}, ");
                if (el == 1)
                {
                    return;
                }
                Recurs(el - 1);
            }
        }
    }
}