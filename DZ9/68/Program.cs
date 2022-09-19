int AckermannFun(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermannFun(n - 1, 1);
    else
      return AckermannFun(n - 1, AckermannFun(n, m - 1));
}

int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

int m = Read("Введите M ");
int n = Read("Введите N ");

Console.WriteLine(AckermannFun(n,m));

