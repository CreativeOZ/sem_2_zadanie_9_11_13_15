// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
Console.Clear();

int a = new Random().Next(10,100);
Console.WriteLine(a);
int b = a % 10;
int c = a / 10;
if (b > c) Console.Write($"Наибольшая цифра: {b}");
else Console.Write($"Наибольшая цифра: {c}");
