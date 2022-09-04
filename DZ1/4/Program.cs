Console.WriteLine("Введите число 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x > y)
    if (x > z)
    {
        Console.Write("Максимальное число ");
        Console.WriteLine(x);
    }

    else
    {
        Console.Write("Максимальное число ");
        Console.WriteLine(z);
    }
else if (y > z)
    {
        Console.Write("Максимальное число ");
        Console.WriteLine(y);
    }
    else
    {
        Console.Write("Максимальное число ");
        Console.WriteLine(z);
    }