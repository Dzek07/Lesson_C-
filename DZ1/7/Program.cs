Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = x / 10;
y = y * 10;
x = x - y;
Console.Write(x);