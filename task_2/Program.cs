// See https://aka.ms/new-console-template for more information

/*S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. После
выводимого числа должно следовать сообщение  — «___ вот какое число Вы  ввели».
*/
Console.WriteLine("Введите целое число, введите Enter");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите ваше имя, введите Enter");
string name = Console.ReadLine();//ввод имени

Console.WriteLine(name);
Console.WriteLine(a);
Console.WriteLine($"{a} вот такое число вы ввели {name}");
Console.WriteLine($"твое имя {name}");
Console.ReadKey();
