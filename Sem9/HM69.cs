//Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B с помощью рекурсии
using System;

namespace Sem9
{
    internal class HM69
    {
        internal static void Start()
        {
            int A = 2; 
            int B = 3;
            Console.WriteLine($"{step(B-1)}");
            int step(int raz)
            {
                A *= A;
                if (raz == 1)
                {
                    return A;
                }
                step(raz-1);
                return A;
            }
        }
    }
}