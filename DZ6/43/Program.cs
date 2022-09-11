double Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}




double b1 = Read("Введите b1 ");
double k1 = Read("Введите k1 ");
double b2 = Read("Введите b2 ");
double k2 = Read("Введите k2 ");

double x = (b2 - b1)/(k1 - k2);
double y = 5 * x + 2;

Console.WriteLine("(" + x + ";" + y + ")");





