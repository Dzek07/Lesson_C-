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
void ElementSearch(int m, int n, int[,] array)
{
    for(int j = 0; j<m; j++)
    {
		double sum = 0;
        for(int i = 0; i<n; i++)
        {
			sum = sum + array[i,j];
        }
    Console.Write((sum/m) + "  ");
	}
}

int m = Read("Введите № столбца ");
int n = Read("Введите № строки ");

int [,] array = new int[m, n];
FuelArray(m, n, array);
ElementSearch(m, n, array);

