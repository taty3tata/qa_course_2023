/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для
корректного отображения результата?
 */

using System;
namespace home.work_1
{
    class Zadanie_2
    {
        static void Main(string[] args) {
            Console.WriteLine("Введите переменную a ");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменную b ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменную c ");
            int c = int.Parse(Console.ReadLine());
        
            double result = (a + b + c) / 3.0;

            Console.WriteLine("значение {0}", Math.Round (result, 3));
            Console.ReadKey();
        }
    }
}