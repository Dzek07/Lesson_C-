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

void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
		for(int j = 0; j<array.GetLength(1); j++)
        {
			Console.Write(array[i,j] + "  ");
		}
		Console.WriteLine();
	}
}

void Sort(int[,] array, int m, int n)
{
    int tmp = 0;
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            for(int k = j+1; k<array.GetLength(1); k++)
            {
                if(array[i,j] < array[i,k])
                {
                    tmp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = tmp;
                }

            }
        }
    }

}


int m = Read("Введите Кол-во строк ");
int n = Read("Введите Кол-во столбцов ");




int [,] array = new int[m, n];

FuelArray(m, n, array);
Console.WriteLine("-------");
Sort(array, m, n);
PrintArray(array);
