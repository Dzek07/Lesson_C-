Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= x)
{
    Console.Write(i);
    Console.Write(", ");
    i = i + 2;
}
