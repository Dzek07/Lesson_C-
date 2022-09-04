Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = x * (-1);

while (i <= x)
{
    Console.Write(i);
    Console.Write(", ");
    i++;
}