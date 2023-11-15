/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте константу с именем pi(число π «пи»), создайте переменную радиус с именем – r.
Используя формулу πR2, вычислите площадь круга и выведите результат на экран.
 */

using System;
namespace home.work_2
{
    class Zadanie_3
    {
        const double pi = Math.PI;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            int r = int.Parse(Console.ReadLine());

            double S = pi * Math.Pow(r, 2);

            Console.WriteLine("Площадь равна {0} см2 ", Math.Round(S, 3));
            Console.ReadKey();

        }
    }
}

