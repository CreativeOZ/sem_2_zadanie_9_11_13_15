// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
Console.Clear();

int a = int.Parse(Console.ReadLine());
Console.WriteLine(a);
int b = a % 10;
Console.WriteLine(b);
int c = (a-b) / 10;
Console.WriteLine(c);
if (b > c) Console.WriteLine(b);
else Console.WriteLine(c);