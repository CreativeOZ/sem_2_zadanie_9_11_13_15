// Дано число. Проверить кратно ли оно 7 и 23.
Console.Clear();

Console.WriteLine("Ввести число: ");
int a = int.Parse(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0) Console.Write("Число " + a + " крано 7 и 23");
else Console.Write("Число не кратно 7 и 23");
