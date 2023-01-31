//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
using System;

namespace Sem9
{
    internal class HM68
    {
        internal static void Start()
        {
            int m = Checker.CheckInput<int>(x => x < 1, "Введите M", "Ниже нельзя");
            int n = Checker.CheckInput<int>(x => x <= m, "Введите N", "Ты убил логику программы, N должна быть больше M");

            m = Akker(m, n);
            Console.WriteLine(m);
        }

        public static int Akker(int m, int n)
        {
            int res = 0;
            if (m == 0) res = n + 1;
            if (m > 0 && n == 0) res = Akker(m - 1, 1);
            if (m > 0 && n > 0) res = Akker(m - 1, Akker(m, n - 1));
            return res;
        }

    }
}