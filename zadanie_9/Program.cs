// Показать последнюю цифру трёхзначного числа. !! Подходит для любого объёма чисел !!
Console.Clear();

int EndNumber(int Number)
{
    int result = Number % 10;
    return result;
}
Console.Write("Ввести число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра " + EndNumber(num));