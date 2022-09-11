int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}


void FuelArray(int m, int n, double[,] array)
{
    double tmp = 0;
	for(int i = 0; i<m; i++){
		for(int j = 0; j<n; j++){
			array[i,j] =new Random().Next(-10,10);
            tmp = new Random().Next(0,9);
            tmp = tmp / 10;
            array[i,j] = array[i,j] + tmp;
        }
	}

	for(int i = 0; i<array.GetLength(0); i++){
		for(int j = 0; j<array.GetLength(1); j++){
			Console.Write(array[i,j] + "  ");
		}
		Console.WriteLine();
	}
}

int m = Read("Введите m ");
int n = Read("Введите n ");
double [,] array = new double[m, n];
FuelArray(m, n, array);


