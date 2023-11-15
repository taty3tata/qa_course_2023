/*S2.1. Составить программу:
а) вычисления значения функции y=7x2+3x+6 при любом значении x;
б) вычисления значения функции x=12a2+7a+12 при любом значении а.
*/
Console.WriteLine("Введите переменную x ");
double x = double.Parse(Console. ReadLine());

Console.WriteLine("Введите переменную a");
float a = float.Parse(Console. ReadLine());

double y = 7 * x * x + 3 * x + 6;

x = 12 * Math.Pow(a, 2) + 7 * a + 12;

Console.WriteLine("значение y={0}", Math.Round(y, 2));
Console.WriteLine("значение x={0}", Math.Round(x, 2));

Console.ReadKey();