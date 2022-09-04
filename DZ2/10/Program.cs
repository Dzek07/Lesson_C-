Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(Second_number(x));

int Second_number(int x)
{
    x = x / 10;
    x = x % 10;
    return x;
}