//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
using System;
using System.Security.Cryptography.X509Certificates;

namespace Sem9
{
    internal class HM67
    {
        internal static void Start()
        {
            int num = Checker.CheckInput<int>(x => x < 0, "Введите число", "Не может быть меньше 0");
            
            int temp = 0;
            int sum = Summary(num);
            Console.WriteLine($"{num} += {sum}");
            int Summary(int num)
            {
                temp += num%10;
                if (num == 0) { return temp; }
                else
                {
                    Summary(num / 10);
                }
                return temp;
            }
            //int number = 12312425;
            //Console.WriteLine($"{number} - > {recursive(number)}");
            //static int recursive(int number)
            //{
            //    if (number == 0) return 0;
            //    return number % 10 + recursive(number / 10);
            //}
        }
    }
}