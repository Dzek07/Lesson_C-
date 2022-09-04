Console.WriteLine("Введите число 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int y = Convert.ToInt32(Console.ReadLine());



int result = Degre(x,y);

Console.WriteLine(result);


int Degre(int x, int y)
{
    int degre = 1;
    for(int count = 0; count < y; count++)
        degre = degre * x;
    
    return degre;
    
}