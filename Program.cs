using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число целое число");
            string MyString = null;
            try
            {
                N = int.Parse(Console.ReadLine());
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        if (N % i == 0)
                        {
                            MyString += i + "; ";
                        }
                    }
                    Console.WriteLine("Cписок целочисленных делителей числа {0}: = {1}", N, MyString);
                    Console.ReadLine();

                }
            }
            catch
            {
                Console.WriteLine("При вводе была допущена ошибка");
                Console.ReadLine();

            }
        }
    }
}
