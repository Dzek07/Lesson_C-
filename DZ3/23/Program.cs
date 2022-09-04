Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
int cub = 0;
Cube(x,cub,i);


void Cube(int x, double cub, int i)
{
    while(i < x + 1)
    {
        cub = Math.Pow(i, 3);
        Console.Write(cub + ", ");
        i++;
    }
        
}