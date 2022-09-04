Console.WriteLine("Введите число: ");
string x = Console.ReadLine();
ThirdNumber(x);

void ThirdNumber(string x)
{
    if(x.Length > 2)
        Console.WriteLine(x[2]);
    else
        Console.WriteLine("Нет третьей цифры");
}
