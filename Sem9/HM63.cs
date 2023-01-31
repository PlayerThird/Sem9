//Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
using System;

namespace Sem9
{
    internal class HM63
    {
        internal static void Start()
        {
            int n = Checker.CheckInput<int>(x => x < 1, "Введите N","Ниже нельзя");
            Console.Write($"{n} = ");
            Recurs(1);
            
            void Recurs(int el)
            {
                Console.Write($"{el}, ");
                if (el == n)
                {
                    return;
                }
                Recurs(el+1);
            }
        }
    }
}