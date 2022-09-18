int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}


void FuelArray(int m, int n, int[,] array)
{
    for(int i = 0; i<m; i++){
		for(int j = 0; j<n; j++)
        {
			array[i,j] =new Random().Next(0,10);
        }
	}

	for(int i = 0; i<array.GetLength(0); i++)
    {
		for(int j = 0; j<array.GetLength(1); j++)
        {
			Console.Write(array[i,j] + "  ");
		}
		Console.WriteLine();
	}
}


int MinSumLine(int[,] array)
{
    int sum = 0;
    int minline = 0;
    int sumline = 0;
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            sumline = sumline + array[i,j];
        }
        if(i==0)
            sum = sumline;
        if(sumline<sum)
        {
            sum = sumline;
            minline = i+1;
        }
        sumline = 0;
    }
    return minline;

}


int m = Read("Введите Кол-во строк ");
int n = Read("Введите Кол-во столбцов ");




int [,] array = new int[m, n];

FuelArray(m, n, array);
Console.WriteLine("-------");

Console.WriteLine("В " + MinSumLine(array) + " строке наименьшая сумма элементов");
