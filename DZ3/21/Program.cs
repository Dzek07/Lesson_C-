Console.WriteLine("Введите координаты певой точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());
double x2 = Convert.ToInt32(Console.ReadLine());
double x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double y3 = Convert.ToInt32(Console.ReadLine());
double x = 0;

Console.WriteLine(Distance(x,x1,x2,x3,y1,y2,y3));

double Distance(double x, double x1, double x2, double x3, double y1, double y2, double y3)
{
    x = Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2) + Math.Pow(y3 - x3, 2));
    return x;
        
}