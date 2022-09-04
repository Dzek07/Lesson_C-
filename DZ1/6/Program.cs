Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int y = x % 2;
if (y == 0)
{
    Console.Write("Четное число: ");
    Console.WriteLine(x);
}

    else
    {
        Console.Write("Не четное число: ");
        Console.WriteLine(x);
    }
    