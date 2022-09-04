Console.WriteLine("Введите число от 1 до 7: ");
int x = Convert.ToInt32(Console.ReadLine());
Week(x);

void Week(int x)
{
    if (x>0 && x<8)
    {
        if (x<6)
            Console.WriteLine("Сегодня не выходной");
        else
            Console.WriteLine("Сегодня выходной");
    }
    else
        Console.WriteLine("Введите число от 1 до 7 еще раз");
    
}