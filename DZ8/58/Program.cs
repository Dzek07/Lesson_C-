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
void Average(int[,] array, int[,] array1, int[,] resault)
{
    for (int i = 0; i < resault.GetLength(0); i++)
    {
        for (int k = 0; k < resault.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                resault[i, k] += array1[j, k]*array[i, j];  
            }
            Console.Write("{0} ", resault[i, k]);
        }
        Console.WriteLine();
    }
    Console.ReadLine();
}

int m = Read("Введите Кол-во строк первой матрицы ");
int n = Read("Введите Кол-во столбцов первой матрицы ");
int m1 = Read("Введите Кол-во строк второй матрицы ");
int n1 = Read("Введите Кол-во строк второй матрицы ");

int m2 = m;
int n2 = n1;
int [,] array = new int[m, n];
int [,] array1 = new int[m1, n1];
int [,] resault = new int[m2, n2];


FuelArray(m, n, array);
Console.WriteLine("-------");
FuelArray(m1, n1, array1);
Console.WriteLine("-------");
if(n == m1)
    Average(array, array1, resault);
else
    Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");


