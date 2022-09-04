Console.WriteLine("Введите число 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.Write("Максимальное число ");
    Console.WriteLine(x);
}
else
{
    Console.Write("Максимальное число ");
    Console.WriteLine(y);
}