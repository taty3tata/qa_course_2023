/*Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу расчета объема - V и площади поверхности -S цилиндра.
Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h
Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 + 2πRh
 */

using System;
namespace home.work_2
{
    class Zadanie_3
    {
        const double pi = Math.PI;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус цилиндра");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра");
            int h = int.Parse(Console.ReadLine());

            double S = 2*pi * Math.Pow(r, 2)+2*pi*r*h;
            double V = 2*pi * r * h;


            Console.WriteLine("Площадь поверхности цилиндра {0} см2 ", Math.Round(S, 3));
            Console.WriteLine("Объем цилиндра {0} см3 ", Math.Round(V, 3));
            Console.ReadKey();
        }
    }
}
