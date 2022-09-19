int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

int Sum(int num)
{
    if (num == 0) 
        return num;
 
    return (num + Sum(num - 1));
}


int m = Read("Введите M ");
int n = Read("Введите N ");

if(n>m)
    Console.WriteLine(Sum(n)-Sum(m-1));

else Console.WriteLine(Sum(m)-Sum(n-1));