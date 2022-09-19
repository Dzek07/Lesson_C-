int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

string Numbers(int m, int n)
{
    if (m == n) 
        return m.ToString();
 
    return (m + " " + Numbers(m + 1, n));
}


int m = Read("Введите M ");
int n = Read("Введите N ");


Console.WriteLine(Numbers(m,n));