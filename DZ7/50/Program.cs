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
			array[i,j] =new Random().Next(-10,10);
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
void ElementSearch(int column, int line, int m, int n, int[,] array)
{
    if (line < n && column < m)
        Console.Write(array[line, column]);
    else Console.Write("Такого элемента нет");
}

int column = Read("Введите № столбца ");
int line = Read("Введите № строки ");

int m = 5;
int n = 5;
int [,] array = new int[m, n];
FuelArray(m, n, array);
ElementSearch(column, line, m, n, array);

// Второй вариант


// void FuelArray(int m, int n, int[,] array)
// {
//     for(int i = 0; i<m; i++){
// 		for(int j = 0; j<n; j++)
//         {
// 			array[i,j] =new Random().Next(-10,10);
//         }
// 	}

// 	for(int i = 0; i<array.GetLength(0); i++)
//     {
// 		for(int j = 0; j<array.GetLength(1); j++)
//         {
// 			Console.Write(array[i,j] + "  ");
// 		}
// 		Console.WriteLine();
// 	}
// }
// void ElementSearch(int column, int line, int m, int n, int[,] array)
// {
//     if (line < n && column < m)
//         Console.Write(array[column, line]);
//     else Console.Write("Такого элемента нет");
// }

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int column = number[0] - '0';
// int line = number[1] - '0';

// int m = 5;
// int n = 5;
// int [,] array = new int[m, n];
// FuelArray(m, n, array);
// ElementSearch(column, line, m, n, array);
